// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Update Body schema to represent context to be updated
    /// </summary>
    public partial class UpdateContextDTO
    {
        /// <summary>
        /// Initializes a new instance of the UpdateContextDTO class.
        /// </summary>
        public UpdateContextDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateContextDTO class.
        /// </summary>
        /// <param name="promptsToDelete">List of prompts associated with qna
        /// to be deleted</param>
        /// <param name="promptsToAdd">List of prompts to be added to the
        /// qna.</param>
        /// <param name="isContextOnly">To mark if a prompt is relevant only
        /// with a previous question or not.
        /// true - Do not include this QnA as search result for queries without
        /// context
        /// false - ignores context and includes this QnA in search
        /// result</param>
        public UpdateContextDTO(IList<int?> promptsToDelete = default(IList<int?>), IList<PromptDTO> promptsToAdd = default(IList<PromptDTO>), bool? isContextOnly = default(bool?))
        {
            PromptsToDelete = promptsToDelete;
            PromptsToAdd = promptsToAdd;
            IsContextOnly = isContextOnly;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of prompts associated with qna to be deleted
        /// </summary>
        [JsonProperty(PropertyName = "promptsToDelete")]
        public IList<int?> PromptsToDelete { get; set; }

        /// <summary>
        /// Gets or sets list of prompts to be added to the qna.
        /// </summary>
        [JsonProperty(PropertyName = "promptsToAdd")]
        public IList<PromptDTO> PromptsToAdd { get; set; }

        /// <summary>
        /// Gets or sets to mark if a prompt is relevant only with a previous
        /// question or not.
        /// true - Do not include this QnA as search result for queries without
        /// context
        /// false - ignores context and includes this QnA in search result
        /// </summary>
        [JsonProperty(PropertyName = "isContextOnly")]
        public bool? IsContextOnly { get; set; }

    }
}
