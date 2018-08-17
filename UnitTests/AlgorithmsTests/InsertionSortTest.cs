using System.Collections.Generic;
using DataStructures.Lists;
using Algorithms.Sorting;
using Xunit;

namespace UnitTest.AlgorithmsTests
{
    public static class InsertionSortWithArrayListTest
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
            bool isListSorted = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i+1])
                {
                    isListSorted = false;
                    break;
                }
            }

            Assert.True(isListSorted);
        }
    }
}