using System.Collections.Generic;
using DataStructures.Lists;
using Algorithms.Common;

namespace Algorithms.Sorting
{
    public static class InsertionSorter
    {
        /// <summary>
        /// Implements the InsertionSort over the ArrayList<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="comparer"></param>
        public static void InsertionSort<T>(this ArrayList<T> list, Comparer<T> comparer = null)
        {
            // If the comparer is Null, then initialize it using a default typed comparer
            comparer = comparer ?? Comparer<T>.Default;

            // implementation of the insertion sorting
            for (int i = 1; i < list.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (comparer.Compare(list[j], list[j - 1]) < 0)
                    {
                        Helpers.SwapArrayList(list, j, j - 1);
                    }                        
                }
            }
        }
    }
}