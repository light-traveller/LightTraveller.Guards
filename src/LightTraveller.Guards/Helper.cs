using System.Diagnostics.CodeAnalysis;

namespace LightTraveller.Guards;

internal static class Helper
{
    internal static class ArgumentException
    {
        [DoesNotReturn]
        internal static void Throw(string? message, string? expression)
        {
            throw new System.ArgumentException(message, expression);
        }
    }

    public static class ArgumentNullException
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <param name="expression"></param>
        /// <exception cref="ArgumentNullException">param is null.</exception>
        public static void ThrowIfNull([NotNull] object? param, string? message, string? expression)
        {
            if (message.Empty())
                System.ArgumentNullException.ThrowIfNull(param, expression);
            else
            {
                if (param is null)
                {
                    throw new System.ArgumentNullException(expression, message);
                }
            }
        }
    }

    internal static class Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="expression"></param>
        /// <exception cref="ArgumentNullException">param is null.</exception>
        /// <exception cref="ArgumentException">param is empty or consists of only white-space characters.</exception>
        internal static void ThrowIfNullOrEmptyString([NotNull] string? param, string? expression)
        {
            System.ArgumentNullException.ThrowIfNull(param, expression);

            if (param.Empty())
            {
                ArgumentException.Throw(string.Format("The string parameter '{0}' cannot be empty.", expression), expression);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <param name="expression"></param>
        /// <exception cref="ArgumentNullException">param is null.</exception>
        /// <exception cref="ArgumentException">param is empty or consists of only white-space characters.</exception>
        internal static void ThrowIfNullOrEmptyString([NotNull] string? param, string? message, string? expression)
        {
            ArgumentNullException.ThrowIfNull(param, message, expression);

            if (param.Empty())
            {
                ArgumentException.Throw(message, expression);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="expression"></param>
        /// <exception cref="ArgumentNullException">param is null.</exception>
        /// <exception cref="ArgumentException">param is an empty collection.</exception>
        internal static void ThrowIfNullOrEmptyCollection<T>([NotNull] IEnumerable<T>? param, string? expression)
        {
            System.ArgumentNullException.ThrowIfNull(param, expression);

            if (!param.Any())
            {
                ArgumentException.Throw(string.Format("The collection '{0}' cannot be empty.", expression), expression);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <param name="expression"></param>
        /// <exception cref="ArgumentNullException">param is null.</exception>
        /// <exception cref="ArgumentException">param is an empty collection.</exception>
        internal static void ThrowIfNullOrEmptyCollection<T>([NotNull] IEnumerable<T>? param, string? message, string? expression)
        {
            ArgumentNullException.ThrowIfNull(param, message, expression);

            if (!param.Any())
            {
                ArgumentException.Throw(message, expression);
            }
        }
    }

    internal static class InvalidEnumArgumentException
    {
        public static void ThrowIfNotDefined<TEnum>([NotNull] TEnum param, string? message, string? expression) where TEnum : struct, Enum
        {
            if (!Enum.IsDefined(param))
            {
                if (message.Empty())
                    throw new System.ComponentModel.InvalidEnumArgumentException(expression, Convert.ToInt32(param), typeof(TEnum));

                throw new System.ComponentModel.InvalidEnumArgumentException(message);
            }
        }

        public static void ThrowIfNotDefined<TEnum>(int param, string? message, string? expression) where TEnum : struct, Enum
        {
            if (!Enum.IsDefined(typeof(TEnum), param))
            {
                if (message.Empty())
                    throw new System.ComponentModel.InvalidEnumArgumentException(expression, param, typeof(TEnum));

                throw new System.ComponentModel.InvalidEnumArgumentException(message);
            }
        }
    }
}


