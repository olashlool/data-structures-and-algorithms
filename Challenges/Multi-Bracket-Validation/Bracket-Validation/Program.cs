using Stack_Queue;
using System;
namespace Bracket_Validation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidateBrackets("{}{Code}[Fellows](())"));
            Console.WriteLine(ValidateBrackets("[({ }]"));           
        }  
        public static bool ValidateBrackets(string input)
        {
            Stack stack = new Stack();

            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }

                if (c == ')' || c == '}' || c == ']')
                {
                    if (!Check((char)stack.Peek().Value, c))
                    {
                        return false;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            if (stack.Peek() != null) return false;

            return true;
        }
        public static bool Check(char open,char close)
        {
            return open=='('&& close==')' || open == '{' && close == '}' || open == '[' && close == ']';
        }
    }
}
