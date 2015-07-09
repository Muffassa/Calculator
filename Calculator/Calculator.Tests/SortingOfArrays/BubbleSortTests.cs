﻿using Calculator.SortingOfMassivs;
using NUnit.Framework;

namespace Calculator.Tests.SortingOfArrays
{
    class BubbleSortTests : AbstractSortTests
    {

        [SetUp]
        public void Initialize()
        {
            Sorter = new BubbleSort();
        }
    }
}