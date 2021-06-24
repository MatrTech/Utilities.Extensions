using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using MatrTech.Utilities.Extensions.Common;

namespace MatrTech.Utilities.Extensions.Common.UnitTests
{
    [TestClass]
    public class CharExtensionsTests
    {
        [TestMethod]
        [DataRow('A', 'a')]
        [DataRow('_', '_')]
        [DataRow('a', 'a')]
        public void ToLower_DiverseInput_TransformedToLower(char input, char output)
        {
            var lowered = input.ToLower();
            lowered.Should().Be(output);
        }

        [TestMethod]
        [DataRow('A', 'A')]
        [DataRow('_', '_')]
        [DataRow('a', 'A')]
        public void ToUpper_DiverseInput_TransformedToUpper(char input, char output)
        {
            var upper = input.ToUpper();
            upper.Should().Be(output);
        }

        [TestMethod]
        [DataRow('1', true)]
        [DataRow('a', false)]
        [DataRow('~', false)]
        public void IsDigit_NumericInput_True(char input, bool expected)
        {
            var isDigit = input.IsDigit();
            isDigit.Should().Be(expected);
        }

        [TestMethod]
        [DataRow('-')]
        [DataRow('+')]
        [DataRow('~')]
        public void IsDigit_SpecialCharInput_False(char input)
        {
            var isDigit = input.IsDigit();
            isDigit.Should().BeFalse();
        }

        [TestMethod]
        [DataRow('A')]
        [DataRow('a')]
        public void IsLetter_AlphanumericInput_True(char input)
        {
            var isAlphaNumeric = input.IsLetter();
            isAlphaNumeric.Should().BeTrue();
        }

        [TestMethod]
        [DataRow('-')]
        [DataRow('+')]
        [DataRow('~')]
        public void IsLetter_SpecialCharInput_False(char input)
        {
            var isAlphaNumeric = input.IsLetter();
            isAlphaNumeric.Should().BeFalse();
        }
    }
}