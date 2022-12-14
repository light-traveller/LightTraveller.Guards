using System.Runtime.CompilerServices;

namespace LightTraveller.Guards;

public partial class Guard
{
    /// <summary>
    /// Throws if the input argument is zero or a positive number; otherwise, returns the argument itself.
    /// </summary>
    /// <param name="param">The argument to be validated.</param>
    /// <param name="expression">The expression resolving to the value of the argument being checked. This is automatically generated by the compiler.</param>
    /// <returns>The input argument, if it passes the check.</returns>
    /// <exception cref="ArgumentException">The argument resolves to zero or a positive value.</exception>
    public static int ZeroOrPositive(int param, string? message = null, [CallerArgumentExpression("param")] string expression = "")
    {
        if (param >= 0)
            Helper.ArgumentException.Throw(message.IfEmptyThen(Messages.ZeroOrPositive), expression);

        return param;
    }

    /// <summary>
    /// Throws if the input argument is zero or a positive number; otherwise, returns the argument itself.
    /// </summary>
    /// <param name="param">The argument to be validated.</param>
    /// <param name="expression">The expression resolving to the value of the argument being checked. This is automatically generated by the compiler.</param>
    /// <returns>The input argument, if it passes the check.</returns>
    /// <exception cref="ArgumentException">The argument resolves to zero or a positive value.</exception>
    public static long ZeroOrPositive(long param, string? message = null, [CallerArgumentExpression("param")] string expression = "")
    {
        if (param >= 0L)
            Helper.ArgumentException.Throw(message.IfEmptyThen(Messages.ZeroOrPositive), expression);

        return param;
    }

    /// <summary>
    /// Throws if the input argument is zero or a positive number; otherwise, returns the argument itself.
    /// </summary>
    /// <param name="param">The argument to be validated.</param>
    /// <param name="expression">The expression resolving to the value of the argument being checked. This is automatically generated by the compiler.</param>
    /// <returns>The input argument, if it passes the check.</returns>
    /// <exception cref="ArgumentException">The argument resolves to zero or a positive value.</exception>
    public static float ZeroOrPositive(float param, string? message = null, [CallerArgumentExpression("param")] string expression = "")
    {
        if (param >= 0F)
            Helper.ArgumentException.Throw(message.IfEmptyThen(Messages.ZeroOrPositive), expression);

        return param;
    }

    /// <summary>
    /// Throws if the input argument is zero or a positive number; otherwise, returns the argument itself.
    /// </summary>
    /// <param name="param">The argument to be validated.</param>
    /// <param name="expression">The expression resolving to the value of the argument being checked. This is automatically generated by the compiler.</param>
    /// <returns>The input argument, if it passes the check.</returns>
    /// <exception cref="ArgumentException">The argument resolves to zero or a positive value.</exception>
    public static double ZeroOrPositive(double param, string? message = null, [CallerArgumentExpression("param")] string expression = "")
    {
        if (param >= 0D)
            Helper.ArgumentException.Throw(message.IfEmptyThen(Messages.ZeroOrPositive), expression);

        return param;
    }

    /// <summary>
    /// Throws if the input argument is zero or a positive number; otherwise, returns the argument itself.
    /// </summary>
    /// <param name="param">The argument to be validated.</param>
    /// <param name="expression">The expression resolving to the value of the argument being checked. This is automatically generated by the compiler.</param>
    /// <returns>The input argument, if it passes the check.</returns>
    /// <exception cref="ArgumentException">The argument resolves to zero or a positive value.</exception>
    public static decimal ZeroOrPositive(decimal param, string? message = null, [CallerArgumentExpression("param")] string expression = "")
    {
        if (param >= 0M)
            Helper.ArgumentException.Throw(message.IfEmptyThen(Messages.ZeroOrPositive), expression);

        return param;
    }
}
