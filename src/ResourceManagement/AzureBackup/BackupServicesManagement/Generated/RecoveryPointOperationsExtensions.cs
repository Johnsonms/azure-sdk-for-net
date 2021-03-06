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
using Microsoft.Azure.Management.BackupServices;
using Microsoft.Azure.Management.BackupServices.Models;

namespace Microsoft.Azure.Management.BackupServices
{
    public static partial class RecoveryPointOperationsExtensions
    {
        /// <summary>
        /// Get the recovery point.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IRecoveryPointOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// Optional.
        /// </param>
        /// <param name='itemName'>
        /// Optional.
        /// </param>
        /// <param name='recoveryPointName'>
        /// Optional.
        /// </param>
        /// <returns>
        /// The definition of a CSMRecoveryPointGetOperationResponse.
        /// </returns>
        public static CSMRecoveryPointGetOperationResponse Get(this IRecoveryPointOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string containerName, string itemName, string recoveryPointName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRecoveryPointOperations)s).GetAsync(resourceGroupName, resourceName, customRequestHeaders, containerName, itemName, recoveryPointName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the recovery point.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IRecoveryPointOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// Optional.
        /// </param>
        /// <param name='itemName'>
        /// Optional.
        /// </param>
        /// <param name='recoveryPointName'>
        /// Optional.
        /// </param>
        /// <returns>
        /// The definition of a CSMRecoveryPointGetOperationResponse.
        /// </returns>
        public static Task<CSMRecoveryPointGetOperationResponse> GetAsync(this IRecoveryPointOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string containerName, string itemName, string recoveryPointName)
        {
            return operations.GetAsync(resourceGroupName, resourceName, customRequestHeaders, containerName, itemName, recoveryPointName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of all recovery points.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IRecoveryPointOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// Optional.
        /// </param>
        /// <param name='itemName'>
        /// Optional.
        /// </param>
        /// <returns>
        /// The definition of a CSMRecoveryPointListOperationResponse.
        /// </returns>
        public static CSMRecoveryPointListOperationResponse List(this IRecoveryPointOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string containerName, string itemName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRecoveryPointOperations)s).ListAsync(resourceGroupName, resourceName, customRequestHeaders, containerName, itemName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of all recovery points.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IRecoveryPointOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// Optional.
        /// </param>
        /// <param name='itemName'>
        /// Optional.
        /// </param>
        /// <returns>
        /// The definition of a CSMRecoveryPointListOperationResponse.
        /// </returns>
        public static Task<CSMRecoveryPointListOperationResponse> ListAsync(this IRecoveryPointOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string containerName, string itemName)
        {
            return operations.ListAsync(resourceGroupName, resourceName, customRequestHeaders, containerName, itemName, CancellationToken.None);
        }
    }
}
