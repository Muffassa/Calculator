﻿using Calculator.SortingOfMassivs;
using NUnit.Framework;

namespace Calculator.Tests.SortingOfArrays
{
    [TestFixture]
    class HeapSortTests : AbstractSortTests
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new HeapSort();
        }
    }
}