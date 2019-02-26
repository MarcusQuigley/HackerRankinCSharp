using HackerRankinCore;
using System;
using Xunit;


namespace XUnitTestProject1
{
    public class GayleArraysTests
    {
        [Fact]
        public void Urlify_should_be_correct()
        {
            GayleArrays ga = new GayleArrays();
            ga.Urlify("Mr John Smith      ", 13);
        }

        [Fact]
        public void Palindrome_works()
        {
            GayleArrays ga = new GayleArrays();
            var result = ga.IsPalindrome("TactCoa");
            Assert.True(result);
        }
    }
}
