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
    /// Tag information.
    /// </summary>
    public partial class TagValue
    {
        /// <summary>
        /// Initializes a new instance of the TagValue class.
        /// </summary>
        public TagValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagValue class.
        /// </summary>
        /// <param name="id">The tag ID.</param>
        /// <param name="tagValueProperty">The tag value.</param>
        /// <param name="count">The tag value count.</param>
        public TagValue(string id = default(string), string tagValueProperty = default(string), TagCount count = default(TagCount))
        {
            Id = id;
            TagValueProperty = tagValueProperty;
            Count = count;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the tag ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the tag value.
        /// </summary>
        [JsonProperty(PropertyName = "tagValue")]
        public string TagValueProperty { get; set; }

        /// <summary>
        /// Gets or sets the tag value count.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public TagCount Count { get; set; }

    }
}
