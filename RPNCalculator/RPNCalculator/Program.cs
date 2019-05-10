using System;


namespace RPNCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is RPN calculator");
            Console.WriteLine("Expression: 2 3 + ");
            string expression = "2 3 +";
            double result = EvaluateRPNExpression(expression);
            Console.WriteLine("Result: {0}", result);
            Console.WriteLine("Expected result: 5");
        }

        static double EvaluateRPNExpression(string expr) {
            double result = 0;
            return result;
        }
    }
}
