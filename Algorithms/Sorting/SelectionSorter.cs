using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.Lists;
using Algorithms.Common;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Implements the Selection Sort.
    /// </summary>
    public static class SelectionSorter
    {
        public static void SelectionSort<T>(this ArrayList<T> list, Comparer<T> comparer = null)
        {
            // checking whether we have passed comparer or not
            comparer = comparer ?? Comparer<T>.Default;

            // implementation of selection sorting
            int minIndex = 0;
            for (int i = 0; i < list.Count-1; i++)
            {
                for (int j = i; j < list.Count; j++)
                {
                    if (comparer.Compare(list[minIndex], list[j]) > 0) minIndex = j;
                }
                if (minIndex != i)
                {
                    Helpers.SwapArrayList(list, i, minIndex);
                    minIndex = i+1;
                }
            }
        }
    }
}