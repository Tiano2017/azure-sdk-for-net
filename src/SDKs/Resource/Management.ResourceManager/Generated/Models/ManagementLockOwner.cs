// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Lock owner properties.
    /// </summary>
    public partial class ManagementLockOwner
    {
        /// <summary>
        /// Initializes a new instance of the ManagementLockOwner class.
        /// </summary>
        public ManagementLockOwner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementLockOwner class.
        /// </summary>
        /// <param name="applicationId">The application ID of the lock
        /// owner.</param>
        public ManagementLockOwner(string applicationId = default(string))
        {
            ApplicationId = applicationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the application ID of the lock owner.
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }

    }
}
