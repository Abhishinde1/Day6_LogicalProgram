namespace logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to LogicalProgram");

            Console.WriteLine("Choose option \n 1.Fibonacci Series");
            int optionCheck = Convert.ToInt32(Console.ReadLine());
            switch (optionCheck)
            {
                case 1:
                    FibonacciSeries.Fibonacci();
                    break;
            }

        }
    }
}
    
