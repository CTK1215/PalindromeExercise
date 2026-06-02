using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("level", true)]
        [InlineData("madam", true)]
        [InlineData("hello", false)]
        [InlineData("world", false)]
        [InlineData("a", true)]
        public void IsAPalindrome_ReturnsExpectedResult(string input, bool expected)
        {
            // Arrange
            WordSmith wordSmith = new WordSmith();

            // Act
            bool result = wordSmith.IsAPalindrome(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}