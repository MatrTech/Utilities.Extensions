using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Matr.Utilities.Extensions.Common.UnitTests
{
    [TestClass]
    public class GenericArgumentExtensionsTests
    {
        [TestMethod]
        public void NotNull_ValueNotNull_ShouldNotThrow()
        {
            string foo = "hello world";

#if NET6_0_OR_GREATER
            Action act = () => foo.NotNull();
#else
            Action act = () => foo.NotNull(nameof(foo));
#endif
            act.Should().NotThrow();
        }

        [TestMethod]
        public void NotNull_ValueNull_ShouldThrowArgumentNullException()
        {
            string foo = null!;

#if NET6_0_OR_GREATER
            Action act = () => foo.NotNull();
#else
            Action act = () => foo.NotNull(nameof(foo));
#endif
            act.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void NotNull_ValueNull_ParameterNameSet()
        {
            string foo = null!;

#if NET6_0_OR_GREATER
            Action act = () => foo.NotNull();
#else
            Action act = () => foo.NotNull(nameof(foo));
#endif
            act.Should().Throw<ArgumentNullException>()
                .WithParameterName(nameof(foo));
        }
    }
}