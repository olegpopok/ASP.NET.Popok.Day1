using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Library
{

    public static class JuggedArray
    {
        public static void Sort(int[][] array, Comparison<int[]> comparison)
        {
            if (comparison == null)
            {
                throw new ArgumentNullException("comparison");
            }

            Sort(array, Comparer<int[]>.Create(comparison));
        }

        public static void Sort(int[][] array)
        {
            Sort(array, Comparer<int[]>.Default);
        }

        public static void Sort(int[][] array, IComparer<int[]> comparer)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            if (comparer == null)
            {
                throw new ArgumentNullException("comparer");
            }

            BubbleSort(array, comparer);
        }

        private static void BubbleSort(int[][] array, IComparer<int[]> comparer)
        {
            int n = array.Length;
            while (n- 1 > 0)
            {
                for (int i = 0; i < array.Count() - 1; i++)
                    if (comparer.Compare(array[i], array[i + 1]) > 0)
                        Swap(ref array[i], ref array[i+1]);
                n--;
            }
        }

        private static void Swap(ref int[] i, ref int[] j)
        {
            int[] temp = i;
            i = j;
            j = temp;
        }
    }
}
