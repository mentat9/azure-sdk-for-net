// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A set of rules governing the network accessibility of a vault.
    /// </summary>
    public partial class NetworkRuleSet
    {
        /// <summary>
        /// Initializes a new instance of the NetworkRuleSet class.
        /// </summary>
        public NetworkRuleSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkRuleSet class.
        /// </summary>
        /// <param name="bypass">Tells what traffic can bypass network rules.
        /// This can be 'AzureServices' or 'None'.  If not specified the
        /// default is 'AzureServices'. Possible values include:
        /// 'AzureServices', 'None'</param>
        /// <param name="defaultAction">The default action when no rule from
        /// ipRules and from virtualNetworkRules match. This is only used after
        /// the bypass property has been evaluated. Possible values include:
        /// 'Allow', 'Deny'</param>
        /// <param name="ipRules">The list of IP address rules.</param>
        /// <param name="virtualNetworkRules">The list of virtual network
        /// rules.</param>
        public NetworkRuleSet(string bypass = default(string), string defaultAction = default(string), IList<IPRule> ipRules = default(IList<IPRule>), IList<VirtualNetworkRule> virtualNetworkRules = default(IList<VirtualNetworkRule>))
        {
            Bypass = bypass;
            DefaultAction = defaultAction;
            IpRules = ipRules;
            VirtualNetworkRules = virtualNetworkRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets tells what traffic can bypass network rules. This can
        /// be 'AzureServices' or 'None'.  If not specified the default is
        /// 'AzureServices'. Possible values include: 'AzureServices', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "bypass")]
        public string Bypass { get; set; }

        /// <summary>
        /// Gets or sets the default action when no rule from ipRules and from
        /// virtualNetworkRules match. This is only used after the bypass
        /// property has been evaluated. Possible values include: 'Allow',
        /// 'Deny'
        /// </summary>
        [JsonProperty(PropertyName = "defaultAction")]
        public string DefaultAction { get; set; }

        /// <summary>
        /// Gets or sets the list of IP address rules.
        /// </summary>
        [JsonProperty(PropertyName = "ipRules")]
        public IList<IPRule> IpRules { get; set; }

        /// <summary>
        /// Gets or sets the list of virtual network rules.
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkRules")]
        public IList<VirtualNetworkRule> VirtualNetworkRules { get; set; }

    }
}
