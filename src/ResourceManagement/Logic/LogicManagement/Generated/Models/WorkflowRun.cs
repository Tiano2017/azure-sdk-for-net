// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
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
    public partial class WorkflowRun : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowRun class.
        /// </summary>
        public WorkflowRun() { }

        /// <summary>
        /// Initializes a new instance of the WorkflowRun class.
        /// </summary>
        public WorkflowRun(string id = default(string), string name = default(string), string type = default(string), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), WorkflowStatus? status = default(WorkflowStatus?), string code = default(string), object error = default(object), string correlationId = default(string), ResourceReference workflow = default(ResourceReference), WorkflowRunTrigger trigger = default(WorkflowRunTrigger), IDictionary<string, WorkflowOutputParameter> outputs = default(IDictionary<string, WorkflowOutputParameter>))
            : base(id)
        {
            Name = name;
            Type = type;
            StartTime = startTime;
            EndTime = endTime;
            Status = status;
            Code = code;
            Error = error;
            CorrelationId = correlationId;
            Workflow = workflow;
            Trigger = trigger;
            Outputs = outputs;
        }

        /// <summary>
        /// Gets the workflow run name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the workflow run type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the start time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the end time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets the status. Possible values include: 'NotSpecified',
        /// 'Paused', 'Running', 'Waiting', 'Succeeded', 'Skipped',
        /// 'Suspended', 'Cancelled', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public WorkflowStatus? Status { get; private set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        [JsonProperty(PropertyName = "properties.code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the error.
        /// </summary>
        [JsonProperty(PropertyName = "properties.error")]
        public object Error { get; private set; }

        /// <summary>
        /// Gets the correlation id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.correlationId")]
        public string CorrelationId { get; private set; }

        /// <summary>
        /// Gets the reference to workflow version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.workflow")]
        public ResourceReference Workflow { get; private set; }

        /// <summary>
        /// Gets the fired trigger.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trigger")]
        public WorkflowRunTrigger Trigger { get; private set; }

        /// <summary>
        /// Gets the outputs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputs")]
        public IDictionary<string, WorkflowOutputParameter> Outputs { get; private set; }

    }
}