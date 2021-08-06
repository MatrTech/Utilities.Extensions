using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Matr.Utilities.Extensions.Common.UnitTests
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

            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_StringEmpty_True()
        {
            string foo = string.Empty;

            var result = foo.IsNullOrWhiteSpace();

            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_StringOnlyWhiteSpace_True()
        {
            string foo = "    ";

            var result = foo.IsNullOrWhiteSpace();

            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_StringWhiteSpaceEscapes_True()
        {
            string foo = "\t\r\n";

            var result = foo.IsNullOrWhiteSpace();

            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_StringFilled_False()
        {
            string foo = "hello world";

            var result = foo.IsNullOrWhiteSpace();

            result.Should().BeFalse();
        }
    }
}
