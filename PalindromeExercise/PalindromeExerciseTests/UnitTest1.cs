using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("whatsup", false)]
        [InlineData("kayak", true)]
        [InlineData("Madam", true)]
        [InlineData("kitteN", false)]
        public void Test1(string word, bool expected)
        {

            var tester = new WordSmith();

            var actual = tester.IsAPalindrone(word);

            Assert.Equal(expected, actual);
        }










    }
}
