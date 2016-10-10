using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/ctci-array-left-rotation

namespace Arrays
{
    public class RotateLeft
    {
        public static int[] Rotate(int[] input, int rotations)
        {
            var temp = new int[input.Length];
            Array.Copy(input, temp, input.Length);

            for (int i = input.Length - rotations, j = 0; i < input.Length; i++, j++)
            {
                input[i] = temp[j];
            }

            for (var i = 0; i < input.Length - rotations; i++)
            {
                input[i] = temp[rotations + i];
            }

            return input;
        }

        //static void Main(string[] args)
        //{
        //    int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    input = RotateLeft.Rotate(input, 5);

        //    Console.WriteLine(string.Join(" ", input));
        //    Console.Read();
        //}
    }
}
