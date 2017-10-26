using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Most_Frequent_Number
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
            File.WriteAllText(inputFilePath, "4 1 1 4 2 3 4 4 1 2 4 9 3");
            var input = File.ReadAllText(inputFilePath);
            //string [] input = File.ReadAllLines(inputFilePath);
            //for (int i = 0; i < input.Length; i++)
            //{

            //}
        }
    }
}
