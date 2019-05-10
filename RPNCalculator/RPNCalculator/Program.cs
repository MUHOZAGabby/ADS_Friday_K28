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

        static double EvaluateRPNExpression(string expr)
        {
            Stack<double> numStack = new Stack<double>();
            double operand;
            
            foreach (var item in expr.Split(' '))
            {
                if(double.TryParse(item, out operand))
                {
                        numStack.Push(operand);
                }
                else
                {
                        double op2 = numStack.Pop();
                        double op1 = numStack.Pop();
                        double output = Evaluate(op1, op2, item);
                        numStack.Push(output);
                }

            }
            return numStack.Pop();
        }
        static double Evaluate(double op1, double op2, string opeerator)
        {
                if (opeerator == "+")
                    return op1 + op2;
                else
                    return 0;
        }
    }

    public  class Stack<T>//T means any type, we can create a stack of int, string, etc.
    {
        int count;
        T[] elements;

        public Stack(){
            count = 0;
            elements = new T[10];
        }
        public  void Push(T element)
        {
            elements[count] = element;
            count++;
        }
        public T Pop()
        {
            count--;
            return elements[count];
        }
        public bool IsEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
