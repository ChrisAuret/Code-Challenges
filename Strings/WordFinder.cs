using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class WordFinder
    {
        static int CountOptiverOccurrences(List<string> words)
        {
            var horizontalCount = CountHorizontal(words);
            var verticalCount = CountVertical(words);

            return horizontalCount + verticalCount;
        }

        static int CountHorizontal(List<string> words)
        {
            var count = 0;

            foreach (var word in words)
            {
                // Forwards
                if (word.ToLower().Contains("optiver"))
                {
                    count++;
                    continue;
                }

                // Backwards
                char[] charArray = word.ToLower().ToCharArray();
                Array.Reverse(charArray);
                var reversed = new string(charArray);

                if (reversed.Contains("optiver"))
                {
                    count++;
                }
            }

            return count;
        }

        static int CountVertical(List<string> words)
        {
            var horizontal = new List<string>();

            var count = 0;

            // build char array from each letter in the columns represented by the index j
            var i = 0;

            for (var j = 0; j < words[0].Length; j++)
            {
                var column = new char[words.Count];

                foreach (var word in words)
                {
                    column[i] = word[j];
                    i++;
                }

                var columnString = new string(column);

                horizontal.Add(columnString);

                i = 0;
            }

            // since I have build, in effect, a regular horizonal char array, just pass it off to the earlier method.
            return CountHorizontal(horizontal);
        }
    }
}

//var words = new List<string>
//    {
//        "OPTIVER",
//        "REVITPO",
//        "PURHFNA",
//        "TJDUQKP",
//        "IJDUASD",
//        "VOPTIVE",
//        "EOPTIVE",
//        "RABREDS"


//        "PFOQKQO",
//        "BJAUDKP",
//        "DJDUAQT",
//        "PFJDNQI",
//        "OFFNQOV",
//        "URYQEOE",
//        "DQOFBOR"


//    "OPTIVER",
//        "PURHFNA",
//        "TJDUQKP",
//        "IJDUASD",
//        "VOPTIVE",
//        "EOPTIVE",
//        "RABREDS",
//    };