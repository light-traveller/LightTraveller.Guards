using System.Diagnostics.CodeAnalysis;

namespace LightTraveller.Guards;

internal static class StringExtensions
{
    public static bool Empty([NotNullWhen(false)] this string? str) => string.IsNullOrWhiteSpace(str);

    public static bool NotEmpty([NotNullWhen(true)] this string? str) => !string.IsNullOrWhiteSpace(str);

    public static string IfEmptyThen(this string? str, string replacement)
    {
        return str.Empty() ? replacement : str;
    }
}