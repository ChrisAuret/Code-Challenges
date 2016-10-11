using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        public static bool IsBalanced2(string input)
        {
            var stack = new Stack<char>();

            foreach (var c in input)
            {
                if (c == '[' || c == '(' || c == '{')
                {
                    stack.Push(c);

                }
                else if (c == ']')
                {
                    if (stack.Count == 0) return false;
                    if (stack.Pop() != '[') return false;

                }
                else if (c == ')')
                {
                    if (stack.Count == 0) return false;
                    if (stack.Pop() != '(') return false;

                }
                else if (c == '}')
                {
                    if (stack.Count == 0) return false;
                    if (stack.Pop() != '{') return false;
                }
            }
            return stack.Count == 0;
        }

        public static bool IsBalanced(string input)
        {
            var pairs = new Dictionary<char, char> { { '}','{' }, { ']','[' }, { ')', '('} };

            var history = new Stack<char>();    // Last in first out

            foreach (var c in input)
            {
                if (pairs.ContainsValue(c))
                {
                    history.Push(c);
                }

                if (pairs.ContainsKey(c) && (history.Count== 0 || history.Pop() != pairs[c]))
                {
                    return false;
                }
            }

            return history.Count == 0;
        }


        static void Main(string[] args)
        {
            //{[()]}
            //{[(])}
            //{{[[(())]]}}

            var input = "{{[[(())]]}}";

            Console.WriteLine(IsBalanced2(input) ? "Yes" : "No");

            Console.ReadLine();
        }
    }
}
