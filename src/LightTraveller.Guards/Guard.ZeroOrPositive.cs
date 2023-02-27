﻿using System.Runtime.CompilerServices;

namespace LightTraveller.Guards;

public partial class Guard
{
    /// <summary>
    /// Throws if the input argument is zero or a positive number; otherwise, returns the argument itself.
    /// </summary>
    /// <param name="param">The argument to be validated.</param>
    /// <param name="expression">The expression resolving to the value of the argument being checked. This is automatically generated by the compiler.</param>
    /// <returns>The input argument, if it passes the check.</returns>
    /// <exception cref="ArgumentException">The argument resolves to a positive value.</exception>
    public static T ZeroOrPositive<T>(T param, string? message = null, [CallerArgumentExpression("param")] string expression = "")
        where T : struct, IEquatable<T>, IComparable<T>
    {
        if (param.CompareTo(default) >= 0)
            Helper.ArgumentException.Throw(message.IfEmptyThen(Messages.ZeroOrPositive), expression);

        return param;
    }
}
