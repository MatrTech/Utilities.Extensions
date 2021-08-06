namespace Matr.Utilities.Extensions.Common
{
    public static class CharExtensions
    {
        /// <summary>
        /// Indicates whether the specified char is alphanumeric (letter)
        /// </summary>
        /// <param name="source"></param>
        /// <returns>true if the specified char is alphanumeric</returns>
        public static bool IsLetter(this char source)
            => char.IsLetter(source);

        /// <summary>
        /// Indicates whether the specified char is numeric (digit)
        /// </summary>
        /// <param name="source"></param>
        /// <returns>true if the specified char is numeric</returns>
        public static bool IsDigit(this char source)
            => char.IsDigit(source);

        /// <summary>
        /// Transforms the specified char to its lower-case variant
        /// If char is not alphanumeric the source is returned
        /// </summary>
        /// <param name="source"></param>
        /// <returns>specified char as lower-case variant</returns>
        public static char ToLower(this char source)
            => source.IsLetter()
                ? char.ToLowerInvariant(source)
                : source;

        /// <summary>
        /// Transforms the specified char to its upper-case variant
        /// If char is not alphanumeric the source is returned
        /// </summary>
        /// <param name="source"></param>
        /// <returns>specified char as upper-case variant</returns>
        public static char ToUpper(this char source)
            => source.IsLetter()
                ? char.ToUpperInvariant(source)
                : source;

        /// <summary>
        /// Converts the specified Unicode code point into a UTF-16 encoded string.
        /// </summary>
        /// <param name="value">a 21-bit Unicode code point.</param>
        /// <returns>
        ///     A string consisting of one System.Char object or a surrogate pair of System.Char objects
        ///     equivalent to the code point specified by the utf32 parameter.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// value is not a valid 21-bit Unicode code point ranging from U+0 through U+10FFFF,
        /// excluding the surrogate pair range from U+D800 through U+DFFF.
        /// </exception>
        public static string ConvertFromUtf32(this int value)
            => char.ConvertFromUtf32(value);

        /// <summary>
        /// Converts the value of a UTF-16 encoded character or surrogate pair at a specified
        /// position in a string into a Unicode code point.
        /// </summary>
        /// <param name="value">The character to convert</param>
        /// <returns>
        /// The 21-bit Unicode code point represented by the character or surrogate pair
        /// at the position in the s parameter specified by the index parameter.
        /// </returns>
        public static int ConvertToUtf32(this char value)
            => char.ConvertToUtf32(value.ToString(), 0);

        /// <summary>
        /// Converts the value of a UTF-16 encoded character or surrogate pair at a specified
        /// </summary>
        /// <param name="value">A string that contains a character or surrogate pair.</param>
        /// <param name="index">The index position of the character or surrogate pair in s.</param>
        /// <returns>
        /// The 21-bit Unicode code point represented by the character or surrogate pair
        /// at the position in the s parameter specified by the index parameter.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">
        /// <paramref name="value"/> is null.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// index is not a position within s.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// The specified index position contains a surrogate pair, and either the first
        /// character in the pair is not a valid high surrogate or the second character in
        /// the pair is not a valid low surrogate.
        /// </exception>
        public static int ConvertToUtf32(this string value, int index = 0)
            => char.ConvertToUtf32(value, index);

        /// <summary>
        /// Converts the numeric Unicode character at the specified position in a specified
        /// string to a double-precision floating point number.
        /// </summary>
        /// <param name="s"><see cref="string"/></param>
        /// <param name="index">The character position in <paramref name="s"/></param>
        /// <returns>
        ///     The numeric value of the character at position index in s if that character represents
        ///     a number; otherwise, -1.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">
        /// <paramref name="s"/> is null.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// <paramref name="index"/> is less than zero or greater than the length of <paramref name="s"/>
        /// </exception>
        public static double GetNumericValue(this string s, int index = 0)
            => char.GetNumericValue(s, index);

        /// <summary>
        /// Converts the specified numeric Unicode character to a double-precision floating
        /// point number.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>The numeric value of c if that character represents a number; otherwise, -1.0.</returns>
        public static double GetNumericValue(this char c)
            => char.GetNumericValue(c);
    }
}