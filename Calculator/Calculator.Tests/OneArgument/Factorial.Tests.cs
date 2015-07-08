﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    class FactorialTests
    {
        [TestCase(2, 2)]
        [TestCase(0, 1)]
        public void Calculate(double argument, double result)
        {
            var calculator = new Factorial();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}