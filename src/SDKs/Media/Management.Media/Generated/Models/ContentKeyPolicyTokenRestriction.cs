// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a token restriction. Provided token must match these
    /// requirements for successful license or key delivery.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.ContentKeyPolicyTokenRestriction")]
    public partial class ContentKeyPolicyTokenRestriction : ContentKeyPolicyRestriction
    {
        /// <summary>
        /// Initializes a new instance of the ContentKeyPolicyTokenRestriction
        /// class.
        /// </summary>
        public ContentKeyPolicyTokenRestriction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContentKeyPolicyTokenRestriction
        /// class.
        /// </summary>
        /// <param name="issuer">The token issuer.</param>
        /// <param name="audience">The audience for the token.</param>
        /// <param name="primaryVerificationKey">The primary verification
        /// key.</param>
        /// <param name="restrictionTokenType">The type of token. Possible
        /// values include: 'Unknown', 'Swt', 'Jwt'</param>
        /// <param name="alternateVerificationKeys">A list of alternative
        /// verification keys.</param>
        /// <param name="requiredClaims">A list of required token
        /// claims.</param>
        /// <param name="openIdConnectDiscoveryDocument">The OpenID connect
        /// discovery document.</param>
        public ContentKeyPolicyTokenRestriction(string issuer, string audience, ContentKeyPolicyRestrictionTokenKey primaryVerificationKey, ContentKeyPolicyRestrictionTokenType restrictionTokenType, IList<ContentKeyPolicyRestrictionTokenKey> alternateVerificationKeys = default(IList<ContentKeyPolicyRestrictionTokenKey>), IList<ContentKeyPolicyTokenClaim> requiredClaims = default(IList<ContentKeyPolicyTokenClaim>), string openIdConnectDiscoveryDocument = default(string))
        {
            Issuer = issuer;
            Audience = audience;
            PrimaryVerificationKey = primaryVerificationKey;
            AlternateVerificationKeys = alternateVerificationKeys;
            RequiredClaims = requiredClaims;
            RestrictionTokenType = restrictionTokenType;
            OpenIdConnectDiscoveryDocument = openIdConnectDiscoveryDocument;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the token issuer.
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or sets the audience for the token.
        /// </summary>
        [JsonProperty(PropertyName = "audience")]
        public string Audience { get; set; }

        /// <summary>
        /// Gets or sets the primary verification key.
        /// </summary>
        [JsonProperty(PropertyName = "primaryVerificationKey")]
        public ContentKeyPolicyRestrictionTokenKey PrimaryVerificationKey { get; set; }

        /// <summary>
        /// Gets or sets a list of alternative verification keys.
        /// </summary>
        [JsonProperty(PropertyName = "alternateVerificationKeys")]
        public IList<ContentKeyPolicyRestrictionTokenKey> AlternateVerificationKeys { get; set; }

        /// <summary>
        /// Gets or sets a list of required token claims.
        /// </summary>
        [JsonProperty(PropertyName = "requiredClaims")]
        public IList<ContentKeyPolicyTokenClaim> RequiredClaims { get; set; }

        /// <summary>
        /// Gets or sets the type of token. Possible values include: 'Unknown',
        /// 'Swt', 'Jwt'
        /// </summary>
        [JsonProperty(PropertyName = "restrictionTokenType")]
        public ContentKeyPolicyRestrictionTokenType RestrictionTokenType { get; set; }

        /// <summary>
        /// Gets or sets the OpenID connect discovery document.
        /// </summary>
        [JsonProperty(PropertyName = "openIdConnectDiscoveryDocument")]
        public string OpenIdConnectDiscoveryDocument { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Issuer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Issuer");
            }
            if (Audience == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Audience");
            }
            if (PrimaryVerificationKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PrimaryVerificationKey");
            }
        }
    }
}
