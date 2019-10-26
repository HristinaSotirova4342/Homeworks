using System;

namespace homework._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int a = 0;

            for(int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.Write("Prime number: " + number);
            }
            else
            {
                Console.Write("Not a Prime number: " + number);
            }
           

            Console.ReadLine();
        }
    }
}
