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
            Stack<int> numStack = new Stack<int>();
            int operand;
            
            foreach (var item in expr.Split(' '))            {
            {
                if(int.TryParse(item, out operand))
                {
                        numStack.Push(operand);
                }
                else
                {
                        int op2 = numStack.Pop();
                        int op1 = numStack.Pop();

                }
            }
            
            double result = 0;
            return result;

            
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
