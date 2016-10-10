using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/ctci-making-anagrams

namespace Strings
{
    class MakingAnagramsBetter
    {
        public static int NumberToRemove(string a, string b)
        {
            var charCount = new int[26];

            foreach (var ch in a)
            {
                var index = (int) ch - 97;
                charCount[index]++;
            }

            foreach (var ch in b)
            {
                var index = (int)ch - 97;
                charCount[index]--;
            }

            return charCount.Sum(Math.Abs);
        }
    }
}
