using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace MatrTech.Utilities.Extensions.Common.UnitTests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void IsNullOrEmpty_StringEmpty_True()
        {
            string foo = string.Empty;

            var result = foo.IsNullOrEmpty();

            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrEmpty_StringNull_True()
        {
            string foo = null;

            var result = foo.IsNullOrEmpty();

            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrEmpty_StringNotEmpty_False()
        {
            string foo = "hello world";

            var result = foo.IsNullOrEmpty();

            result.Should().BeFalse();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_StringNull_True()
        {
            string foo = null;

            var result = foo.IsNullOrWhiteSpace();

            result.Should().BeFalse();
        }
    }
}
