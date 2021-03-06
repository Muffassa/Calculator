﻿using System;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{

    [TestFixture]
    class DivisionTests
    {
        /// <summary>
        /// Test of division function
        /// </summary>
        /// <param name="firstArgument">dividend</param>
        /// <param name="secondArgument">divisor</param>
        /// <param name="result">quotient</param>
        [TestCase(10, 2, 5)]
        [TestCase(7, 2, 3.5)]
        [TestCase(-10, 2, -5)]
        [TestCase(1, 10, 0.1)]
        public void Calculate(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Division();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void DivisionByZeroTests()
        {
            var calculator = new Division();
            var result = calculator.Calculate(4, 0);
        }
    }
}