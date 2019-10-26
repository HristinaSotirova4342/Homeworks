using System;

namespace hommework2
{
    class Program
    {
        static void Main(string[] args)
        {

            int answer = 0;
            while (answer <= 10)
            {
                Console.Write("Enter an integer: ");
                answer = Convert.ToInt32(Console.ReadLine());

                if (!(answer <= 10))
                {
                    Console.WriteLine("Integer greter than 10 detected!");
                }
             
            }

            Console.ReadLine();
        }
    }
}
