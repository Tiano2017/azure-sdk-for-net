// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains information about a Cluster.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Cluster : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        public Cluster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        /// <param name="id">The ID of the resource</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource</param>
        /// <param name="location">The location of the resource</param>
        /// <param name="tags">The tags of the resource</param>
        /// <param name="vmSize">The size of the virtual machines in the
        /// cluster.</param>
        /// <param name="vmPriority">dedicated or lowpriority.</param>
        /// <param name="scaleSettings">Desired scale for the Cluster.</param>
        /// <param name="virtualMachineConfiguration">Settings for OS image and
        /// mounted data volumes.</param>
        /// <param name="nodeSetup">Setup to be done on all compute nodes in
        /// the Cluster.</param>
        /// <param name="userAccountSettings">Settings for user account of
        /// compute nodes.</param>
        /// <param name="subnet">Specifies the identifier of the
        /// subnet.</param>
        /// <param name="creationTime">The creation time of the
        /// cluster.</param>
        /// <param name="provisioningState">Specifies the provisioning state of
        /// the cluster.</param>
        /// <param name="provisioningStateTransitionTime">The provisioning
        /// state transition time of the cluster.</param>
        /// <param name="allocationState">Indicates whether the cluster is
        /// resizing.</param>
        /// <param name="allocationStateTransitionTime">The time at which the
        /// cluster entered its current allocation state.</param>
        /// <param name="errors">Contains details of various errors on the
        /// cluster including resize and node setup task</param>
        /// <param name="currentNodeCount">The number of compute nodes
        /// currently assigned to the cluster.</param>
        /// <param name="nodeStateCounts">Counts of various node states on the
        /// cluster.</param>
        public Cluster(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string vmSize = default(string), VmPriority? vmPriority = default(VmPriority?), ScaleSettings scaleSettings = default(ScaleSettings), VirtualMachineConfiguration virtualMachineConfiguration = default(VirtualMachineConfiguration), NodeSetup nodeSetup = default(NodeSetup), UserAccountSettings userAccountSettings = default(UserAccountSettings), ResourceId subnet = default(ResourceId), System.DateTime? creationTime = default(System.DateTime?), ProvisioningState provisioningState = default(ProvisioningState), System.DateTime? provisioningStateTransitionTime = default(System.DateTime?), AllocationState? allocationState = default(AllocationState?), System.DateTime? allocationStateTransitionTime = default(System.DateTime?), IList<BatchAIError> errors = default(IList<BatchAIError>), int? currentNodeCount = default(int?), NodeStateCounts nodeStateCounts = default(NodeStateCounts))
            : base(id, name, type, location, tags)
        {
            VmSize = vmSize;
            VmPriority = vmPriority;
            ScaleSettings = scaleSettings;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            NodeSetup = nodeSetup;
            UserAccountSettings = userAccountSettings;
            Subnet = subnet;
            CreationTime = creationTime;
            ProvisioningState = provisioningState;
            ProvisioningStateTransitionTime = provisioningStateTransitionTime;
            AllocationState = allocationState;
            AllocationStateTransitionTime = allocationStateTransitionTime;
            Errors = errors;
            CurrentNodeCount = currentNodeCount;
            NodeStateCounts = nodeStateCounts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the size of the virtual machines in the cluster.
        /// </summary>
        /// <remarks>
        /// All virtual machines in a cluster are the same size. For
        /// information about available VM sizes for clusters using images from
        /// the Virtual Machines Marketplace (see Sizes for Virtual Machines
        /// (Linux) or Sizes for Virtual Machines (Windows). Batch AI service
        /// supports all Azure VM sizes except STANDARD_A0 and those with
        /// premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2
        /// series).
        /// </remarks>
        [JsonProperty(PropertyName = "properties.vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets dedicated or lowpriority.
        /// </summary>
        /// <remarks>
        /// The default value is dedicated. The node can get preempted while
        /// the task is running if lowpriority is choosen. This is best suited
        /// if the workload is checkpointing and can be restarted. Possible
        /// values include: 'dedicated', 'lowpriority'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.vmPriority")]
        public VmPriority? VmPriority { get; set; }

        /// <summary>
        /// Gets or sets desired scale for the Cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleSettings")]
        public ScaleSettings ScaleSettings { get; set; }

        /// <summary>
        /// Gets or sets settings for OS image and mounted data volumes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachineConfiguration")]
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; set; }

        /// <summary>
        /// Gets or sets setup to be done on all compute nodes in the Cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeSetup")]
        public NodeSetup NodeSetup { get; set; }

        /// <summary>
        /// Gets or sets settings for user account of compute nodes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userAccountSettings")]
        public UserAccountSettings UserAccountSettings { get; set; }

        /// <summary>
        /// Gets or sets specifies the identifier of the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public ResourceId Subnet { get; set; }

        /// <summary>
        /// Gets the creation time of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets specifies the provisioning state of the cluster.
        /// </summary>
        /// <remarks>
        /// Possible value are: creating - Specifies that the cluster is being
        /// created. succeeded - Specifies that the cluster has been created
        /// successfully. failed - Specifies that the cluster creation has
        /// failed. deleting - Specifies that the cluster is being deleted.
        /// Possible values include: 'creating', 'succeeded', 'failed',
        /// 'deleting'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the provisioning state transition time of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningStateTransitionTime")]
        public System.DateTime? ProvisioningStateTransitionTime { get; private set; }

        /// <summary>
        /// Gets indicates whether the cluster is resizing.
        /// </summary>
        /// <remarks>
        /// Possible values are: steady and resizing. steady state indicates
        /// that the cluster is not resizing. There are no changes to the
        /// number of compute nodes in the cluster in progress. A cluster
        /// enters this state when it is created and when no operations are
        /// being performed on the cluster to change the number of compute
        /// nodes. resizing state indicates that the cluster is resizing; that
        /// is, compute nodes are being added to or removed from the cluster.
        /// Possible values include: 'steady', 'resizing'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.allocationState")]
        public AllocationState? AllocationState { get; private set; }

        /// <summary>
        /// Gets the time at which the cluster entered its current allocation
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allocationStateTransitionTime")]
        public System.DateTime? AllocationStateTransitionTime { get; private set; }

        /// <summary>
        /// Gets or sets contains details of various errors on the cluster
        /// including resize and node setup task
        /// </summary>
        /// <remarks>
        /// This element contains all the errors encountered by various compute
        /// nodes during node setup.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.errors")]
        public IList<BatchAIError> Errors { get; set; }

        /// <summary>
        /// Gets the number of compute nodes currently assigned to the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentNodeCount")]
        public int? CurrentNodeCount { get; private set; }

        /// <summary>
        /// Gets counts of various node states on the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeStateCounts")]
        public NodeStateCounts NodeStateCounts { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ScaleSettings != null)
            {
                ScaleSettings.Validate();
            }
            if (VirtualMachineConfiguration != null)
            {
                VirtualMachineConfiguration.Validate();
            }
            if (NodeSetup != null)
            {
                NodeSetup.Validate();
            }
            if (UserAccountSettings != null)
            {
                UserAccountSettings.Validate();
            }
            if (Subnet != null)
            {
                Subnet.Validate();
            }
            if (NodeStateCounts != null)
            {
                NodeStateCounts.Validate();
            }
        }
    }
}
