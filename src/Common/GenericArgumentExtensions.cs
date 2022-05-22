using System;
using System.Runtime.CompilerServices;

namespace Matr.Utilities.Extensions.Common
{
    public static class GenericArgumentExtensions
    {

// Available starting preview 5
// #if NET7_0_OR_GREATER
//         /// <summary>
//         /// Verifies that value is not null.
//         /// </summary>
//         /// <exception cref="ArgumentNullException">
//         /// Thrown when value is null
//         /// </exception>
//          public static void NotNull<T>(this T? value, [CallerArgumentExpression(nameof(value))] string paramName = null!)
#if NET6_0_OR_GREATER
        /// <summary>
        /// Verifies that value is not null.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// Thrown when value is null
        /// </exception>
        public static void NotNull<T>(this T? value, string? message = null, [CallerArgumentExpression("value")] string paramName = null!)
#else
        /// <summary>
        /// Verifies that value is not null.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// Thrown when value is null
        /// </exception>
        public static void NotNull<T>(this T? value, string paramName, string? message = null)
            where T : struct
        {
            _ = value ?? throw new ArgumentNullException(paramName);
        }

        /// <summary>
        /// Verifies that value is not null.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// Thrown when value is null
        /// </exception>
        public static void NotNull<T>(this T value, string paramName, string? message = null)
            where T : class
#endif
        {
            _ = value ?? throw new ArgumentNullException(paramName, message);
        }
    }
}