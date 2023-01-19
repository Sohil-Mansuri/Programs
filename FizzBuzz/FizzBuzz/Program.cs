using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            FizzBuzz(n);

            Console.ReadKey();

        }

        public static void FizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }

        }
    }
}
