using System;
using System.Diagnostics.CodeAnalysis;

namespace MatrTech.Utilities.Extensions.Common
{
    public static class StringExtensions
    {
        /// <summary>
        /// Indicates whether the specified string is null or an empty string ("")..
        /// </summary>
        /// <param name="source">The string to test.</param>
        /// <returns>true if the value parameter is null or an empty string(""); otherwise, false.</returns>
        public static bool IsNullOrEmpty([NotNullWhen(false)] this string? source)
            => string.IsNullOrEmpty(source);

        /// <summary>
        /// Indicates whether a specified string is null, empty or consists only of white-space characters.
        /// </summary>
        /// <param name="source">The string to test.</param>
        /// <returns>true if the value parameter is null, an empty string ("") or if value consists exclusively of white-space characters.
        public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? source)
            => string.IsNullOrWhiteSpace(source);
    }
}
