// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents an index definition in Azure Search, which describes the
    /// fields and search behavior of an index.
    /// </summary>
    public partial class Index
    {
        /// <summary>
        /// Initializes a new instance of the Index class.
        /// </summary>
        public Index()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Index class.
        /// </summary>
        /// <param name="name">The name of the index.</param>
        /// <param name="fields">The fields of the index.</param>
        /// <param name="scoringProfiles">The scoring profiles for the
        /// index.</param>
        /// <param name="defaultScoringProfile">The name of the scoring profile
        /// to use if none is specified in the query. If this property is not
        /// set and no scoring profile is specified in the query, then default
        /// scoring (tf-idf) will be used.</param>
        /// <param name="corsOptions">Options to control Cross-Origin Resource
        /// Sharing (CORS) for the index.</param>
        /// <param name="suggesters">The suggesters for the index.</param>
        /// <param name="analyzers">The analyzers for the index.</param>
        /// <param name="tokenizers">The tokenizers for the index.</param>
        /// <param name="tokenFilters">The token filters for the index.</param>
        /// <param name="charFilters">The character filters for the
        /// index.</param>
        /// <param name="encryptionKey">A description of an encryption key that
        /// you create in Azure Key Vault. This key is used to provide an
        /// additional level of encryption-at-rest for your data when you want
        /// full assurance that no one, not even Microsoft, can decrypt your
        /// data in Azure Search. Once you have encrypted your data, it will
        /// always remain encrypted. Azure Search will ignore attempts to set
        /// this property to null. You can change this property as needed if
        /// you want to rotate your encryption key; Your data will be
        /// unaffected. Encryption with customer-managed keys is not available
        /// for free search services, and is only available for paid services
        /// created on or after January 1, 2019.</param>
        /// <param name="eTag">The ETag of the index.</param>
        public Index(string name, IList<Field> fields, IList<ScoringProfile> scoringProfiles = default(IList<ScoringProfile>), string defaultScoringProfile = default(string), CorsOptions corsOptions = default(CorsOptions), IList<Suggester> suggesters = default(IList<Suggester>), IList<Analyzer> analyzers = default(IList<Analyzer>), IList<Tokenizer> tokenizers = default(IList<Tokenizer>), IList<TokenFilter> tokenFilters = default(IList<TokenFilter>), IList<CharFilter> charFilters = default(IList<CharFilter>), EncryptionKey encryptionKey = default(EncryptionKey), string eTag = default(string))
        {
            Name = name;
            Fields = fields;
            ScoringProfiles = scoringProfiles;
            DefaultScoringProfile = defaultScoringProfile;
            CorsOptions = corsOptions;
            Suggesters = suggesters;
            Analyzers = analyzers;
            Tokenizers = tokenizers;
            TokenFilters = tokenFilters;
            CharFilters = charFilters;
            EncryptionKey = encryptionKey;
            ETag = eTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the index.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the fields of the index.
        /// </summary>
        [JsonProperty(PropertyName = "fields")]
        public IList<Field> Fields { get; set; }

        /// <summary>
        /// Gets or sets the scoring profiles for the index.
        /// </summary>
        [JsonProperty(PropertyName = "scoringProfiles")]
        public IList<ScoringProfile> ScoringProfiles { get; set; }

        /// <summary>
        /// Gets or sets the name of the scoring profile to use if none is
        /// specified in the query. If this property is not set and no scoring
        /// profile is specified in the query, then default scoring (tf-idf)
        /// will be used.
        /// </summary>
        [JsonProperty(PropertyName = "defaultScoringProfile")]
        public string DefaultScoringProfile { get; set; }

        /// <summary>
        /// Gets or sets options to control Cross-Origin Resource Sharing
        /// (CORS) for the index.
        /// </summary>
        [JsonProperty(PropertyName = "corsOptions")]
        public CorsOptions CorsOptions { get; set; }

        /// <summary>
        /// Gets or sets the suggesters for the index.
        /// </summary>
        [JsonProperty(PropertyName = "suggesters")]
        public IList<Suggester> Suggesters { get; set; }

        /// <summary>
        /// Gets or sets the analyzers for the index.
        /// </summary>
        [JsonProperty(PropertyName = "analyzers")]
        public IList<Analyzer> Analyzers { get; set; }

        /// <summary>
        /// Gets or sets the tokenizers for the index.
        /// </summary>
        [JsonProperty(PropertyName = "tokenizers")]
        public IList<Tokenizer> Tokenizers { get; set; }

        /// <summary>
        /// Gets or sets the token filters for the index.
        /// </summary>
        [JsonProperty(PropertyName = "tokenFilters")]
        public IList<TokenFilter> TokenFilters { get; set; }

        /// <summary>
        /// Gets or sets the character filters for the index.
        /// </summary>
        [JsonProperty(PropertyName = "charFilters")]
        public IList<CharFilter> CharFilters { get; set; }

        /// <summary>
        /// Gets or sets a description of an encryption key that you create in
        /// Azure Key Vault. This key is used to provide an additional level of
        /// encryption-at-rest for your data when you want full assurance that
        /// no one, not even Microsoft, can decrypt your data in Azure Search.
        /// Once you have encrypted your data, it will always remain encrypted.
        /// Azure Search will ignore attempts to set this property to null. You
        /// can change this property as needed if you want to rotate your
        /// encryption key; Your data will be unaffected. Encryption with
        /// customer-managed keys is not available for free search services,
        /// and is only available for paid services created on or after January
        /// 1, 2019.
        /// </summary>
        [JsonProperty(PropertyName = "encryptionKey")]
        public EncryptionKey EncryptionKey { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the index.
        /// </summary>
        [JsonProperty(PropertyName = "@odata.etag")]
        public string ETag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Fields == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Fields");
            }
            if (Fields != null)
            {
                foreach (var element in Fields)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ScoringProfiles != null)
            {
                foreach (var element1 in ScoringProfiles)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (CorsOptions != null)
            {
                CorsOptions.Validate();
            }
            if (Suggesters != null)
            {
                foreach (var element2 in Suggesters)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (Analyzers != null)
            {
                foreach (var element3 in Analyzers)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (Tokenizers != null)
            {
                foreach (var element4 in Tokenizers)
                {
                    if (element4 != null)
                    {
                        element4.Validate();
                    }
                }
            }
            if (TokenFilters != null)
            {
                foreach (var element5 in TokenFilters)
                {
                    if (element5 != null)
                    {
                        element5.Validate();
                    }
                }
            }
            if (CharFilters != null)
            {
                foreach (var element6 in CharFilters)
                {
                    if (element6 != null)
                    {
                        element6.Validate();
                    }
                }
            }
            if (EncryptionKey != null)
            {
                EncryptionKey.Validate();
            }
        }
    }
}
