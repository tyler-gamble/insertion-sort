using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("\nOriginal Array Elements :");
            PrintIntegerArray(numbers);

            Console.WriteLine("\nSorted Array Elements :");
            PrintIntegerArray(InsertionSort(numbers));
            Console.WriteLine("\n");
        }


        static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)// i points to currenct place being sorted 
            {
                for (int j = i + 1; j > 0; j--)//repeat until at start of array
                {
                    // Swap if the element at in wrong order
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray; // Return the sorted array
        }

        // Method to print integer array elements
        public static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  "); // Display each element followed by a space
            }
        }
    }
}