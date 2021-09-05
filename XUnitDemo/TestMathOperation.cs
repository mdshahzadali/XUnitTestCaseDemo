using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XunitConsoleApp;

namespace XUnitTestDemo
{
    public class TestMathOperation
    {
        
        [Fact]
        public void TestAdditionalFunctionality_ShouldReturn20()
        {
            MathOperation mathOperation = new MathOperation();
            int result = mathOperation.AddNumber(10, 10);
            Assert.Equal(20, result);
        }
        [Fact]
        public void TestAdditionalFunctionality_ShouldReturn5()
        {
            MathOperation mathOperation = new MathOperation();
            int result = mathOperation.AddNumber(10, -5);
            Assert.Equal(5, result);
        }
        [Fact]
        public void TestAdditionalFunctionality_ShouldReturnNegative10()
        {
            MathOperation mathOperation = new MathOperation();
            int result = mathOperation.AddNumber(-5, -5);
            Assert.Equal(-10, result);
        }
        [Fact]
        public void TestAdditionalFunctionality_ShouldReturn0()
        {
            MathOperation mathOperation = new MathOperation();
            int result = mathOperation.AddNumber(-5, 5);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestMultiplicationFunctionality_ShouldReturn20()
        {
            MathOperation mathOperation = new MathOperation();
            int result = mathOperation.MultiplyNumber(10, 2);
            Assert.Equal(20, result);
        }
    }
}
