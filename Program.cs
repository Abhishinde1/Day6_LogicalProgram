﻿namespace logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to LogicalProgram");

            Console.WriteLine("Choose option \n 1.Fibonacci Series  \n 2:Perfect Number \n 3: Prime Number \n 4:Reverse Number");
            int optionCheck = Convert.ToInt32(Console.ReadLine());
            switch (optionCheck)
            {
                case 1:
                    FibonacciSeries.Fibonacci();
                    break;
                case 2:
                    UC2Perfect_Number.Perfectnumber();
                    break;
                case 3:
                    UC3Prime_NUM.PrimeNumber();
                    break;
                case 4:
                    UC4Reverse_Number.ReverseNumber();
                    break;
            }

        }
    }
}
    
