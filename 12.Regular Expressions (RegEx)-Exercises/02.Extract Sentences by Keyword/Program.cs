using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();
            var pattern = @"\b[^?!.]+\bto\b.*?[!?.]";
            MatchCollection results = Regex.Matches(text, pattern);

            foreach (var result in results)
            {
                    Console.WriteLine(result);
            }
        }
    }
}
