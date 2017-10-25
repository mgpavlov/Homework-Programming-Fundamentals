using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Convert_from_Base_N_to_Base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var baseN = int.Parse(input[0]);
            var number = input[1].ToCharArray();
            BigInteger numberIn10 = 0;
            var power = 0;

            for (int i = number.Length-1; i >= 0; i--)
            {
                numberIn10 += BigInteger.Parse(number[i].ToString()) * BigInteger.Pow(baseN, power);
                power++;
            }

            Console.WriteLine(numberIn10);
        }
    }
}
