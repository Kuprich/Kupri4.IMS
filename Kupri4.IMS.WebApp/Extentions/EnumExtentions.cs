using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Kupri4.IMS.WebApp.Extentions;

public static class EnumExtentions
{
    public static string? GetDisplayName(this Enum enumValue) =>
        enumValue.GetType()
        .GetMember(enumValue.ToString())
        .First()
        .GetCustomAttribute<DisplayAttribute>()
        ?.GetName();
}
