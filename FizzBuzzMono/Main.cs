using System;

namespace FizzBuzzMono
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for(var i = 1; i <= 100; i++)
            {
                if(IsFizzBuzz(i))
                    Console.WriteLine("FizzBuzz");
                else if(IsFizz(i))
                    Console.WriteLine("Fizz");
                else if(IsBuzz(i))
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }

		private static bool IsFizz(int i)
		{
			return i%3 == 0;
		}

		private static bool IsBuzz(int i)
		{
			return i%5 == 0;
		}

		private static bool IsFizzBuzz(int i)
		{
			return IsFizz(i) && IsBuzz(i);
		}
    }
}