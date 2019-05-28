// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The quarantine policy for a container registry.
    /// </summary>
    public partial class QuarantinePolicy
    {
        /// <summary>
        /// Initializes a new instance of the QuarantinePolicy class.
        /// </summary>
        public QuarantinePolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuarantinePolicy class.
        /// </summary>
        /// <param name="status">The value that indicates whether the policy is
        /// enabled or not. Possible values include: 'enabled',
        /// 'disabled'</param>
        public QuarantinePolicy(string status = default(string))
        {
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value that indicates whether the policy is enabled
        /// or not. Possible values include: 'enabled', 'disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}
