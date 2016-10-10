using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //"fcrxzwscanmligyxyvym" 
            //"jxwtrhvujlmrpdoqbisbwhmgpmeoke"

            //"fcrxzwscanmligyxyvym"
            //"jxwtrhvujlmrpdoqbisbwhmgpmeoke"

            //MakingAnagrams.FilterIntoAnagram("cdett", "abcccc");
            //MakingAnagrams.FilterIntoAnagram("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke");

            var a = "fcrxzwscanmligyxyvym";
            var b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";

            var total = MakingAnagramsBetter.NumberToRemove(a, b);

            Console.Write(total + "");
            Console.ReadLine();
        }
    }
}
