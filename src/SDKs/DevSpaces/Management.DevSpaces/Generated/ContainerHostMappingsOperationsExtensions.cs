// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevSpaces
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ContainerHostMappingsOperations.
    /// </summary>
    public static partial class ContainerHostMappingsOperationsExtensions
    {
            /// <summary>
            /// Returns container host mapping object for a container host resource ID if
            /// an associated controller exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group to which the resource belongs.
            /// </param>
            /// <param name='location'>
            /// Location of the container host.
            /// </param>
            /// <param name='containerHostResourceId'>
            /// ARM ID of the Container Host resource
            /// </param>
            public static object GetContainerHostMapping(this IContainerHostMappingsOperations operations, string resourceGroupName, string location, string containerHostResourceId = default(string))
            {
                return operations.GetContainerHostMappingAsync(resourceGroupName, location, containerHostResourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns container host mapping object for a container host resource ID if
            /// an associated controller exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group to which the resource belongs.
            /// </param>
            /// <param name='location'>
            /// Location of the container host.
            /// </param>
            /// <param name='containerHostResourceId'>
            /// ARM ID of the Container Host resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetContainerHostMappingAsync(this IContainerHostMappingsOperations operations, string resourceGroupName, string location, string containerHostResourceId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetContainerHostMappingWithHttpMessagesAsync(resourceGroupName, location, containerHostResourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
