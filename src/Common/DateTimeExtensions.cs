using System;

namespace Matr.Utilities.Extensions.Common
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// The next day-of-week is returned as a <see cref="DateTime"/>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dayOfWeek"></param>
        /// <returns>next <see cref="DateTime"/> based on <paramref name="source"/> and specified <paramref name="dayOfWeek"/></returns>
        public static DateTime Next(this DateTime source, DayOfWeek dayOfWeek)
        {
            var offsetDays = dayOfWeek - source.DayOfWeek;
            if (offsetDays <= 0)
                offsetDays += 7;
            return source.AddDays(offsetDays);
        }

        /// <summary>
        /// The previous day-of-week is returned as a <see cref="DateTime"/>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dayOfWeek"></param>
        /// <returns>previous <see cref="DateTime"/> based on <paramref name="source"/> and specified <paramref name="dayOfWeek"/></returns>
        public static DateTime Previous(this DateTime source, DayOfWeek dayOfWeek)
        {
            if (source.DayOfWeek == dayOfWeek)
                return source.AddDays(-7);

            var offsetDays = dayOfWeek - source.DayOfWeek;

            if (offsetDays < 0)
                offsetDays += 7;

            return source.AddDays((7 - offsetDays) * -1);
        }

        /// <summary>
        /// The start of the week pivoted by <paramref name="dayOfWeek"/>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dayOfWeek"></param>
        /// <returns><see cref="DateTime"/> based on <paramref name="dayOfWeek"/> and specified <paramref name="dayOfWeek"/></returns>
        public static DateTime StartOfWeek(this DateTime source, DayOfWeek dayOfWeek)
        {
            var offsetDays = (7 + (source.DayOfWeek - dayOfWeek)) % 7;
            return source.AddDays(-1 * offsetDays).Date;
        }

        /// <summary>
        /// Indicated whether the <paramref name="source"/> <see cref="DateTime"/> is in the weekend
        /// (if <paramref name="includeSaterdayAsWorkDay"/> is false <see cref="DayOfWeek.Saturday"/>) and <see cref="DayOfWeek.Sunday"/>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="includeSaterdayAsWorkDay"></param>
        /// <returns>true if datetime is <see cref="DayOfWeek.Saturday"/> or <see cref="DayOfWeek.Sunday"/></returns>
        public static bool IsWeekend(this DateTime source, bool includeSaterdayAsWorkDay = false)
        {
            return includeSaterdayAsWorkDay
                ? source.DayOfWeek == DayOfWeek.Saturday
                : source.DayOfWeek == DayOfWeek.Saturday || source.DayOfWeek == DayOfWeek.Sunday;
        }

        /// <summary>
        /// Indicated whether the <paramref name="source"/> <see cref="DateTime"/> is NOT in the weekend
        /// (if <paramref name="includeSaterdayAsWorkDay"/> is false <see cref="DayOfWeek.Saturday"/>) and <see cref="DayOfWeek.Sunday"/>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="includeSaterdayAsWorkDay"></param>
        /// <returns>true if datetime is NOT <see cref="DayOfWeek.Saturday"/> or <see cref="DayOfWeek.Sunday"/></returns>
        public static bool IsWorkingDay(this DateTime source, bool includeSaterdayAsWorkDay = false)
        {
            return includeSaterdayAsWorkDay
                ? source.DayOfWeek != DayOfWeek.Sunday
                : source.DayOfWeek != DayOfWeek.Saturday && source.DayOfWeek != DayOfWeek.Sunday;
        }

        /// <summary>
        /// Provides the next working day (if <paramref name="includeSaterdayAsWorkDay"/> is false <see cref="DayOfWeek.Saturday"/>) and <see cref="DayOfWeek.Sunday"/>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="includeSaterdayAsWorkDay"></param>
        /// <returns><see cref="DateTime"/> of next working day</returns>
        public static DateTime NextWorkingDay(this DateTime source, bool includeSaterdayAsWorkDay = false)
        {
            var nextDay = source.AddDays(1);
            while (!nextDay.IsWorkingDay(includeSaterdayAsWorkDay))            
                nextDay = nextDay.AddDays(1);

            return nextDay;
        }
    }
}