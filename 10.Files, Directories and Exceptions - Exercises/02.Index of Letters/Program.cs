using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string inputFilePath = "../../input.txt";
            string outputFilePath = "../../output.txt";
            File.WriteAllText(outputFilePath, "");

            if (!File.Exists(inputFilePath))
            {
                File.Create(inputFilePath);
            }
            if (!File.Exists(outputFilePath))
            {
                File.Create(outputFilePath);
            }

            File.WriteAllText(inputFilePath, "softuni");
            var input = File.ReadAllText(inputFilePath);

            char[] alphabet = input.ToCharArray();

            for (int i = 0; i < alphabet.Length; i++)
            {
                File.AppendAllText(outputFilePath, $"{alphabet[i]} -> {alphabet[i] - 'a'}");
                File.AppendAllText(outputFilePath, Environment.NewLine);
            }

        }
    }
}
