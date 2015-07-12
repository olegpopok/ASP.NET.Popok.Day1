using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Library
{

    public static class JuggedArray
    {
        private delegate int argumentOfSort(int[] line);
        private delegate bool directionOfSort(int a);

        public static void SortByMaxElementOfLine(int[][] array, int direct)
        {
            IComparer<int[]> comparer = new FunctorComparer(new argumentOfSort(MaxElementOfLine));
            directionOfSort direction;
            if (direct == 1)
                direction = new directionOfSort(Decrease);
            else
                direction = new directionOfSort(Increase);
            BubbleSort(array, comparer, direction);
        }

        public static void SortByMinElementOFLine(int[][] array, int direct)
        {
            IComparer<int[]> comparer = new FunctorComparer(new argumentOfSort(MinElementOfLine));
            directionOfSort direction;
            if (direct == 1)
                direction = new directionOfSort(Decrease);
            else
                direction = new directionOfSort(Increase);
            BubbleSort(array, comparer, direction);
        }

        public static void SortBySumElementsOfline(int[][] array, int direct)
        {
            IComparer<int[]> comparer = new FunctorComparer(new argumentOfSort(Sum));
            directionOfSort direction;
            if (direct == 1)
                direction = new directionOfSort(Decrease);
            else
                direction = new directionOfSort(Increase);
            BubbleSort(array, comparer, direction);
        }

        private static void BubbleSort(int[][] array, IComparer<int[]> comparer, directionOfSort direction)
        {
            int n = array.Count();
            while (n- 1 > 0)
            {
                for (int i = 0; i < array.Count() - 1; i++)
                {
                    int compareResult = comparer.Compare(array[i], array[i + 1]);
                    if (direction(compareResult))
                    {
                        Swap(ref array[i], ref array[i+1]);
                    }
                }
                n--;
            }
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }


        private static int MaxElementOfLine(int[] line)
        {
            int max = line[0];
            
            for(int i = 1; i < line.Count(); i++)
                if(line[i] > max)
                    max = line[i];
            return max;
        }
       
        private static int MinElementOfLine(int[] line)
        {
            int min = line[0];

            for (int i = 1; i < line.Count(); i++)
                if (line[i] < min)
                    min = line[i];
            return min;
        }

        private static int Sum(int[] line)
        {
            int sum = line[0];
            for (int i = 1; i < line.Count(); i++)
                sum += line[i];
            return sum;
        }

        private static bool Increase(int a)
        {
            if (a == 1)
                return true;
            else
                return false;
        }

        private static bool Decrease(int a)
        {
            if (a == -1)
                return true;
            else
                return false;
        }

        private static int CompareLine(int[] a, int[] b, argumentOfSort argument)
        {
            int argumentA = argument(a);
            int argumentB = argument(b);

            if(argumentA > argumentB)
                return 1;
            if(argumentB > argumentA)
                return -1;
            else
                return 0;
        }

        private sealed class FunctorComparer : IComparer<int[]>
        {
            argumentOfSort argument;

            public FunctorComparer(argumentOfSort argument)
            {
                this.argument = argument;
            }

            public int Compare(int[] a, int[] b)
            {
                return CompareLine(a, b, argument);
            }
        }

    }


}
