using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "({{})";
            var result = Compare(input);
        }

        public static bool Compare(string input)
        {
            bool isMatch = true;
            Stack<char> stackOfOpenParenthis = new Stack<char>();
            for (int index = 0; index < input.Length; index++)
            {
                if(input[index] == '(' || input[index] == '[' || input[index] == '{')
                {
                    stackOfOpenParenthis.Push(input[index]);
                }
                else if(input[index] == ')')
                {
                    if(stackOfOpenParenthis.Peek() != '(')
                    {
                        isMatch = false;
                        break;
                    }
                    else
                        stackOfOpenParenthis.Pop();
                }
                else if (input[index] == '}')
                {
                    if (stackOfOpenParenthis.Peek() != '{')
                    {
                        isMatch = false;
                        break;
                    }
                    else
                        stackOfOpenParenthis.Pop();
                }
                else if (input[index] == ']')
                {
                    if (stackOfOpenParenthis.Peek() != '[')
                    {
                        isMatch = false;
                        break;
                    }
                    else
                        stackOfOpenParenthis.Pop();
                }

            }

            if (stackOfOpenParenthis.Count > 0)
                isMatch = false;

            return isMatch;
        }
    }
}
