using System;

namespace homework._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string revers;
            revers = "";

        
            int length1;
            length1 = str.Length - 1;

            while (length1 >= 0)
            {
                revers += str[length1];
                length1--;
            }
            Console.WriteLine("Reversed: {0}", revers);
            Console.ReadLine();
        }
    }
}
 
