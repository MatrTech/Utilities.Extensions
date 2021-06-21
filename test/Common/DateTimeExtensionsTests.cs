using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;

using System.Drawing;

namespace MatrTech.Utilities.Extensions.Common.UnitTests
{
    [TestClass]
    public class DateTimeExtensionsTests
    {
        [TestMethod]
        [DataRow(DayOfWeek.Monday, 7)]
        [DataRow(DayOfWeek.Tuesday, 1)]
        [DataRow(DayOfWeek.Wednesday, 2)]
        [DataRow(DayOfWeek.Thursday, 3)]
        [DataRow(DayOfWeek.Friday, 4)]
        [DataRow(DayOfWeek.Saturday, 5)]
        [DataRow(DayOfWeek.Sunday, 6)]
        public void NextDayOfWeek_SourceAsMonday_GetsNextDayOfWeek(DayOfWeek dayOfWeek, int offset)
        {
            var foo = new DateTime(2021, 6, 21);

            var result = foo.Next(dayOfWeek);

            result.DayOfWeek.Should().Be(dayOfWeek);
            ((int)(result - foo).TotalDays).Should().Be(offset);
        }

        [TestMethod]
        [DataRow(DayOfWeek.Monday, -7)]
        [DataRow(DayOfWeek.Tuesday, -6)]
        [DataRow(DayOfWeek.Wednesday, -5)]
        [DataRow(DayOfWeek.Thursday, -4)]
        [DataRow(DayOfWeek.Friday, -3)]
        [DataRow(DayOfWeek.Saturday, -2)]
        [DataRow(DayOfWeek.Sunday, -1)]
        public void PreviousDayOfWeek_SourceAsMonday_GetsPreviousDayOfWeek(DayOfWeek dayOfWeek, int offset)
        {
            var foo = new DateTime(2021, 6, 21);

            var result = foo.Previous(dayOfWeek);

            result.DayOfWeek.Should().Be(dayOfWeek);
            ((int)(result - foo).TotalDays).Should().Be(offset);
        }

        [TestMethod]
        [DataRow(DayOfWeek.Sunday, 20)]
        [DataRow(DayOfWeek.Monday, 21)]
        [DataRow(DayOfWeek.Friday, 18)]
        [DataRow(DayOfWeek.Wednesday, 23)]
        public void StartOfWeek_SourceAsWednesday_GetsStartDateBasedOnDayOfWeek(DayOfWeek dayOfWeek, int day)
        {
            var foo = new DateTime(2021, 6, 23);

            DateTime? result = foo.StartOfWeek(dayOfWeek);

            result.Should().Be(new DateTime(2021, 6, day));
        }
    }
}