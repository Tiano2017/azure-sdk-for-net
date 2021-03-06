// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QueueServicesOperations.
    /// </summary>
    public static partial class QueueServicesOperationsExtensions
    {
            /// <summary>
            /// Returns the queue service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            public static QueueService Get(this IQueueServicesOperations operations, string resourceGroupName, string farmId)
            {
                return operations.GetAsync(resourceGroupName, farmId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the queue service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QueueService> GetAsync(this IQueueServicesOperations operations, string resourceGroupName, string farmId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, farmId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of metric definitions for queue service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            public static IPage<MetricDefinition> ListMetricDefinitions(this IQueueServicesOperations operations, string resourceGroupName, string farmId)
            {
                return operations.ListMetricDefinitionsAsync(resourceGroupName, farmId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of metric definitions for queue service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<MetricDefinition>> ListMetricDefinitionsAsync(this IQueueServicesOperations operations, string resourceGroupName, string farmId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricDefinitionsWithHttpMessagesAsync(resourceGroupName, farmId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of metrics for the queue service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            public static IPage<Metric> ListMetrics(this IQueueServicesOperations operations, string resourceGroupName, string farmId)
            {
                return operations.ListMetricsAsync(resourceGroupName, farmId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of metrics for the queue service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Metric>> ListMetricsAsync(this IQueueServicesOperations operations, string resourceGroupName, string farmId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricsWithHttpMessagesAsync(resourceGroupName, farmId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of metric definitions for queue service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<MetricDefinition> ListMetricDefinitionsNext(this IQueueServicesOperations operations, string nextPageLink)
            {
                return operations.ListMetricDefinitionsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of metric definitions for queue service.
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
            public static async Task<IPage<MetricDefinition>> ListMetricDefinitionsNextAsync(this IQueueServicesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricDefinitionsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of metrics for the queue service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Metric> ListMetricsNext(this IQueueServicesOperations operations, string nextPageLink)
            {
                return operations.ListMetricsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of metrics for the queue service.
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
            public static async Task<IPage<Metric>> ListMetricsNextAsync(this IQueueServicesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
