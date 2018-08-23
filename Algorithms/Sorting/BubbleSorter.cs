using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.Common;
using DataStructures.Lists;

namespace Algorithms.Sorting
{
    public static class BubbleSorter
    {
        /// <summary>
        /// Impenents the Bublbe sorting over the ArrayList<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="comparer"></param>
        public static void BubbleSort<T>(this ArrayList<T> list, Comparer<T> comparer = null)
        {
            // define the comparer
            comparer = comparer ?? Comparer<T>.Default;

            bool swapped = true;
            int len = list.Count;
            while (swapped) {
                swapped = false;
                len--;
                for (int i = 0; i < len; i++)
                {
                    if (comparer.Compare(list[i], list[i + 1]) > 0)
                    {
                        Helpers.SwapArrayList(list, i, i + 1);
                        swapped = true;
                    }
                }
            }
        }
    }
}