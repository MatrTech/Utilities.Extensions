using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matr.Utilities.Extensions.Common.UnitTests
{
    [TestClass]
    public class StringRandomTests
    {
        [TestMethod]
        public void Random_ZeroInput_ReturnsEmptyString()
        {
            var generated = string.Empty.Random(0);

            generated.Should()
                .BeEmpty();
        }

        [TestMethod]
        public void Random_NoExceptInput_ReturnCorrectLength()
        {
            var length = 10;
            var generated = string.Empty.Random(length);

            generated.Length
                .Should()
                .Be(length);
        }

        [TestMethod]
        public void Random_WithExceptInput_ReturnsOnlyA()
        {
            var length = 10;
            var except = "BCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            var expected = Enumerable.Range(0, length)
                .Select(s => "a");

            var generated = string.Empty.Random(length, except);

            generated.ToLowerInvariant()
                .ToArray()
                .Should()
                .AllBeEquivalentTo('a');
            generated.ToLowerInvariant()
                .ToList()
                .ForEach(c => c.Should().Be('a'));
        }

        [TestMethod]
        public void Random_WithAllExceptedInput_ReturnsEmptyString()
        {
            var length = 10;
            var except = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            var expected = Enumerable.Range(0, length)
                .Select(s => "a");
            var generated = string.Empty.Random(length, except);

            generated.Length
                .Should()
                .Be(0);
        }
    }
}