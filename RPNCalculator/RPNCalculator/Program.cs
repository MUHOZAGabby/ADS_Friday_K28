using System;


namespace RPNCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is RPN calculator");
            string infixExpression = "2 + 3";
            Console.WriteLine("This is our infixexpression {0}", infixExpression);
            string postfixExpression = InfixToPostfix(infixExpression);
            Console.WriteLine("This is our postfix expression {0}", postfixExpression);
            double expectedResult = 5;
            double result = EvaluateRPNExpression(postfixExpression);
            Console.WriteLine("Result: {0}", result);
            Console.WriteLine("Expected result: {0}", expectedResult);
        }
        public static string InfixToPostfix(string infixExpression)
        {
            Stack<string> operatorStack = new Stack<string>();
            string output = "";
            foreach (var item in infixExpression.Split(' '))
            {
                if (double.TryParse(item, out double operand))
                {
                    if (output == "") {
                        output = item;
                    }
                    else
                    {
                        output += " " + item;
                    }
                   
                }
                else
                {
                    operatorStack.Push(item);
                }

            }
            while (!operatorStack.IsEmpty())
            {
                output += " " + operatorStack.Pop();
            }
            return output;
        }

        static double EvaluateRPNExpression(string expr)
        {
            Stack<double> numStack = new Stack<double>();

            foreach (var item in expr.Split(' '))//expr.Split transforms a string into an array
            {
                if (double.TryParse(item, out double operand))
                {
                    numStack.Push(operand);
                }
                else
                {
                    double op2 = numStack.Pop();
                    double op1 = numStack.Pop();
                    double output = Evaluate(op1, op2, item);//item is operator like + - * /
                    numStack.Push(output);
                }
            }
            return numStack.Pop();
        }
        static double Evaluate(double operand1, double operand2, string operation)
        {
            if (operation == "+")
                return operand1 + operand2;
            else if (operation == "-")
                return operand1 - operand2;
            else if (operation == "*")
                return operand1 * operand2;
            else if (operation == "/")
                return operand1 / operand2;
            else
                return 0;
        }
    }

    public class Stack<T>//T means any type, we can create a stack of int, string, etc.
    {
        int count;
        T[] elements;

        public Stack()
        {
            count = 0;
            elements = new T[10];
        }
        public void Push(T element)
        {
            elements[count] = element; //Count points to the top of the stack.
            count++;
        }
        public T Pop()
        {
            count--;
            return elements[count]; //Count points to the top of the stack.
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
