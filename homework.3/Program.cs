using System;

namespace homework._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write(MaxNumber(number));
        }
        static int MaxNumber(int number)
        {
          
            int[] count = new int[100]; 
            String str = number.ToString();

            for (int i = 0; i < str.Length; i++)
                count[str[i] - '0']++;

            int result = 0, multiplier = 1;

            for (int i = 0; i <= 9; i++)
            {
                while (count[i] > 0)
                {
                    result += (i * multiplier);
                    count[i]--;
                    multiplier *= 10;
                }
            }

            return result;
        }
    }
}
