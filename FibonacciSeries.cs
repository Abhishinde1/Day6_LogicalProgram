using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    internal class FibonacciSeries
    {
        
            public static void Fibonacci()
            {
                Console.WriteLine("Please enter how many fibonocci numbers we have to generate");
                int number = Convert.ToInt32(Console.ReadLine());
                int firstNum = 0, second = 1;
                int result = 0;
                result = firstNum + second;
                Console.Write("{0} ", firstNum );
                for (int i = 1; i < number; i++)
                {
                firstNum = second;
                    second = result;
                    result = firstNum + second;
                    Console.Write(" " + result);
                }
            }
        }
    }


