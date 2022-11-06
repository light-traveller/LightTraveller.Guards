using System.Diagnostics.CodeAnalysis;

namespace LightTraveller.Guards;

internal static class ArgumentExceptionHelper
{
    public static void ThrowIfNullOrEmptyString(string? param, string? expression)
    {
        ArgumentNullException.ThrowIfNull(param, expression);

        if (param.Equals(string.Empty))
        {
            ThrowArgumenException(string.Format("The string parameter '{0}' cannot be empty.", expression), expression);
        }
    }

    public static void ThrowIfNullOrEmptyCollection<T>(IEnumerable<T>? param, string? expression)
    {
        ArgumentNullException.ThrowIfNull(param, expression);

        if (!param.Any())
        {
            ThrowArgumenException(string.Format("The collection '{0}' cannot be empty.", expression), expression);
        }
    }

    [DoesNotReturn]
    public static void ThrowArgumenException(string message, string? expression)
    {
        throw new ArgumentException(message, expression);
    }
}




