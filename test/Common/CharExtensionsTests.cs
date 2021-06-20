using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using MatrTech.Utilities.Extensions.Common;

namespace MatrTech.Utilities.Extensions.Common.UnitTests
{
    [TestClass]
    public class CharExtensionsTests
    {
        [TestMethod]
        public void ToLower_CharUpper_TransformedToLower()
        {
            char foo = 'A';

            var lowered = foo.ToLower();

            lowered.Should().Be('a');
        }

        [TestMethod]
        public void ToUpper_CharLower_TransformedToUpper()
        {
            char foo = 'a';

            var upper = foo.ToUpper();

            upper.Should().Be('A');
        }

        [TestMethod]
        public void IsDigit_NumericInput_True()
        {
            char foo = '1';

            var isDigit = foo.IsDigit();

            isDigit.Should().BeTrue();
        }

        [TestMethod]
        public void IsDigit_SpecialCharInput_False()
        {
            char foo = '+';

            var isDigit = foo.IsDigit();

            isDigit.Should().BeFalse();
        }

        [TestMethod]
        public void IsLetter_AlphanumericInput_True()
        {
            char foo = 'A';
            char bar = 'a';

            var isAlphaNumeric = foo.IsLetter();
            isAlphaNumeric.Should().BeTrue();

            isAlphaNumeric = bar.IsLetter();
            isAlphaNumeric.Should().BeTrue();
        }

        [TestMethod]
        public void IsLetter_SpecialCharInput_False()
        {
            char foo = '-';

            var isAlphaNumeric = foo.IsDigit();

            isAlphaNumeric.Should().BeFalse();
        }
    }
}