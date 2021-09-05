using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XunitConsoleApp;

namespace XUnitTestDemo
{
    public class TestStringRelatedProgram
    {
        [Fact]
        public void ShouldReturnReverseOfGivenString()
        {
            StringRelatedProgram stringRelatedProgram = new StringRelatedProgram();
           string result = stringRelatedProgram.ReverseString("Hello");

            Assert.Equal("olleH", result);
        }
        [Fact]
        public void ShouldReturnTrueIfPassedStringPalindrome()
        {
            StringRelatedProgram stringRelatedProgram = new StringRelatedProgram();
            bool result = stringRelatedProgram.checkIsPalindrome("madam");

            Assert.True(result);
        }
        [Fact]
        public void ShouldReturnFalseIfPassedStringNotPalindrome()
        {
            StringRelatedProgram stringRelatedProgram = new StringRelatedProgram();
            bool result = stringRelatedProgram.checkIsPalindrome("satish");

            Assert.False(result);
        }

        [Fact]
        public void ShouldReverseWordOrder()
        {
            StringRelatedProgram stringRelatedProgram = new StringRelatedProgram();
            string result = stringRelatedProgram.ReverseWordOrder("satish kumar");

            Assert.Equal("kumar satish",result);
        }
    }
}
