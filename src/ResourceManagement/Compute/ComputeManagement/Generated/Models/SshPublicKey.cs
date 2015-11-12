// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Contains information about SSH certificate public key and the path on
    /// the Linux VM where the public key is placed.
    /// </summary>
    public partial class SshPublicKey
    {
        /// <summary>
        /// Initializes a new instance of the SshPublicKey class.
        /// </summary>
        public SshPublicKey() { }

        /// <summary>
        /// Initializes a new instance of the SshPublicKey class.
        /// </summary>
        public SshPublicKey(string path = default(string), string keyData = default(string))
        {
            Path = path;
            KeyData = keyData;
        }

        /// <summary>
        /// Gets or sets the full path on the created VM where SSH public key
        /// is stored. If the file already exists, the specified key is
        /// appended to the file.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets Certificate public key used to authenticate with VM
        /// through SSH.The certificate must be in Pem format with or without
        /// headers.
        /// </summary>
        [JsonProperty(PropertyName = "keyData")]
        public string KeyData { get; set; }

    }
}
