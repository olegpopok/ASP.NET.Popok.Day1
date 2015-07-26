using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Library;
using Task2.Library;

namespace Task1_2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Task1:");
            System.Console.WriteLine("Newton : {0} \nMath.Pow : {1}", Newton.Radical(31, 2), Math.Pow(31, 0.5));
            System.Console.ReadKey();

            int[][] array = new int[][]
            {
                new int[] {1, 2, 12, 54, },
                new int[] {3, 5, -14, 12, -25},
                new int[] {8, 5, -5, 11},
                new int[] {15, -7, 4}
            };

            System.Console.WriteLine("Task2");

            System.Console.WriteLine("Initialized array:");
            WriteArray(array);

            System.Console.WriteLine("Sort sum elements ascending:");
            JuggedArray.Sort(array, new SortSumElementsAscending());
            WriteArray(array);

            System.Console.WriteLine("Sort sum elements descending:");
            JuggedArray.Sort(array, new SortSumElementsDescending());
            WriteArray(array);

           
            System.Console.WriteLine("Sort max element in module ascending:");
            JuggedArray.Sort(array, new SortMaxElelmentInModuleAscending());
            WriteArray(array);

            System.Console.WriteLine("Sort max element in module descending:");
            JuggedArray.Sort(array, new SortMaxElelmentInModuleDescending());
            WriteArray(array);

            System.Console.ReadKey();
        }

        private static void WriteArray(int[][] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    System.Console.Write("{0}  ", array[i][j]);
                }

                System.Console.WriteLine();
            }
        }

        private sealed class SortSumElementsAscending : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                int sumOfX = x.Sum(), sumOfY = y.Sum();

                if (sumOfX > sumOfY)
                    return 1;
                if (sumOfX < sumOfY)
                    return -1;
                else
                    return 0;
            }
        }

        private sealed class SortSumElementsDescending : IComparer<int[]>
        {
             public int Compare(int[] x, int[] y)
            {
                int sumOfX = x.Sum(), sumOfY = y.Sum();

                if (sumOfX > sumOfY)
                    return -1;
                if (sumOfX < sumOfY)
                    return 1;
                else
                    return 0;
            }
        }

        private sealed class SortMaxElelmentInModuleAscending : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                int maxElementOfX = x.Max(numb => Math.Abs(numb)), maxElementOfY = y.Max(num => Math.Abs(num));

                if (maxElementOfX > maxElementOfY)
                    return 1;
                if (maxElementOfX < maxElementOfY)
                    return -1;
                else
                    return 0;
            }
        }

        private sealed class SortMaxElelmentInModuleDescending : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                int maxElementOfX = x.Max(numb => Math.Abs(numb)), maxElementOfY = y.Max(numb => Math.Abs(numb));

                if (maxElementOfX > maxElementOfY)
                    return -1;
                if (maxElementOfX < maxElementOfY)
                    return 1;
                else
                    return 0;
            }
        }
    }
}
