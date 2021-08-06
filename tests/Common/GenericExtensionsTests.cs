using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;

namespace Matr.Utilities.Extensions.Common.UnitTests
{
    [TestClass]
    public class GenericExtensionsTests
    {

        [TestMethod]
        public void BetweenDate_DateInBetweenExclusive_True()
        {
            var source = new DateTime(2021, 6, 23);
            var start = source.AddDays(-2);
            var end = source.AddDays(2);

            source.Between(start, end).Should().BeTrue();
        }

        [TestMethod]
        public void BetweenDate_PointInBetweenExclusive_True()
        {
            var source = 5;
            var start = 1;
            var end = 8;

            source.Between(start, end).Should().BeTrue();
        }
    }
}