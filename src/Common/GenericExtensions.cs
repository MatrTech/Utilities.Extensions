using System;

namespace MatrTech.Utilities.Extensions.Common
{
    public static class GenericExtensions
    {
        /// <summary>
        /// <para>Indicates whether the specified <paramref name="source"/> is between the <paramref name="start"/> and <paramref name="end"/></para>
        /// <para><typeparamref name="T"/> must be inherited from <see cref="IComparable{T}"/></para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="inclusive"></param>
        /// <returns>true if <paramref name="source"/> is between <paramref name="start"/> and <paramref name="end"/></returns>
        public static bool Between<T>(this T source, T start, T end, bool inclusive = false)
            where T : struct, IComparable<T>
        {
            dynamic dsource = source, dstart = start, dend = end;
            return inclusive
                ? dsource >= dstart && dsource <= dend
                : dsource > dstart && dsource < dend;
        }

        public static bool IsNullOrDefault<T>(this T source)
            where T : struct
        {
            return Equals(source, default(T));
        }

        public static bool IsNullOrDefault<T>(this T? source)
            where T : struct
        {
            return source == null || Equals(source, default(T));
        }

        public static bool IsNull<T>(this T? source)
            where T : class
        {
            return source == null;
        }
    }
}