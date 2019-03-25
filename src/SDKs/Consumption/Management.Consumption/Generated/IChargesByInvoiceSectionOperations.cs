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
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ChargesByInvoiceSectionOperations operations.
    /// </summary>
    public partial interface IChargesByInvoiceSectionOperations
    {
        /// <summary>
        /// Lists the charges by invoice section id for given start and end
        /// date. Start and end date are used to determine the billing period.
        /// For current month, the data will be provided from month to date. If
        /// there are no chages for a month then that month will show all
        /// zeroes.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
        /// </summary>
        /// <param name='billingAccountId'>
        /// BillingAccount ID
        /// </param>
        /// <param name='invoiceSectionId'>
        /// Invoice Section Id.
        /// </param>
        /// <param name='startDate'>
        /// Start date
        /// </param>
        /// <param name='endDate'>
        /// End date
        /// </param>
        /// <param name='apply'>
        /// May be used to group charges by properties/productName.
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
        Task<AzureOperationResponse<ChargesListByInvoiceSection>> ListWithHttpMessagesAsync(string billingAccountId, string invoiceSectionId, string startDate, string endDate, string apply = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
