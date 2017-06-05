// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ArmTemplatesOperations operations.
    /// </summary>
    public partial interface IArmTemplatesOperations
    {
        /// <summary>
        /// List azure resource manager templates in a given artifact source.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='artifactSourceName'>
        /// The name of the artifact source.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ArmTemplate>>> ListWithHttpMessagesAsync(string labName, string artifactSourceName, ODataQuery<ArmTemplate> odataQuery = default(ODataQuery<ArmTemplate>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get azure resource manager template.
        /// </summary>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='artifactSourceName'>
        /// The name of the artifact source.
        /// </param>
        /// <param name='name'>
        /// The name of the azure Resource Manager template.
        /// </param>
        /// <param name='expand'>
        /// Specify the $expand query. Example:
        /// 'properties($select=displayName)'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ArmTemplate>> GetWithHttpMessagesAsync(string labName, string artifactSourceName, string name, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List azure resource manager templates in a given artifact source.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ArmTemplate>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}