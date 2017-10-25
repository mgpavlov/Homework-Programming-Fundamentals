using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();

            
            while (true)
            {
                var startIndex = input.IndexOf(pattern);
                var lastIndex = input.LastIndexOf(pattern);

                var isStartIndexExist = startIndex != -1;
                var isLastIndexExist = lastIndex != -1;
                var isIndexAreNotequal = startIndex != lastIndex;
                var isPatternEmpty = pattern.Length > 0;
                if (isIndexAreNotequal && isLastIndexExist && isStartIndexExist&& isPatternEmpty)
                {
                    input = input.Remove(lastIndex, pattern.Length);
                    input = input.Remove(startIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
            
        }
    }
}
