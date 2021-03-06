﻿using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    
    [TestFixture]
    class SumTests
    {
        /// <summary>
        /// Function for addition two arguments
        /// </summary>
        /// <param name="firstArgument">first argument of addition</param>
        /// <param name="secondArgument">second argument of addition</param>
        /// <param name="result">expected result</param>
        [TestCase( 5, 5, 10)]
        [TestCase(-5, 2, -3)]
        [TestCase(-4, -8, -12)]
        public void Calculate(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Sum();
            var testResult = calculator.Calculate(firstArgument,secondArgument);
            Assert.AreEqual(result,testResult);
        }
    }
}

