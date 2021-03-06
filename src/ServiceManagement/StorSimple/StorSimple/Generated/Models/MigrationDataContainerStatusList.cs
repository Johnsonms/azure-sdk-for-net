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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// The response body for get data container migration status.
    /// </summary>
    public partial class MigrationDataContainerStatusList : AzureOperationResponse
    {
        private IList<MigrationDataContainerStatus> _migrationDataContainerStatuses;
        
        /// <summary>
        /// Optional. Gets or sets list of migration data container status.
        /// </summary>
        public IList<MigrationDataContainerStatus> MigrationDataContainerStatuses
        {
            get { return this._migrationDataContainerStatuses; }
            set { this._migrationDataContainerStatuses = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MigrationDataContainerStatusList
        /// class.
        /// </summary>
        public MigrationDataContainerStatusList()
        {
            this.MigrationDataContainerStatuses = new LazyList<MigrationDataContainerStatus>();
        }
    }
}
