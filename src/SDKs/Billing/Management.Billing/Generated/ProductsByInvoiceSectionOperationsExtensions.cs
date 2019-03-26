// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProductsByInvoiceSectionOperations.
    /// </summary>
    public static partial class ProductsByInvoiceSectionOperationsExtensions
    {
            /// <summary>
            /// Lists products by invoiceSectionName.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='filter'>
            /// May be used to filter by product type. The filter supports 'eq', 'lt',
            /// 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or
            /// 'not'. Tag filter is a key value pair string where key and value is
            /// separated by a colon (:).
            /// </param>
            public static ProductsListResult List(this IProductsByInvoiceSectionOperations operations, string billingAccountName, string invoiceSectionName, string filter = default(string))
            {
                return operations.ListAsync(billingAccountName, invoiceSectionName, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists products by invoiceSectionName.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='filter'>
            /// May be used to filter by product type. The filter supports 'eq', 'lt',
            /// 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or
            /// 'not'. Tag filter is a key value pair string where key and value is
            /// separated by a colon (:).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProductsListResult> ListAsync(this IProductsByInvoiceSectionOperations operations, string billingAccountName, string invoiceSectionName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(billingAccountName, invoiceSectionName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
