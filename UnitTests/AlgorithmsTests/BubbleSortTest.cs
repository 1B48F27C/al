using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures.Lists;
using Algorithms.Sorting;

namespace UnitTests.AlgorithmsTests
{
    public static class BubbleSortTest
    {
        [Fact]
        public static void DoTest()
        {
            ArrayList<int> list = new ArrayList<int> {
                34,
                65,
                4,
                -56,
                6,
                -54,
                -7,
                8,
                0,
                53,
                4,
                45,
                7
            };

            list.BubbleSort<int>();

            Assert.True(list.IsSorted());
        }
    }
}
