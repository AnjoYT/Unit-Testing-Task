using Xunit;

namespace UnequalConsecutiveCharacters.Tests
{
    public class StringAnalyzerTests
    {
        [Theory]
        [InlineData("aasdfsdf", 7)]
        [InlineData("AAs%1sdF", 7)]
        [InlineData("zddfaascdd", 4)]
        public void UnequalCosecutiveCharacters(string sequence, int expected)
        {
            //Act
            int actual = SequenceAnalyzer.CountUnequalConsecutiveCharacters(sequence);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("aa111d3d22s5", 2)]
        [InlineData("AAs%1sdF", 2)]
        [InlineData("hhhadfgdsgdd", 3)]
        public void CosecutiveLetters(string sequence, int expected)
        {
            //Act
            int actual = SequenceAnalyzer.CountConsecutiveLetters(sequence);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("aa111d3d22s5", 3)]
        [InlineData("AAs%1sdF", 1)]
        [InlineData("442355643563333", 4)]
        public void CosecutiveDigits(string sequence, int expected)
        {
            //Act
            int actual = SequenceAnalyzer.CountConsecutiveNumbers(sequence);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConsecutiveDigitsReturnsZero()
        {
            //Arrange
            string sequence = "";
            int expected = 0;
            //Act
            int actual = SequenceAnalyzer.CountConsecutiveNumbers(sequence);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConsecutiveLettersReturnsZero()
        {
            //Arrange
            string sequence = "";
            int expected = 0;
            //Act
            int actual = SequenceAnalyzer.CountConsecutiveLetters(sequence);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]

        public void UnequalConsecutiveCharReturnsZero()
        {
            //Arrange
            string sequence = "";
            int expected = 0;
            //Act
            int actual = SequenceAnalyzer.CountUnequalConsecutiveCharacters(sequence);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConsecutiveDigitsReturnsOne()
        {
            //Arrange
            string sequence = "1";
            int expected = 1;
            //Act
            int actual = SequenceAnalyzer.CountConsecutiveNumbers(sequence);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConsecutiveLettersReturnsOne()
        {
            //Arrange
            string sequence = "1";
            int expected = 1;
            //Act
            int actual = SequenceAnalyzer.CountConsecutiveLetters(sequence);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConsecutiveLettersReturnsSequenceLength()
        {
            //Arrange
            string sequence = "aaaaaaaaa";
            int expected = 9;
            //Act
            int actual = SequenceAnalyzer.CountConsecutiveLetters(sequence);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConsecutiveDigitsReturnsSequenceLength()
        {
            //Arrange
            string sequence = "111111111";
            int expected = 9;
            //Act
            int actual = SequenceAnalyzer.CountConsecutiveNumbers(sequence);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UnequalConsecutiveCharsReturnsSequenceLength()
        {
            //Arrange
            string sequence = "abcdefg";
            int expected = 7;
            //Act
            int actual = SequenceAnalyzer.CountUnequalConsecutiveCharacters(sequence);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
