using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures.Lists;
using Algorithms.Sorting;

namespace UnitTests.AlgorithmsTests
{
    public static class SelectionSortList
    {
        [Fact]
        public static void DoTest()
        {
            ArrayList<int> list = new ArrayList<int>() {
            23,
            8,
            5,
            -98,
            5,
            43,
            -4,
            0,
            35,
            6};

            list.SelectionSort<int>();

            Assert.True(list.IsSorted());
        }
    }
}
