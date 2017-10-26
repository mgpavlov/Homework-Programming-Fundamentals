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
            string outputFilePath = "../../output.txt";

            if (!File.Exists(inputFilePath))
            {
                File.Create(inputFilePath);
            }
            if (!File.Exists(outputFilePath))
            {
                File.Create(outputFilePath);
            }

            File.WriteAllText(inputFilePath, "10 5 5 99 3 4 2 5 1 1 4");
            var input = File.ReadAllText(inputFilePath);

            //string [] input = File.ReadAllLines(inputFilePath);
            //for (int i = 0; i < input.Length; i++)
            //{

            //}
            int[] arr = input.Split(' ').Select(int.Parse).ToArray();

            int sumLeft = 0;
            int sumRight = 0;
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumLeft += arr[j];
                }
                for (int k = i + 1; k < arr.Length; k++)
                {
                    sumRight += arr[k];
                }
                if (sumLeft == sumRight)
                {
                    File.WriteAllText(outputFilePath, i.ToString());
                    temp = 1;
                }
                else
                {
                    sumLeft = 0;
                    sumRight = 0;
                }
            }
            if (temp == 0)
            {
                File.WriteAllText(outputFilePath, "no");

            }
        }
    }
}
