// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RecoveryServices;
using Microsoft.Azure.Management.RecoveryServices.Models;

namespace Microsoft.Azure.Management.RecoveryServices
{
    public static partial class VaultUsageOperationsExtensions
    {
        /// <summary>
        /// Get the Vault Usage.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.IVaultUsageOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the (resource group?) cloud service
        /// containing the vault collection.
        /// </param>
        /// <param name='vaultName'>
        /// Required. The name of the vault to get usage.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for Vault usage.
        /// </returns>
        public static VaultUsageListResponse List(this IVaultUsageOperations operations, string resourceGroupName, string vaultName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVaultUsageOperations)s).ListAsync(resourceGroupName, vaultName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the Vault Usage.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.IVaultUsageOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the (resource group?) cloud service
        /// containing the vault collection.
        /// </param>
        /// <param name='vaultName'>
        /// Required. The name of the vault to get usage.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for Vault usage.
        /// </returns>
        public static Task<VaultUsageListResponse> ListAsync(this IVaultUsageOperations operations, string resourceGroupName, string vaultName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(resourceGroupName, vaultName, customRequestHeaders, CancellationToken.None);
        }
    }
}