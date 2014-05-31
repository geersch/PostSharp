using System;
using System.Diagnostics;
using PostSharp.Aspects;

namespace Calculator
{
    [Serializable]
    public sealed class TraceAttribute : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            base.OnEntry(args);

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            args.MethodExecutionTag = stopwatch;
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            base.OnExit(args);

            var stopwatch = (Stopwatch) args.MethodExecutionTag;

            stopwatch.Stop();
            Console.WriteLine(
                String.Format("{0}.{1} execution time: {2}",
                              args.Method.DeclaringType.Name,
                              args.Method.Name,
                              stopwatch.ElapsedMilliseconds));
        }
    }
}