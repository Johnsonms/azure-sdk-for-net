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
    /// The Data Lake Analytics job error details.
    /// </summary>
    public partial class JobErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the JobErrorDetails class.
        /// </summary>
        public JobErrorDetails() { }

        /// <summary>
        /// Initializes a new instance of the JobErrorDetails class.
        /// </summary>
        /// <param name="description">the error message description</param>
        /// <param name="details">the details of the error message.</param>
        /// <param name="endOffset">the end offset in the job where the error
        /// was found.</param>
        /// <param name="errorId">the specific identifier for the type of
        /// error encountered in the job.</param>
        /// <param name="filePath">the path to any supplemental error files,
        /// if any.</param>
        /// <param name="helpLink">the link to MSDN or Azure help for this
        /// type of error, if any.</param>
        /// <param name="internalDiagnostics">the internal diagnostic stack
        /// trace if the user requesting the job error details has sufficient
        /// permissions it will be retrieved, otherwise it will be
        /// empty.</param>
        /// <param name="lineNumber">the specific line number in the job where
        /// the error occured.</param>
        /// <param name="message">the user friendly error message for the
        /// failure.</param>
        /// <param name="resolution">the recommended resolution for the
        /// failure, if any.</param>
        /// <param name="innerError">the inner error of this specific job
        /// error message, if any.</param>
        /// <param name="severity">the severity level of the failure. Possible
        /// values include: 'Warning', 'Error', 'Info'</param>
        /// <param name="source">the ultimate source of the failure (usually
        /// either SYSTEM or USER).</param>
        /// <param name="startOffset">the start offset in the job where the
        /// error was found</param>
        public JobErrorDetails(string description = default(string), string details = default(string), int? endOffset = default(int?), string errorId = default(string), string filePath = default(string), string helpLink = default(string), string internalDiagnostics = default(string), int? lineNumber = default(int?), string message = default(string), string resolution = default(string), JobInnerError innerError = default(JobInnerError), SeverityTypes? severity = default(SeverityTypes?), string source = default(string), int? startOffset = default(int?))
        {
            Description = description;
            Details = details;
            EndOffset = endOffset;
            ErrorId = errorId;
            FilePath = filePath;
            HelpLink = helpLink;
            InternalDiagnostics = internalDiagnostics;
            LineNumber = lineNumber;
            Message = message;
            Resolution = resolution;
            InnerError = innerError;
            Severity = severity;
            Source = source;
            StartOffset = startOffset;
        }

        /// <summary>
        /// Gets the error message description
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the details of the error message.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "details")]
        public string Details { get; private set; }

        /// <summary>
        /// Gets the end offset in the job where the error was found.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endOffset")]
        public int? EndOffset { get; private set; }

        /// <summary>
        /// Gets the specific identifier for the type of error encountered in
        /// the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "errorId")]
        public string ErrorId { get; private set; }

        /// <summary>
        /// Gets the path to any supplemental error files, if any.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; private set; }

        /// <summary>
        /// Gets the link to MSDN or Azure help for this type of error, if any.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "helpLink")]
        public string HelpLink { get; private set; }

        /// <summary>
        /// Gets the internal diagnostic stack trace if the user requesting
        /// the job error details has sufficient permissions it will be
        /// retrieved, otherwise it will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "internalDiagnostics")]
        public string InternalDiagnostics { get; private set; }

        /// <summary>
        /// Gets the specific line number in the job where the error occured.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lineNumber")]
        public int? LineNumber { get; private set; }

        /// <summary>
        /// Gets the user friendly error message for the failure.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the recommended resolution for the failure, if any.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resolution")]
        public string Resolution { get; private set; }

        /// <summary>
        /// Gets the inner error of this specific job error message, if any.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "innerError")]
        public JobInnerError InnerError { get; private set; }

        /// <summary>
        /// Gets the severity level of the failure. Possible values include:
        /// 'Warning', 'Error', 'Info'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "severity")]
        public SeverityTypes? Severity { get; private set; }

        /// <summary>
        /// Gets the ultimate source of the failure (usually either SYSTEM or
        /// USER).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "source")]
        public string Source { get; private set; }

        /// <summary>
        /// Gets the start offset in the job where the error was found
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startOffset")]
        public int? StartOffset { get; private set; }

    }
}
