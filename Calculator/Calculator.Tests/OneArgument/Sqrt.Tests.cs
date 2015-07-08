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
    class SqrtTests
    {
        [TestCase(9)]
        [TestCase(25)]
        [TestCase(16)]
        [TestCase(4)]
        public void Calculate(double argument)
        {
            var calculator = new Sqrt();
            var testResult = calculator.Calculate(argument);
            var result = Math.Sqrt(argument);
            Assert.AreEqual(testResult,result);
        }
    }
}