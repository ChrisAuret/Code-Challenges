using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class bubblesort
    {
        static int ThirdLargest(int[] input)
        {
            var first = int.MinValue;
            var second = int.MinValue;
            var third = int.MinValue;

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] > first)
                {
                    first = input[i];
                    second = first;
                    third = second;
                }
                else if (input[i] > second && input[i] != first)
                {
                    third = second;
                    second = input[i];
                }
                else if (input[i] > third && input[i] != second && input[i] != first)
                {
                    third = input[i];
                }
            }

            return third;
        }
    }
}
