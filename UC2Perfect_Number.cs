using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    internal class UC2Perfect_Number
    {
        public static void Perfectnumber()
        {
            int number, sum = 0, n;
            Console.Write(" enter the number ");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
            }
        }
    }
}

