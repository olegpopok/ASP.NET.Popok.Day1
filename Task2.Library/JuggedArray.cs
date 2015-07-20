using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Library
{

    public static class JuggedArray
    {
        public static void Sort(int[][] array, ISZArrayComparer comparer)
        {
            if (array == null)
                throw new ArgumentNullException("array");
            if (comparer == null)
                throw new ArgumentNullException("comparer");
            BubbleSort(array, comparer);
        }

        private static void BubbleSort(int[][] array, ISZArrayComparer comparer)
        {
            int n = array.Length;
            while (n- 1 > 0)
            {
                for (int i = 0; i < array.Count() - 1; i++)
                    if (comparer.Compare(array[i], array[i + 1]) > 0)
                        Swap(array, i, i+1);
                n--;
            }
        }

        private static void Swap(int[][] array, int i, int j)
        {
            int[] temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
