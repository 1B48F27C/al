using System.Collections.Generic;
using DataStructures.Lists;
using Algorithms.Sorting;
using Xunit;

namespace UnitTest.AlgorithmsTests
{
    public static class InsertionSortTest
    {
        [Fact]
        public static void DoTest()
        {
            var list = new ArrayList<int>
            {
                23,
                42,
                4,
                16,
                8,
                -8,
                9,
                55,
                0,
                34,
                12,
                2,
                -10,
                -98
            };

            list.InsertionSort<int>();
            
            Assert.True(list.IsSorted());
        }
    }
}