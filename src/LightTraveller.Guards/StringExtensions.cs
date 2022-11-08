namespace LightTraveller.Guards;

internal static class StringExtensions
{
    public static bool Empty(this string? str) => string.IsNullOrWhiteSpace(str);
    public static bool NotEmpty(this string? str) => !string.IsNullOrWhiteSpace(str);
}




