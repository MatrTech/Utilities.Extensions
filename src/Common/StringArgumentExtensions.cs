using System;
using System.Runtime.CompilerServices;

namespace Matr.Utilities.Extensions.Common
{
    public static class StringArgumentExtensions
    {
        /// <summary>
        /// Verifies that string value is not null or empty.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when value is null or empty
        /// </exception>
// #if NET7_0_OR_GREATER
//         public static void NotNullOrEmpty(this string? value, string? message = null, [CallerArgumentExpression(nameof(value))] string paramName = null!)
#if NET6_0_OR_GREATER
        public static void NotNullOrEmpty(this string? value, string? message = null, [CallerArgumentExpression("value")] string paramName = null!)
#else
        public static void NotNullOrEmpty(this string? value, string paramName, string? message = null)
#endif
        {
            if(value.IsNullOrEmpty()) throw new ArgumentException(message, paramName);
        }

#if NET6_0_OR_GREATER
        public static void NotNullOrWhiteSpace(this string? value, string? message = null, [CallerArgumentExpression("value")] string paramName = null!)
#else
        public static void NotNullOrWhiteSpace(this string? value, string paramName, string? message = null)
#endif
        {
            if(value.IsNullOrWhiteSpace()) throw new ArgumentException(message, paramName);
        }
    }
}