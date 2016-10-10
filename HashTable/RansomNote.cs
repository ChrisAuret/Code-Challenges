using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/ctci-ransom-note

namespace HashTable
{
    public class RansomNote
    {
        private static Dictionary<string, int> LoadWords(string[] words)
        {
            var dictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dictionary.ContainsKey(word))
                    dictionary.Add(word, 1);
                else
                    dictionary[word]++;
            }

            return dictionary;
        }

        public static bool IsPossible(string[] magazine, string[] ransom)
        {
            var magazineDictionary = LoadWords(magazine);
            var ransomDictionary = LoadWords(ransom);

            return ransom.All(word => ransomDictionary[word] <= magazineDictionary[word]);
        }
    }
}
