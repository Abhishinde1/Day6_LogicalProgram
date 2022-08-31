using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    internal class UC3Prime_NUM
    {
        public static void PrimeNumber()
        {
            int i, n, b = 0;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= n / 2; i++)
            {
                int result = n % i;
                if (result == 0)
                {
                    b++;
                    break;
                }

            }

            if (b == 0 && n != 1)
            {
                Console.WriteLine(n + " Enter number is prime");
            }
            else
            {
                Console.WriteLine(n + " Enter number is not prime");
            }

        }
    }
}

