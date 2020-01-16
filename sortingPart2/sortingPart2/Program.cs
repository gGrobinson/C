using System;

namespace sortingPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating random array of numbers

            int Min = 0;
            int Max = 20;
            int arraySize = 10;

            string[] testIntArray = new string[arraySize];

            Random randNum = new Random();

            for (int i = 0; i < testIntArray.Length; i++)
            {
                testIntArray[i] = randNum.Next(Min, Max).ToString();
            }

            //Create random array of characters

            string[] unsorted = { "z", "e", "x", "c", "m", "q", "a", "d", "b" };

            //Sorting array of ints

            Console.WriteLine("\n Here's the unsorted array of strings: ");
            printArray(unsorted);

            QuickSort(unsorted, 0, unsorted.Length-1);

            Console.WriteLine("\n Here's the sorted array of strings: ");
            printArray(unsorted);

            Console.WriteLine("\n Here's the unsorted array of integers: ");
            printArray(testIntArray);

            QuickSort(testIntArray, 0, testIntArray.Length - 1);

            Console.WriteLine("\n Here's the sorted array of integers: ");
            printArray(testIntArray);

            Console.ReadKey();
        }

        public static void QuickSort(IComparable[] elements,int left,int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];
            while(i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if(i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(elements, left, j);
            }

            if (i < right)
            {
                QuickSort(elements, i, right);
            }
        }

        static void printArray(IComparable[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
