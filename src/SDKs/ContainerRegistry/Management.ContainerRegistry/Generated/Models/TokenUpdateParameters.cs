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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters for updating a token.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TokenUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the TokenUpdateParameters class.
        /// </summary>
        public TokenUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TokenUpdateParameters class.
        /// </summary>
        /// <param name="scopeMapId">The resource ID of the scope map to which
        /// the token will be associated with.</param>
        /// <param name="status">The status of the token example enabled or
        /// disabled. Possible values include: 'enabled', 'disabled'</param>
        /// <param name="credentials">The credentials that can be used for
        /// authenticating the token.</param>
        public TokenUpdateParameters(string scopeMapId = default(string), string status = default(string), TokenCredentialsProperties credentials = default(TokenCredentialsProperties))
        {
            ScopeMapId = scopeMapId;
            Status = status;
            Credentials = credentials;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource ID of the scope map to which the token
        /// will be associated with.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scopeMapId")]
        public string ScopeMapId { get; set; }

        /// <summary>
        /// Gets or sets the status of the token example enabled or disabled.
        /// Possible values include: 'enabled', 'disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the credentials that can be used for authenticating
        /// the token.
        /// </summary>
        [JsonProperty(PropertyName = "properties.credentials")]
        public TokenCredentialsProperties Credentials { get; set; }

    }
}
