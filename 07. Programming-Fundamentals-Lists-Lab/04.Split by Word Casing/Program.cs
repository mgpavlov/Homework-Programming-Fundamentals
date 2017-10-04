using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = ",;:.!()\"'/\\[] ".ToCharArray();
            var stringList = Console.ReadLine().
                Split(separators
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToArray();
            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();

            foreach (var word in stringList)
            {
                int containsLower = 0;
                int containsUpper = 0;
                int containsSymbol = 0;

                foreach (var letter in word)
                {
                    if (!char.IsLetter(letter))
                    {
                        containsSymbol = 1;
                    }
                    else if (char.IsLower(letter))
                    {
                        containsLower = 1;
                    }
                    else if (char.IsUpper(letter))
                    {
                        containsUpper = 1;
                    }
                }
                if (containsSymbol == 1)
                {
                    mixedCase.Add(word);
                }
                else if (containsLower == 0)
                {
                    upperCase.Add(word);
                }
                else if (containsUpper == 0)
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine($"Lower-case: {String.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {String.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {String.Join(", ", upperCase)}");
        }
    }
}
