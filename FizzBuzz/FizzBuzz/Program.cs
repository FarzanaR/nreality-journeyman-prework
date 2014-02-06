using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 101; i++)
            {
                if (i.IsFizz() && i.IsBuzz())
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i.IsFizz())
                {
                    Console.WriteLine("Fizz");
                }
                else if (i.IsBuzz())
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }

        public static bool IsFizz(this int number)
        {
            return number % 3 == 0;
        }

        public static bool IsBuzz(this int number)
        {
            return number % 5 == 0;
        }

    }
}
