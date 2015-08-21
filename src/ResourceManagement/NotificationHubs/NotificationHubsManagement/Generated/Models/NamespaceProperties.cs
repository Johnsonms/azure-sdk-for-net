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
using Microsoft.Azure.Management.NotificationHubs.Models;

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    /// <summary>
    /// Namespace properties.
    /// </summary>
    public partial class NamespaceProperties
    {
        private DateTime _createdAt;
        
        /// <summary>
        /// Optional. The time the namespace was created.
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }
        
        private bool _critical;
        
        /// <summary>
        /// Optional. Whether or not the namespace is set as Critical.
        /// </summary>
        public bool Critical
        {
            get { return this._critical; }
            set { this._critical = value; }
        }
        
        private bool _enabled;
        
        /// <summary>
        /// Optional. Whether or not the namespace is currently enabled.
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The name of the namespace.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private NamespaceType _namespaceType;
        
        /// <summary>
        /// Optional. Gets or sets the namespace type.
        /// </summary>
        public NamespaceType NamespaceType
        {
            get { return this._namespaceType; }
            set { this._namespaceType = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets provisioning state of the Namespace.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private string _region;
        
        /// <summary>
        /// Optional. Specifies the targeted region in which the namespace
        /// should be created. It can be any of the following values:
        /// Australia EastAustralia SoutheastCentral USEast USEast US 2West
        /// USNorth Central USSouth Central USEast AsiaSoutheast AsiaBrazil
        /// SouthJapan EastJapan WestNorth EuropeWest Europe  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj873988.aspx
        /// for more information)
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }
        
        private string _scaleUnit;
        
        /// <summary>
        /// Optional. ScaleUnit where the namespace gets created
        /// </summary>
        public string ScaleUnit
        {
            get { return this._scaleUnit; }
            set { this._scaleUnit = value; }
        }
        
        private Uri _serviceBusEndpoint;
        
        /// <summary>
        /// Optional. Endpoint you can use to perform NotificationHub
        /// operations.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj873988.aspx
        /// for more information)
        /// </summary>
        public Uri ServiceBusEndpoint
        {
            get { return this._serviceBusEndpoint; }
            set { this._serviceBusEndpoint = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Status of the namespace. It can be any of these values:1
        /// = Created/Active2 = Creating3 = Suspended4 = Deleting  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj873988.aspx
        /// for more information)
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _subscriptionId;
        
        /// <summary>
        /// Optional. The Id of the Azure subscription associated with the
        /// namespace.
        /// </summary>
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the NamespaceProperties class.
        /// </summary>
        public NamespaceProperties()
        {
        }
    }
}
