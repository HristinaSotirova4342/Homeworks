using System;

namespace Digitron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operatot: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if(op == "-"){
                Console.Write(num1 - num2);
            }
            else if (op == "*"){
                Console.Write(num1 * num2);
            }
            else if (op == "/"){
                Console.Write(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
