using System.Collections.Generic;
using DataStructures.Lists;
using Algorithms.Sorting;
using Xunit;

namespace UnitTest.AlgorithmsTests
{
    public static class InsertionSortForListTest
    {
        [Fact]
        public static void DoTest()
        {
            var list1 = new List<int>
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

            list1.InsertionSort<int>();
            bool isListSorted = true;
            for (int i = 0; i < list1.Count - 1; i++)
            {
                if (list1[i] > list1[i+1])
                {
                    isListSorted = false;
                    break;
                }
            }

            Assert.True(isListSorted);
        }
    }
}