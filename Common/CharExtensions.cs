namespace MatrTech.Utilities.Extensions.Common
{
    public static class CharExtensions
    {
        /// <summary>
        /// Indicates whether the specified char is alphanumeric (letter)
        /// </summary>
        /// <param name="source"></param>
        /// <returns>true if the specified char is alphanumeric</returns>
        public static bool IsLetter(this char source)
        {
            return char.IsLetter(source);
        }

        /// <summary>
        /// Indicates whether the specified char is numeric (digit)
        /// </summary>
        /// <param name="source"></param>
        /// <returns>true if the specified char is numeric</returns>
        public static bool IsDigit(this char source)
        {
            return char.IsDigit(source);
        }

        /// <summary>
        /// Transforms the specified char to its lower-case variant
        /// If char is not alphanumeric the source is returned
        /// </summary>
        /// <param name="source"></param>
        /// <returns>specified char as lower-case variant</returns>
        public static char ToLower(this char source)
        {
            return source.IsLetter()
                ? char.ToLowerInvariant(source)
                : source;
        }

        /// <summary>
        /// Transforms the specified char to its upper-case variant
        /// If char is not alphanumeric the source is returned
        /// </summary>
        /// <param name="source"></param>
        /// <returns>specified char as upper-case variant</returns>
        public static char ToUpper(this char source)
        {
            return source.IsLetter()
                ? char.ToUpperInvariant(source)
                : source;
        }
    }
}