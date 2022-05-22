using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Matr.Utilities.Extensions.Common.UnitTests
{
    [TestClass]
    public class StringArgumentExtensionsTests
    {
        [TestMethod]
        public void NotNullOrEmpty_StringNotNull_ShouldNotThrow()
        {
            string? value = "hello world";

#if NET6_0_OR_GREATER
            Action act = () => value.NotNullOrEmpty();
#else
            Action act = () => value.NotNullOrEmpty(nameof(value));
#endif

            act.Should().NotThrow();
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        public void NotNullOrEmpty_InvalidStrings_ShouldThrowArgumentException(string? value)
        {
#if NET6_0_OR_GREATER
            Action act = () => value.NotNullOrEmpty();
#else
            Action act = () => value.NotNullOrEmpty(nameof(value));
#endif
            act.Should().Throw<ArgumentException>()
                .WithParameterName(nameof(value));
        }

        [TestMethod]
        public void NotNullOrWhiteSpace_StringNotNull_ShouldNotThrow()
        {
            string? value = "hello world";

#if NET6_0_OR_GREATER
            Action act = () => value.NotNullOrWhiteSpace();
#else
            Action act = () => value.NotNullOrWhiteSpace(nameof(value));
#endif
            act.Should().NotThrow();
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("   ")]
        public void NotNullOrWhiteSpace_InvalidStrings_ShouldThrowArgumentException(string? value)
        {
#if NET6_0_OR_GREATER
            Action act = () => value.NotNullOrWhiteSpace();
#else
            Action act = () => value.NotNullOrWhiteSpace(nameof(value));
#endif
            act.Should().Throw<ArgumentException>()
                .WithParameterName(nameof(value));
        }
    }
}