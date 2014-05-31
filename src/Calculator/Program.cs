using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            ICalculator calculator = new Calculator();

            calculator.Add(2, 7);
            calculator.Subtract(10, 8);
            calculator.Multiply(3, 3);
            calculator.Divide(20, 4);
            calculator.Divide(20, 0);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
