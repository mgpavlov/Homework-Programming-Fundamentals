using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split().ToArray();
            var dict = new Dictionary<string, int>();

            foreach (var number in input)
            {
                if (dict.ContainsKey(number))
                {
                    dict[number]++;
                }
                else
                {
                    dict[number] = 1;
                }
            }

            var output = new List<string>();
            foreach (var pairs in dict)
            {
                if (pairs.Value%2==1)
                {
                    output.Add(pairs.Key);
                }
            }
            Console.WriteLine(String.Join(", ", output));
        }
    }
}
