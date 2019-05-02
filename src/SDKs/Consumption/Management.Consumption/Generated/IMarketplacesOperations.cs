// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// MarketplacesOperations operations.
    /// </summary>
    public partial interface IMarketplacesOperations
    {
        /// <summary>
        /// Lists the marketplaces for a scope at the defined scope.
        /// Marketplaces are available via this API only for May 1, 2014 or
        /// later.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
        /// </summary>
        /// <param name='scope'>
        /// The scope associated with marketplace operations. This includes
        /// '/subscriptions/{subscriptionId}/' for subscription scope,
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}'
        /// for resourceGroup scope,
        /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}'
        /// for Billing Account scope,
        /// '/providers/Microsoft.Billing/departments/{departmentId}' for
        /// Department scope,
        /// '/providers/Microsoft.Billing/enrollmentAccounts/{enrollmentAccountId}'
        /// for EnrollmentAccount scope and
        /// '/providers/Microsoft.Management/managementGroups/{managementGroupId}'
        /// for Management Group scope. For subscription, billing account,
        /// department, enrollment account and ManagementGroup, you can also
        /// add billing period to the scope using
        /// '/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'.
        /// For e.g. to specify billing period at department scope use
        /// '/providers/Microsoft.Billing/departments/{departmentId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='skiptoken'>
        /// Skiptoken is only used if a previous operation returned a partial
        /// result. If a previous response contains a nextLink element, the
        /// value of the nextLink element will include a skiptoken parameter
        /// that specifies a starting point to use for subsequent calls.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Marketplace>>> ListWithHttpMessagesAsync(string scope, ODataQuery<Marketplace> odataQuery = default(ODataQuery<Marketplace>), string skiptoken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the marketplaces for a scope at the defined scope.
        /// Marketplaces are available via this API only for May 1, 2014 or
        /// later.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Marketplace>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
