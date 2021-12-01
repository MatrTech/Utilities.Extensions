using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Matr.Utilities.Extensions.Common
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

        /// <summary>
        /// A randomly generated string is created based on the following seed: ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789
        /// </summary>
        /// <param name="_"></param>
        /// <param name="length"></param>
        /// <param name="except"></param>
        /// <returns>A randomly generated string</returns>
        public static string Random(this string? _, int length, params char[] except)
        {
            if (length < 0)
                throw new ArgumentException($"Parameter length cannot be smaller then 0. Value: {length} is therefore invalid.");


            var rnd = new Random();
            var exceptArray = except?
                .ToArray()
                .Select(c => char.IsLetter(c) ? char.ToUpper(c) : c)
                .ToList() ?? new List<char>();

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
                .ToCharArray()
                .Except(exceptArray)
                .ToList();

            if (!chars.Any())
                return string.Empty;

            return string.Join(string.Empty, Enumerable.Range(0, length)
                .Select(c => chars[rnd.Next(0, chars.Count)])
                .Select(c => c.IsLetter()
                    ? rnd.Next(0, 1) == 0
                        ? c.ToLower()
                        : c
                    : c));
        }
    }
}
