using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            listOfIntegers.Sort();

            listOfIntegers.Reverse();

            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                if (Math.Sqrt(listOfIntegers[i])==(int)Math.Sqrt(listOfIntegers[i]))
                {
                    Console.WriteLine(listOfIntegers[i]+" ");
                }
            }
                   }
    }
}
