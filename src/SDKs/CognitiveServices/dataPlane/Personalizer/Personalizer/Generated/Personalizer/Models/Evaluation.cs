// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Personalizer.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Evaluation
    {
        /// <summary>
        /// Initializes a new instance of the Evaluation class.
        /// </summary>
        public Evaluation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Evaluation class.
        /// </summary>
        /// <param name="status">Possible values include: 'completed',
        /// 'pending', 'failed', 'notSubmitted'</param>
        public Evaluation(string id = default(string), string name = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string jobId = default(string), string status = default(string), IList<PolicyResult> policyResults = default(IList<PolicyResult>))
        {
            Id = id;
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            JobId = jobId;
            Status = status;
            PolicyResults = policyResults;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; private set; }

        /// <summary>
        /// Gets possible values include: 'completed', 'pending', 'failed',
        /// 'notSubmitted'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "policyResults")]
        public IList<PolicyResult> PolicyResults { get; set; }

    }
}
