// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Filter.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Filter
    {
        [EnumMember(Value = "atScope()")]
        AtScope
    }
    internal static class FilterEnumExtension
    {
        internal static string ToSerializedValue(this Filter? value)
        {
            return value == null ? null : ((Filter)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this Filter value)
        {
            switch( value )
            {
                case Filter.AtScope:
                    return "atScope()";
            }
            return null;
        }

        internal static Filter? ParseFilter(this string value)
        {
            switch( value )
            {
                case "atScope()":
                    return Filter.AtScope;
            }
            return null;
        }
    }
}
