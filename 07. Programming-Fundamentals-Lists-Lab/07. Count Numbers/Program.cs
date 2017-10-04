using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            listOfIntegers.Sort();
            int counter = 1;

            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                if (i < listOfIntegers.Count - 1 && listOfIntegers[i] == listOfIntegers[i + 1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{listOfIntegers[i]} -> {counter}");
                    counter = 1;
                }
            }
        }
    }
}
