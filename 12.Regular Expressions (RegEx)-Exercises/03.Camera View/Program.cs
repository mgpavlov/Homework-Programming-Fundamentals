using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split();
            var text = Console.ReadLine();
            var m = int.Parse(elements[0]);
            var n = int.Parse(elements[1]);

            var pattern = @"(?<=\|<[^|<]{"+m+"})([^|<]{0,"+n+"})";
            var listOfMatches = new List<string>();
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (var match in matches)
            {
                
                listOfMatches.Add(match.ToString());
            }
            Console.WriteLine(String.Join(", ", listOfMatches));
        }
    }
}
