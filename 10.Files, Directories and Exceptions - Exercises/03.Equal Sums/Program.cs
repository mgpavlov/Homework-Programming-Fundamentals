using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = "../../input.txt";
            if (!File.Exists(inputFilePath))
            {
                File.Create(inputFilePath);
            }
            File.WriteAllText(inputFilePath, "10 5 5 99 3 4 2 5 1 1 4");
            var input = File.ReadAllText(inputFilePath);
            //string [] input = File.ReadAllLines(inputFilePath);
            //for (int i = 0; i < input.Length; i++)
            //{

            //}
        }
    }
}
