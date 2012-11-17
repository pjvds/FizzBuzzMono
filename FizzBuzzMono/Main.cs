using System;

namespace FizzBuzzMono
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}