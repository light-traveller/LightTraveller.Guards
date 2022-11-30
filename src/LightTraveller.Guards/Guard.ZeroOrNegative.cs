﻿using System.Runtime.CompilerServices;
using static LightTraveller.Guards.Messages;

namespace LightTraveller.Guards;

public partial class Guard
{
    /// <summary>
    /// Throws if the input argument is zero or a negative number; otherwise, returns the argument itself.
    /// </summary>
    /// <param name="param">The argument to be validated.</param>
    /// <param name="expression">The expression resolving to the value of the argument being checked. This is automatically generated by the compiler.</param>
    /// <returns>The input argument, if it passes the check.</returns>
    /// <exception cref="ArgumentException">The argument resolves to zero or a negative value.</exception>
    public static int ZeroOrNegative(int param, string? message = null, [CallerArgumentExpression("param")] string expression = "")
    {
        if (param <= 0)
            Helper.ArgumentException.Throw(message.IfEmptyThen(Messages.ZeroOrNegative), expression);

        return param;
    }

    /// <summary>
    /// Throws if the input argument is zero or a negative number; otherwise, returns the argument itself.
    /// </summary>
    /// <param name="param">The argument to be validated.</param>
    /// <param name="expression">The expression resolving to the value of the argument being checked. This is automatically generated by the compiler.</param>
    /// <returns>The input argument, if it passes the check.</returns>
    /// <exception cref="ArgumentException">The argument resolves to zero or a negative value.</exception>
    public static long ZeroOrNegative(long param, string? message = null, [CallerArgumentExpression("param")] string expression = "")
    {
        if (param <= 0L)
            Helper.ArgumentException.Throw(message.IfEmptyThen(Messages.ZeroOrNegative), expression);

        return param;
    }

    /// <summary>
    /// Throws if the input argument is zero or a negative number; otherwise, returns the argument itself.
    /// </summary>
    /// <param name="param">The argument to be validated.</param>
    /// <param name="expression">The expression resolving to the value of the argument being checked. This is automatically generated by the compiler.</param>
    /// <returns>The input argument, if it passes the check.</returns>
    /// <exception cref="ArgumentException">The argument resolves to zero or a negative value.</exception>
    public static float ZeroOrNegative(float param, string? message = null, [CallerArgumentExpression("param")] string expression = "")
    {
        if (param <= 0F)
            Helper.ArgumentException.Throw(message.IfEmptyThen(Messages.ZeroOrNegative), expression);

        return param;
    }

    /// <summary>
    /// Throws if the input argument is zero or a negative number; otherwise, returns the argument itself.
    /// </summary>
    /// <param name="param">The argument to be validated.</param>
    /// <param name="expression">The expression resolving to the value of the argument being checked. This is automatically generated by the compiler.</param>
    /// <returns>The input argument, if it passes the check.</returns>
    /// <exception cref="ArgumentException">The argument resolves to zero or a negative value.</exception>
    public static double ZeroOrNegative(double param, string? message = null, [CallerArgumentExpression("param")] string expression = "")
    {
        if (param <= 0D)
            Helper.ArgumentException.Throw(message.IfEmptyThen(Messages.ZeroOrNegative), expression);

        return param;
    }

    /// <summary>
    /// Throws if the input argument is zero or a negative number; otherwise, returns the argument itself.
    /// </summary>
    /// <param name="param">The argument to be validated.</param>
    /// <param name="expression">The expression resolving to the value of the argument being checked. This is automatically generated by the compiler.</param>
    /// <returns>The input argument, if it passes the check.</returns>
    /// <exception cref="ArgumentException">The argument resolves to zero or a negative value.</exception>
    public static decimal ZeroOrNegative(decimal param, string? message = null, [CallerArgumentExpression("param")] string expression = "")
    {
        if (param <= 0M)
            Helper.ArgumentException.Throw(message.IfEmptyThen(Messages.ZeroOrNegative), expression);

        return param;
    }
}
