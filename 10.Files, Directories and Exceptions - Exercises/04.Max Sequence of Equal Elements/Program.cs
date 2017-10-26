using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Max_Sequence_of_Equal_Elements
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

            File.WriteAllText(inputFilePath, "7 7 4 4 5 5 3 3");
            var input = File.ReadAllText(inputFilePath);


            int[] arr = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int endIndex = 0;
            int length = 1;

            int tempIndex = 0;
            int tempLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
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
            for (int j = endIndex + 1 - length; j <= endIndex; j++)
            {
                File.AppendAllText(outputFilePath, arr[j] + " ");
            }
        }
    }
}
