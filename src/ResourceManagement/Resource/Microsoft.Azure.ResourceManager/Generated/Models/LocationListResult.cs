// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Location list operation response.
    /// </summary>
    public partial class LocationListResult
    {
        /// <summary>
        /// Initializes a new instance of the LocationListResult class.
        /// </summary>
        public LocationListResult() { }

        /// <summary>
        /// Initializes a new instance of the LocationListResult class.
        /// </summary>
        public LocationListResult(IList<Location> value = default(IList<Location>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets the locations.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Location> Value { get; set; }

    }
}