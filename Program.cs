using System;

namespace fizzbuzz
{
    class MainClass
    {
        public static void Main(string[] args)  //Simple fizzbuzz solution
        {
            int n = 1;
            while (n <= 100)
            {
                if (n % 3 == 0 && n % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else if (n % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (n % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(n);
                }
                n++;
            }
        }
    }
}
