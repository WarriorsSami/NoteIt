using System.ComponentModel;
using System.Linq;

namespace Core
{
    public static class FileHandler
    {
        public static string FormatUsingObject(this string @this, object poObject)
        {
            return TypeDescriptor
                .GetProperties(poObject)
                .Cast<PropertyDescriptor>()
                .Aggregate(
                    @this,
                    (current, oProperty) =>
                        current.Replace(
                            "{" + oProperty.Name + "}",
                            oProperty.GetValue(poObject).ToStringOrNull()
                        )
                );
        }

        private static string ToStringOrNull(this object @this)
        {
            return @this?.ToString();
        }

        public static bool IsEmpty(this string @this)
        {
            return string.IsNullOrWhiteSpace(@this);
        }
    }
}