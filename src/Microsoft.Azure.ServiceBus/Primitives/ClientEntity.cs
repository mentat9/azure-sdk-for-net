﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.ServiceBus
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Core;

    /// <summary>
    /// Contract for all client entities with Open-Close/Abort state m/c
    /// main-purpose: closeAll related entities
    /// </summary>
    public abstract class ClientEntity : IClientEntity
    {
        static int nextId;
        readonly object syncLock;

        /// <summary></summary>
        /// <param name="clientId"></param>
        /// <param name="retryPolicy"></param>
        protected ClientEntity(string clientId, RetryPolicy retryPolicy)
        {
            if (retryPolicy == null)
            {
                throw new ArgumentNullException(nameof(retryPolicy));
            }

            this.ClientId = clientId;
            this.RetryPolicy = retryPolicy;
            this.syncLock = new object();
        }

        /// <summary>
        /// Gets or sets the state of closing.
        /// </summary>
        public bool IsClosedOrClosing
        {
            get;
            set;
        }

        /// <summary>
        /// Duration after which individual operations will timeout.
        /// </summary>
        public TimeSpan OperationTimeout { get; internal set; }

        /// <summary>
        /// Gets the client ID.
        /// </summary>
        public string ClientId { get; private set; }

        /// <summary>
        /// Gets the <see cref="ServiceBus.RetryPolicy"/> for the ClientEntity.
        /// </summary>
        public RetryPolicy RetryPolicy { get; private set; }

        /// <summary>
        /// Closes the Client. Closes the connections opened by it.
        /// </summary>
        /// <returns>The asynchronous operation</returns>
        public async Task CloseAsync()
        {
            bool callClose = false;
            lock (this.syncLock)
            {
                if (!this.IsClosedOrClosing)
                {
                    this.IsClosedOrClosing = true;
                    callClose = true;
                }
            }

            if (callClose)
            {
                await this.OnClosingAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Gets a list of currently registered plugins for this client.
        /// </summary>
        public abstract IList<ServiceBusPlugin> RegisteredPlugins { get; }

        /// <summary>
        /// Registers a <see cref="ServiceBusPlugin"/> to be used with this client.
        /// </summary>
        /// <param name="serviceBusPlugin">The <see cref="ServiceBusPlugin"/> to register.</param>
        public abstract void RegisterPlugin(ServiceBusPlugin serviceBusPlugin);

        /// <summary>
        /// Unregisters a <see cref="ServiceBusPlugin"/>.
        /// </summary>
        /// <param name="serviceBusPluginName">The name <see cref="ServiceBusPlugin.Name"/> to be unregistered</param>
        public abstract void UnregisterPlugin(string serviceBusPluginName);

        /// <summary></summary>
        /// <returns></returns>
        protected abstract Task OnClosingAsync();

        /// <summary></summary>
        /// <returns></returns>
        protected static long GetNextId()
        {
            return Interlocked.Increment(ref nextId);
        }
    }
}