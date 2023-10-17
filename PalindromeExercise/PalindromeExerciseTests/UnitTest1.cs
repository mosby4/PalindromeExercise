using System;
using Xunit;
using System.Collections.Generic;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData( "racecar", true)]
        [InlineData("level", true)]
        [InlineData("civic", true)]
        [InlineData("Rufus", false)]
        public void paliTest(string word, bool expected)
        {
            //arrange
            var tester = new WordSmith();
            //Act
            var actual = tester.isAPalindrome(word);
            //assert
            Assert.Equal(actual, expected);
        }
        
       
    }
}
