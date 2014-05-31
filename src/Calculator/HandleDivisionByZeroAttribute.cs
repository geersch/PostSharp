using System;
using System.Reflection;
using PostSharp.Aspects;

namespace Calculator
{
    [Serializable]
    public class HandleDivisionByZeroAttribute : OnExceptionAspect
    {
        public override Type GetExceptionType(MethodBase targetMethod)
        {
            return typeof (DivideByZeroException);
        }

        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);
            
            Console.WriteLine("Division by zero exception");
            args.ReturnValue = 0;
            args.FlowBehavior = FlowBehavior.Continue;
        }
    }
}