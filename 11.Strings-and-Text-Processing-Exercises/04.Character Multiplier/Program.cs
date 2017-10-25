using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var first = input[0].ToCharArray().ToList();
            var second = input[1].ToCharArray().ToList();
            var maxLength = Math.Max(first.Count, second.Count);
            var sum = 0;

            for (int i = 0; i <maxLength ; i++)
            {
                if (first.Count > second.Count)
                {
                    if (i >= second.Count)
                    {
                        second.Add((char)1);
                    }
                }
                else if (first.Count < second.Count)
                {
                    if (i >= first.Count)
                    {
                        first.Add((char)1);
                    }
                }
                sum += (int)first[i] * (int)second[i];
            }

            Console.WriteLine(sum);
        }
    }
}
