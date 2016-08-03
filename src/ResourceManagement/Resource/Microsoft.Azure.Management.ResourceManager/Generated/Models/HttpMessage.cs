// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class HttpMessage
    {
        /// <summary>
        /// Initializes a new instance of the HttpMessage class.
        /// </summary>
        public HttpMessage() { }

        /// <summary>
        /// Initializes a new instance of the HttpMessage class.
        /// </summary>
        public HttpMessage(object content = default(object))
        {
            Content = content;
        }

        /// <summary>
        /// HTTP message content.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public object Content { get; set; }

    }
}
