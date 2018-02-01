using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Enter desired nth digit of Fibonnaci sequence: ");
                var input = Console.ReadLine();

                if(int.TryParse(input, out var inputValue))
                {
                    PrintSequence(inputValue);
                    break;
                }
            }

            Console.WriteLine("\nPress any key to quit.");
            Console.ReadKey();
        }

        static void PrintSequence(int n)
        {
            if(n < 0)
            {
                Console.WriteLine("Only input values greater than 0");
                return;
            }
            else if(n == 0)
            {
                Console.WriteLine("0");
                return;
            }
            else if(n == 1)
            {
                Console.WriteLine("1");
                return;
            }

            Console.Write("1, 1");

            uint f0 = 1;
            uint f1 = 1;

            for(var i = 3; i <= n; ++i)
            {
                uint f2 = f0 + f1;
                f0 = f1;
                f1 = f2;

                Console.Write(", " + f2);
            }
        }
    }
}
