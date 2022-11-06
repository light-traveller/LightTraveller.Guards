using System.ComponentModel;

namespace LightTraveller.Guards;

internal static class InvalidEnumArgumentExceptionHelper
{
    public static void ThrowIfNotDefined<T>(T param, string? expression) where T : struct, Enum
    {        
        if (!Enum.IsDefined(param))
        {
            throw new InvalidEnumArgumentException(expression, Convert.ToInt32(param), typeof(T));
        }
    }

    public static void ThrowIfNotDefined<T>(int param, string? expression)
    {
        if (!Enum.IsDefined(typeof(T), param))
        {
            throw new InvalidEnumArgumentException(expression, param, typeof(T));
        }
    }
}




