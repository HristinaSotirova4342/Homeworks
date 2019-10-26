using System;

namespace hommework1
{
    class Program
    { 

        static int NumberOfElements(int []arr) {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                    counter++;
            }
            return counter;
        }


        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;
            Console.WriteLine("Enter the size of the array: ");
            int elements = Convert.ToInt32(Console.In.ReadLine());
            int[] arr = new int[elements];

            Console.WriteLine("Input elements in the array :");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Number of positive elements {0} ", NumberOfElements(arr));

            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("Sum of all negative elements: {0}\n\n", sum);

            for (i = 0; i < arr.Length; i++)
            { }
            Console.WriteLine("[" + NumberOfElements(arr) + "," + sum + "]");

            Console.WriteLine();
        }
    }
}
