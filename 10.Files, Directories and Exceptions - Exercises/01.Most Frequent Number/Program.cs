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
            string outputFilePath = "../../output.txt";

            if (!File.Exists(inputFilePath))
            {
                File.Create(inputFilePath);
            }
            if (!File.Exists(outputFilePath))
            {
                File.Create(outputFilePath);
            }

            File.WriteAllText(inputFilePath, "2 2 2 2 1 2 2 2");

            var input = File.ReadAllText(inputFilePath);
            //string [] input = File.ReadAllLines(inputFilePath);
            //for (int i = 0; i < input.Length; i++)
            //{

            //}
            long[] arr = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            long endIndex = 0;
            long length = 1;

            long tempIndex = 0;
            long tempLength = 1;

            for (long j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[j] == arr[i])
                    {
                        tempIndex = i;
                        tempLength++;
                        if (tempLength > length)
                        {
                            length = tempLength;
                            endIndex = tempIndex;
                        }
                    }
                    else
                    {
                        tempLength = 1;
                    }
                }
            }

            File.WriteAllText("../../output.txt", arr[endIndex].ToString());
        }
    }
}
