// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RequestStatistics
    {
        /// <summary>
        /// Initializes a new instance of the RequestStatistics class.
        /// </summary>
        public RequestStatistics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RequestStatistics class.
        /// </summary>
        /// <param name="documentsCount">Number of documents submitted in the
        /// request.</param>
        /// <param name="validDocumentsCount">Number of valid documents. This
        /// excludes empty, over-size limit or non-supported languages
        /// documents.</param>
        /// <param name="erroneousDocumentsCount">Number of invalid documents.
        /// This includes empty, over-size limit or non-supported languages
        /// documents.</param>
        /// <param name="transactionsCount">Number of transactions for the
        /// request.</param>
        public RequestStatistics(int? documentsCount = default(int?), int? validDocumentsCount = default(int?), int? erroneousDocumentsCount = default(int?), long? transactionsCount = default(long?))
        {
            DocumentsCount = documentsCount;
            ValidDocumentsCount = validDocumentsCount;
            ErroneousDocumentsCount = erroneousDocumentsCount;
            TransactionsCount = transactionsCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of documents submitted in the request.
        /// </summary>
        [JsonProperty(PropertyName = "documentsCount")]
        public int? DocumentsCount { get; set; }

        /// <summary>
        /// Gets or sets number of valid documents. This excludes empty,
        /// over-size limit or non-supported languages documents.
        /// </summary>
        [JsonProperty(PropertyName = "validDocumentsCount")]
        public int? ValidDocumentsCount { get; set; }

        /// <summary>
        /// Gets or sets number of invalid documents. This includes empty,
        /// over-size limit or non-supported languages documents.
        /// </summary>
        [JsonProperty(PropertyName = "erroneousDocumentsCount")]
        public int? ErroneousDocumentsCount { get; set; }

        /// <summary>
        /// Gets or sets number of transactions for the request.
        /// </summary>
        [JsonProperty(PropertyName = "transactionsCount")]
        public long? TransactionsCount { get; set; }

    }
}
