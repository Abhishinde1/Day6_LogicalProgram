using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    internal class UC4Reverse_Number
    {
        public static void ReverseNumber()
        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
           for (int i=0; i<n; i++)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
                
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
