using System.Collections.Generic;
using DataStructures.Lists;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Implements the Insertion Sort algorithm over ArrayLists<T> and List<T>.
    /// </summary>
    public static class InsertionSorter
    {

        // The quick insertion sort algorithm.
        // For the internal ArrayList<T>. Check the DataStructures.ArrayList.cs.
        public static void InsertionSort<T>(this ArrayList<T> list, Comparer<T> comparer = null)
        {

            // If the comparer is Null, then initialize it using a default typed comparer
            comparer = comparer ?? Comparer<T>.Default;

            for (int i = 1; i < list.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (comparer.Compare(list[j], list[j - 1]) < 0)
                    {
                        var temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
    }
}