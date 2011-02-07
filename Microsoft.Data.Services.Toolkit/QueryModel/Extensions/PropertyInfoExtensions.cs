namespace Microsoft.Data.Services.Toolkit.QueryModel
{
    using System.Reflection;

    /// <summary>
    /// Extension methods for the <see cref="PropertyInfo"/> class.
    /// </summary>
    internal static class PropertyInfoExtensions
    {
        internal static string GetUnderlyingColumnName(this PropertyInfo property)
        {
            var attributes = property.GetCustomAttributes(typeof(SourcePropertyNameAttribute), true);

            if (attributes == null || attributes.Length == 0)
                return property.Name;

            return ((SourcePropertyNameAttribute)attributes[0]).UnderlyingName;
        }
    }
}