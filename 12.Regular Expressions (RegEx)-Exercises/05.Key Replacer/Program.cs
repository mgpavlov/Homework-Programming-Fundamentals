using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine().Split("|,<\\".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            var startKey = key[0];
            var endKey = key[key.Length - 1];

            var text = Console.ReadLine();
            var pattern = @"(?<=" + startKey + ").*?(?=" + endKey + ")";

            MatchCollection matches = Regex.Matches(text, pattern);
            if (!Regex.IsMatch(text, pattern))
            {
                Console.WriteLine("Empty result");
            }
            else
            {

                foreach (Match match in matches)
                {
                    if (matches.Count == 2 && match.Value == "")
                    {
                        Console.WriteLine("Empty result");
                        break;
                    }
                    Console.Write(match.Value);
                }
                Console.WriteLine();
            }
        }
    }
}
