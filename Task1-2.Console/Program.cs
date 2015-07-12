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
            System.Console.WriteLine("Newton : {0} \nMath.Pow : {1}", Newton.Radical(31, 2, 0.0000001), Math.Pow(31, 0.5));
            System.Console.ReadKey();

            int[][] array = new int[][]
            {
                new int[] {13, 1, 9, 2 },
                new int[] {3, 5},
                new int[] {8, 5, 11},
                new int[] {15, 3, -7, 4}
            };

            System.Console.WriteLine("Task2:");
            WriteArary(array);
            System.Console.WriteLine();
            JuggedArray.SortByMaxElementOfLine(array, 0);
            WriteArary(array);
            System.Console.WriteLine();
            JuggedArray.SortByMinElementOFLine(array, 1);
            WriteArary(array);
            System.Console.WriteLine();
            JuggedArray.SortBySumElementsOfline(array, 0);
            WriteArary(array);
            System.Console.WriteLine();

            System.Console.ReadKey();
        }

        private static void WriteArary(int[][] array)
        {
            for (int i = 0; i < array.Count(); i++)
            {
                for (int j = 0; j < array[i].Count(); j++)
                    System.Console.Write(array[i][j] + " ");
                System.Console.WriteLine();
            }
        }
    }
}
