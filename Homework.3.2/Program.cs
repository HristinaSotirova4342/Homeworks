using System;

namespace Homework._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.Write("The sum of two numbers is : {0} \n", sum);

            string binary = Convert.ToString(sum, 2);
            Console.Write("The binary sum of two numbers is: {0}\n", binary);


        }
    }
}
