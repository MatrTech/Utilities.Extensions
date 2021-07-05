using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        [DataRow(0x0041, "A")]
        [DataRow(0x0042, "B")]
        [DataRow(0x0043, "C")]
        [DataRow(0x0061, "a")]
        [DataRow(0x0062, "b")]
        [DataRow(0x0063, "c")]
        [DataRow(0x0030, "0")]
        [DataRow(0x0031, "1")]
        [DataRow(0x0032, "2")]
        public void ConvertFromUtf32_SomeUtf32Value_ShouldBeExpectedResult(int utf32, string expectedResult)
        {
            utf32.ConvertFromUtf32().Should().Be(expectedResult);
        }

        [TestMethod]
        [DataRow('A', 0x0041)]
        [DataRow('B', 0x0042)]
        [DataRow('C', 0x0043)]
        [DataRow('a', 0x0061)]
        [DataRow('b', 0x0062)]
        [DataRow('c', 0x0063)]
        [DataRow('0', 0x0030)]
        [DataRow('1', 0x0031)]
        [DataRow('2', 0x0032)]
        public void ConvertToUtf32_SomeLetter_ShouldBeExpectedValue(char character, int expectedUtf32Value)
        {
            character.ConvertToUtf32().Should().Be(expectedUtf32Value);
        }

        [TestMethod]
        [DataRow("A", 0x0041)]
        [DataRow("B", 0x0042)]
        [DataRow("C", 0x0043)]
        [DataRow("a", 0x0061)]
        [DataRow("b", 0x0062)]
        [DataRow("c", 0x0063)]
        [DataRow("0", 0x0030)]
        [DataRow("1", 0x0031)]
        [DataRow("2", 0x0032)]
        public void ConvertToUtf32StringVersion_SomeLetter_ShouldBeExpectedValue(string stringCharacter, int expectedUtf32Value)
        {
            stringCharacter.ConvertToUtf32().Should().Be(expectedUtf32Value);
        }

        [TestMethod]
        [DataRow("0", 0.0)]
        [DataRow("4", 4.0)]
        [DataRow("9", 9.0)]
        public void GetNumericValue_SomeChar_ShouldBeExpectedResult(string c, double expectedResult)
        {
            c.GetNumericValue().Should().Be(expectedResult);
        }
    }
}