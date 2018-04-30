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
    /// Resource type managed by the resource provider.
    /// </summary>
    public partial class ProviderResourceType
    {
        /// <summary>
        /// Initializes a new instance of the ProviderResourceType class.
        /// </summary>
        public ProviderResourceType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProviderResourceType class.
        /// </summary>
        /// <param name="resourceType">The resource type.</param>
        /// <param name="locations">The collection of locations where this
        /// resource type can be created.</param>
        /// <param name="aliases">The aliases that are supported by this
        /// resource type.</param>
        /// <param name="apiVersions">The API version.</param>
        /// <param name="properties">The properties.</param>
        public ProviderResourceType(string resourceType = default(string), IList<string> locations = default(IList<string>), IList<AliasType> aliases = default(IList<AliasType>), IList<string> apiVersions = default(IList<string>), IDictionary<string, string> properties = default(IDictionary<string, string>))
        {
            ResourceType = resourceType;
            Locations = locations;
            Aliases = aliases;
            ApiVersions = apiVersions;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the collection of locations where this resource type
        /// can be created.
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<string> Locations { get; set; }

        /// <summary>
        /// Gets or sets the aliases that are supported by this resource type.
        /// </summary>
        [JsonProperty(PropertyName = "aliases")]
        public IList<AliasType> Aliases { get; set; }

        /// <summary>
        /// Gets or sets the API version.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersions")]
        public IList<string> ApiVersions { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

    }
}
