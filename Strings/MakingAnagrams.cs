using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/ctci-making-anagrams

namespace Strings
{
    public class MakingAnagrams
    {
        public struct Instance
        {
            public char Character { get; set; }
        
            public int Count { get; set; }
        }

        public static int RemoveCount(string left, string right)
        {
            var leftRegister = CountChars(left);
            var rightRegister = CountChars(right);

            var diff = 0;

            var rightTemp = new Dictionary<char, int>(rightRegister);
            var leftTemp = new Dictionary<char, int>(leftRegister);

            foreach (var ch in rightRegister.Keys)
            {
                if (leftRegister.ContainsKey(ch))
                {
                    diff += Math.Abs(rightRegister[ch] - leftRegister[ch]);
                }
                else
                {
                    diff += rightRegister[ch];
                }

                rightTemp.Remove(ch);
                leftTemp.Remove(ch);
            }

            foreach (var key in leftTemp.Keys)
            {
                diff += leftTemp[key];
            }

            foreach (var key in rightTemp.Keys)
            {
                diff += rightTemp[key];
            }

            return diff;
        }

        public static Dictionary<char, int> CountChars(string input)
        {
            var register = new Dictionary<char, int>();

            foreach (var c in input.ToLower().ToCharArray())
            {
                if (!register.ContainsKey(c))
                {
                    register.Add(c, 1);
                }
                else
                {
                    register[c]++;
                }
            }

            return register;
        }
    }
}
