using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Student_Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Input.txt");
            string[] oddLines = lines.Where((line, i) => i % 2 == 1).ToArray();
            File.WriteAllLines("output.txt", oddLines);
        }
    }
}
