using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("kayak", true)]
        [InlineData("Racercar", true)]
        [InlineData("wat", false)]
        [InlineData("", true)]
        [InlineData(null, false)]
        [InlineData("Tuba", false)]
        public void isAPalindrome_Test(string word, bool expected)
        {
            //Arrange
            var wordFORGING = new WordSmith();
            //Act
            var actual = wordFORGING.IsAPArome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
