using System.Diagnostics.CodeAnalysis;

namespace LightTraveller.Guards;

internal static class Helper
{
    internal static class ArgumentException
    {
        [DoesNotReturn]
        internal static void Throw(string? message, string? paramName)
        {
            throw new System.ArgumentException(message, paramName);
        }
    }

    public static class ArgumentNullException
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <param name="paramName"></param>
        /// <exception cref="ArgumentNullException">param is null.</exception>
        public static void ThrowIfNull([NotNull] object? param, string? message, string? paramName)
        {
            if (message.Empty())
                System.ArgumentNullException.ThrowIfNull(param, paramName);
            else
            {
                if (param is null)
                {
                    throw new System.ArgumentNullException(paramName, message);
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
        /// <param name="paramName"></param>
        /// <exception cref="ArgumentNullException">param is null.</exception>
        /// <exception cref="ArgumentException">param is empty or consists of only white-space characters.</exception>
        internal static void ThrowIfNullOrEmptyString([NotNull] string? param, string? paramName)
        {
            System.ArgumentNullException.ThrowIfNull(param, paramName);

            if (param.Empty())
            {
                ArgumentException.Throw(string.Format("The string parameter '{0}' cannot be empty.", paramName), paramName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <param name="paramName"></param>
        /// <exception cref="ArgumentNullException">param is null.</exception>
        /// <exception cref="ArgumentException">param is empty or consists of only white-space characters.</exception>
        internal static void ThrowIfNullOrEmptyString([NotNull] string? param, string? message, string? paramName)
        {
            ArgumentNullException.ThrowIfNull(param, message, paramName);

            if (param.Empty())
            {
                ArgumentException.Throw(message, paramName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="paramName"></param>
        /// <exception cref="ArgumentNullException">param is null.</exception>
        /// <exception cref="ArgumentException">param is an empty collection.</exception>
        internal static void ThrowIfNullOrEmptyCollection<T>([NotNull] IEnumerable<T>? param, string? paramName)
        {
            System.ArgumentNullException.ThrowIfNull(param, paramName);

            if (!param.Any())
            {
                ArgumentException.Throw(string.Format("The collection '{0}' cannot be empty.", paramName), paramName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <param name="paramName"></param>
        /// <exception cref="ArgumentNullException">param is null.</exception>
        /// <exception cref="ArgumentException">param is an empty collection.</exception>
        internal static void ThrowIfNullOrEmptyCollection<T>([NotNull] IEnumerable<T>? param, string? message, string? paramName)
        {
            ArgumentNullException.ThrowIfNull(param, message, paramName);

            if (!param.Any())
            {
                ArgumentException.Throw(message, paramName);
            }
        }
    }

    internal static class InvalidEnumArgumentException
    {
        public static void ThrowIfNotDefined<TEnum>([NotNull] TEnum param, string? message, string? paramName) where TEnum : struct, Enum
        {
            if (!Enum.IsDefined(param))
            {
                if (message.Empty())
                    throw new System.ComponentModel.InvalidEnumArgumentException(paramName, Convert.ToInt32(param), typeof(TEnum));

                throw new System.ComponentModel.InvalidEnumArgumentException(message);
            }
        }

        public static void ThrowIfNotDefined<TEnum>(int param, string? message, string? paramName) where TEnum : struct, Enum
        {
            if (!Enum.IsDefined(typeof(TEnum), param))
            {
                if (message.Empty())
                    throw new System.ComponentModel.InvalidEnumArgumentException(paramName, param, typeof(TEnum));

                throw new System.ComponentModel.InvalidEnumArgumentException(message);
            }
        }
    }
}


