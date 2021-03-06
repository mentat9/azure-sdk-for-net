// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JitNetworkAccessPoliciesOperations.
    /// </summary>
    public static partial class JitNetworkAccessPoliciesOperationsExtensions
    {
            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> List(this IJitNetworkAccessPoliciesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListAsync(this IJitNetworkAccessPoliciesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListByRegion(this IJitNetworkAccessPoliciesOperations operations)
            {
                return operations.ListByRegionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListByRegionAsync(this IJitNetworkAccessPoliciesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByRegionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListByResourceGroup(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListByResourceGroupAsync(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListByResourceGroupAndRegion(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAndRegionAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListByResourceGroupAndRegionAsync(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupAndRegionWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            public static JitNetworkAccessPolicy Get(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string jitNetworkAccessPolicyName)
            {
                return operations.GetAsync(resourceGroupName, jitNetworkAccessPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JitNetworkAccessPolicy> GetAsync(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string jitNetworkAccessPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, jitNetworkAccessPolicyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a policy for protecting resources using Just-in-Time access control
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static JitNetworkAccessPolicy CreateOrUpdate(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string jitNetworkAccessPolicyName, JitNetworkAccessPolicy body)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, jitNetworkAccessPolicyName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a policy for protecting resources using Just-in-Time access control
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JitNetworkAccessPolicy> CreateOrUpdateAsync(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string jitNetworkAccessPolicyName, JitNetworkAccessPolicy body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, jitNetworkAccessPolicyName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Just-in-Time access control policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            public static void Delete(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string jitNetworkAccessPolicyName)
            {
                operations.DeleteAsync(resourceGroupName, jitNetworkAccessPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Just-in-Time access control policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string jitNetworkAccessPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, jitNetworkAccessPolicyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Initiate a JIT access from a specific Just-in-Time policy configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            /// <param name='virtualMachines'>
            /// A list of virtual machines &amp; ports to open access for
            /// </param>
            public static JitNetworkAccessRequest Initiate(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string jitNetworkAccessPolicyName, IList<JitNetworkAccessPolicyInitiateVirtualMachine> virtualMachines)
            {
                return operations.InitiateAsync(resourceGroupName, jitNetworkAccessPolicyName, virtualMachines).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Initiate a JIT access from a specific Just-in-Time policy configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            /// <param name='virtualMachines'>
            /// A list of virtual machines &amp; ports to open access for
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JitNetworkAccessRequest> InitiateAsync(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string jitNetworkAccessPolicyName, IList<JitNetworkAccessPolicyInitiateVirtualMachine> virtualMachines, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.InitiateWithHttpMessagesAsync(resourceGroupName, jitNetworkAccessPolicyName, virtualMachines, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListNext(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListNextAsync(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListByRegionNext(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListByRegionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListByRegionNextAsync(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByRegionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListByResourceGroupNext(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListByResourceGroupNextAsync(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListByResourceGroupAndRegionNext(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupAndRegionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListByResourceGroupAndRegionNextAsync(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupAndRegionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
