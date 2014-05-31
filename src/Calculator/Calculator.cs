using System;
using System.Diagnostics;
using System.Threading;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        [Log]
        [Trace]
        public int Add(int x, int y)
        {
            return x + y;
        }

        [Trace]
        public int Subtract(int x, int y)
        {
            return x - y;
        }

        [Log]
        [Trace]
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        [Log]
        [Trace]
        [HandleDivisionByZeroAttribute]
        public double Divide(int x, int y)
        {
            return x / y;
        }
    }

    // OLD VERSION OF THE CALCULATOR IMPLEMENTATION

    //public class Calculator : ICalculator
    //{
    //    public int Add(int x, int y)
    //    {
    //        var stopWatch = new Stopwatch();
    //        stopWatch.Start();

    //        // Simulate a lengthy operation
    //        Thread.Sleep(1000);

    //        var result = x + y;

    //        // Log the result to the console window
    //        Console.WriteLine(String.Format("Calculator.Add: {0}", result));


    //        // Log the execution time to the console window
    //        stopWatch.Stop();
    //        Console.WriteLine(
    //            String.Format("Calculator.Add execution time: {0}",
    //                          stopWatch.ElapsedMilliseconds));

    //        return result;
    //    }

    //    public int Subtract(int x, int y)
    //    {
    //        var stopWatch = new Stopwatch();
    //        stopWatch.Start();

    //        // Simulate a lengthy operation
    //        Thread.Sleep(1000);

    //        var result = x - y;

    //        // Log the result to the console window
    //        Console.WriteLine(String.Format("Calculator.Subtract: {0}", result));

    //        // Log the execution time to the console window
    //        stopWatch.Stop();
    //        Console.WriteLine(
    //            String.Format("Calculator.Subtract execution time: {0}",
    //                          stopWatch.ElapsedMilliseconds));

    //        return result;
    //    }

    //    public int Multiply(int x, int y)
    //    {
    //        var stopWatch = new Stopwatch();
    //        stopWatch.Start();

    //        // Simulate a lengthy operation
    //        Thread.Sleep(1000);

    //        var result = x*y;

    //        // Log the result to the console window
    //        Console.WriteLine(String.Format("Calculator.Multiply: {0}", result));

    //        // Log the execution time to the console window
    //        stopWatch.Stop();
    //        Console.WriteLine(
    //            String.Format("Calculator.Multiply execution time: {0}",
    //                          stopWatch.ElapsedMilliseconds));

    //        return result;
    //    }

    //    public double Divide(int x, int y)
    //    {
    //        try
    //        {
    //            var stopWatch = new Stopwatch();
    //            stopWatch.Start();

    //            // Simulate a lengthy operation
    //            Thread.Sleep(1000);

    //            var result = x/y;

    //            // Log the result to the console window
    //            Console.WriteLine(String.Format("Calculator.Divide: {0}", result));

    //            // Log the execution time to the console window
    //            stopWatch.Stop();
    //            Console.WriteLine(
    //                String.Format("Calculator.Divide execution time: {0}",
    //                              stopWatch.ElapsedMilliseconds));

    //            return result;
    //        }
    //        catch(DivideByZeroException)
    //        {
    //            // Gulp
    //            Console.WriteLine("Division by zero exception");
    //            return 0;
    //        }
    //    }
    //}
}
