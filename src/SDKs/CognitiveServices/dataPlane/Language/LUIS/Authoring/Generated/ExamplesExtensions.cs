// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Examples.
    /// </summary>
    public static partial class ExamplesExtensions
    {
            /// <summary>
            /// Adds a labeled example utterance in a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
            /// 'westcentralus', 'westus2', 'eastus', 'southcentralus', 'northeurope',
            /// 'eastasia', 'australiaeast', 'brazilsouth', 'virginia'
            /// </param>
            /// <param name='azureCloud'>
            /// Supported Azure Clouds for Cognitive Services endpoints. Possible values
            /// include: 'com', 'us'
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='exampleLabelObject'>
            /// A labeled example utterance with the expected intent and entities.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LabelExampleResponse> AddAsync(this IExamples operations, AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, ExampleLabelObject exampleLabelObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddWithHttpMessagesAsync(azureRegion, azureCloud, appId, versionId, exampleLabelObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a batch of labeled example utterances to a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
            /// 'westcentralus', 'westus2', 'eastus', 'southcentralus', 'northeurope',
            /// 'eastasia', 'australiaeast', 'brazilsouth', 'virginia'
            /// </param>
            /// <param name='azureCloud'>
            /// Supported Azure Clouds for Cognitive Services endpoints. Possible values
            /// include: 'com', 'us'
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='exampleLabelObjectArray'>
            /// Array of example utterances.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<BatchLabelExample>> BatchAsync(this IExamples operations, AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, IList<ExampleLabelObject> exampleLabelObjectArray, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BatchWithHttpMessagesAsync(azureRegion, azureCloud, appId, versionId, exampleLabelObjectArray, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns example utterances to be reviewed from a version of the
            /// application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
            /// 'westcentralus', 'westus2', 'eastus', 'southcentralus', 'northeurope',
            /// 'eastasia', 'australiaeast', 'brazilsouth', 'virginia'
            /// </param>
            /// <param name='azureCloud'>
            /// Supported Azure Clouds for Cognitive Services endpoints. Possible values
            /// include: 'com', 'us'
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='skip'>
            /// The number of entries to skip. Default value is 0.
            /// </param>
            /// <param name='take'>
            /// The number of entries to return. Maximum page size is 500. Default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LabeledUtterance>> ListAsync(this IExamples operations, AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, int? skip = 0, int? take = 100, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(azureRegion, azureCloud, appId, versionId, skip, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the labeled example utterances with the specified ID from a version
            /// of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Supported Azure regions for Cognitive Services endpoints. Possible values
            /// include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
            /// 'westcentralus', 'westus2', 'eastus', 'southcentralus', 'northeurope',
            /// 'eastasia', 'australiaeast', 'brazilsouth', 'virginia'
            /// </param>
            /// <param name='azureCloud'>
            /// Supported Azure Clouds for Cognitive Services endpoints. Possible values
            /// include: 'com', 'us'
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='exampleId'>
            /// The example ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> DeleteAsync(this IExamples operations, AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, int exampleId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(azureRegion, azureCloud, appId, versionId, exampleId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
