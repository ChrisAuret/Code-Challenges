using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
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

            Console.WriteLine(IsBalanced(input) ? "Yes" : "No");

            Console.ReadLine();
        }
    }
}
