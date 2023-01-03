using PalindromeExercise;
using System;
using Xunit;
using Xunit.Sdk;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kayak", true)]
        [InlineData("eve", true)]
        [InlineData("banana", false)]
        [InlineData("noon", true)]
        [InlineData("rotator", true)]
        [InlineData("racecars", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            var instance = new WordSmith();

            //Act
            var actual = instance.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
