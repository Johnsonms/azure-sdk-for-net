// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System.Linq;

    /// <summary>
    /// Data Lake Analytics catalog credential update parameters.
    /// </summary>
    public partial class DataLakeAnalyticsCatalogCredentialUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogCredentialUpdateParameters class.
        /// </summary>
        public DataLakeAnalyticsCatalogCredentialUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogCredentialUpdateParameters class.
        /// </summary>
        /// <param name="password">the current password for the credential and
        /// user with access to the data source. This is required if the
        /// requester is not the account owner.</param>
        /// <param name="newPassword">the new password for the credential and
        /// user with access to the data source.</param>
        /// <param name="uri">the URI identifier for the data source this
        /// credential can connect to in the format <hostname>:<port></param>
        /// <param name="userId">the object identifier for the user associated
        /// with this credential with access to the data source.</param>
        public DataLakeAnalyticsCatalogCredentialUpdateParameters(string password = default(string), string newPassword = default(string), string uri = default(string), string userId = default(string))
        {
            Password = password;
            NewPassword = newPassword;
            Uri = uri;
            UserId = userId;
        }

        /// <summary>
        /// Gets or sets the current password for the credential and user with
        /// access to the data source. This is required if the requester is
        /// not the account owner.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the new password for the credential and user with
        /// access to the data source.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "newPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or sets the URI identifier for the data source this
        /// credential can connect to in the format
        /// &lt;hostname&gt;:&lt;port&gt;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the object identifier for the user associated with
        /// this credential with access to the data source.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

    }
}
