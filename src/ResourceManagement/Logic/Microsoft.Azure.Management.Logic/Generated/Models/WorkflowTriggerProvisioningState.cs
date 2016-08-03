// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WorkflowTriggerProvisioningState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowTriggerProvisioningState
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "Accepted")]
        Accepted,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Ready")]
        Ready,
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Created")]
        Created,
        [EnumMember(Value = "Deleting")]
        Deleting,
        [EnumMember(Value = "Deleted")]
        Deleted,
        [EnumMember(Value = "Canceled")]
        Canceled,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Moving")]
        Moving,
        [EnumMember(Value = "Updating")]
        Updating,
        [EnumMember(Value = "Registering")]
        Registering,
        [EnumMember(Value = "Registered")]
        Registered,
        [EnumMember(Value = "Unregistering")]
        Unregistering,
        [EnumMember(Value = "Unregistered")]
        Unregistered,
        [EnumMember(Value = "Completed")]
        Completed
    }
}
