using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var output = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                output.Add(input);
            }
            Console.WriteLine("Sum = "+output.Sum());
            Console.WriteLine("Min = " + output.Min());
            Console.WriteLine("Max = " + output.Max());
            Console.WriteLine("Average = " + output.Average());
        }
    }
}
