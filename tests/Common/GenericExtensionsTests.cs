using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

        [TestMethod]
        [DataRow(default(string))]
        [DataRow(null)]
        public void IsNull_StringNullOrDefault_True(string source)
        {
            source.IsNull().Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrDefault_DefaultInt_True()
        {
            int source = default;
            source.IsNullOrDefault().Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrDefault_DefaultFloat_True()
        {
            float source = default;
            source.IsNullOrDefault().Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrDefault_DefaultDouble_True()
        {
            double source = default;
            source.IsNullOrDefault().Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrDefault_DefaultLong_True()
        {
            long source = default;
            source.IsNullOrDefault().Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrDefault_NullableIntDefault_True()
        {
            int? source = default;
            source.IsNullOrDefault().Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrDefault_NullableInt0_True()
        {
            int? source = 0;
            source.IsNullOrDefault().Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrDefault_DefaultDateTime_True()
        {
            DateTime source = default;
            source.IsNullOrDefault().Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrDefault_NullableDateTimeDefault_True()
        {
            DateTime? source = default;
            source.IsNullOrDefault().Should().BeTrue();
        }

        [TestMethod]
        public void IsNull_TestClassNull_True()
        {
            TestClass source = null!;
            source.IsNull().Should().BeTrue();
        }

        [TestMethod]
        public void IsNull_NullableTestClassNull_True()
        {
            TestClass? source = null;
            source.IsNull().Should().BeTrue();
        }

        [TestMethod]
        public void IsNull_TestClassNotNull_False()
        {
            TestClass source = new TestClass();
            source.IsNull().Should().BeFalse();
        }

        [TestMethod]
        public void IsNull_NullableTestClassNotNull_False()
        {
            TestClass? source = new TestClass();
            source.IsNull().Should().BeFalse();
        }

        private class TestClass {}
    }
}