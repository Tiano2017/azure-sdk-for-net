// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of resource groups.
    /// </summary>
    public partial class ResourceListResult
    {
        /// <summary>
        /// Initializes a new instance of the ResourceListResult class.
        /// </summary>
        public ResourceListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceListResult class.
        /// </summary>
        /// <param name="value">An array of resources.</param>
        /// <param name="nextLink">The URL to use for getting the next set of
        /// results.</param>
        public ResourceListResult(IList<GenericResource> value = default(IList<GenericResource>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an array of resources.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<GenericResource> Value { get; set; }

        /// <summary>
        /// Gets the URL to use for getting the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
