using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var baseN = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            var remindersList = new List<string>();
            while (number > 0)
            {
                var reminder = number % baseN;
                number = number / baseN;
                remindersList.Add(reminder.ToString());
            }
            string print = "";

            for (int i = remindersList.Count - 1; i >= 0; i--)
            {
                print += remindersList[i];
            }
            Console.WriteLine(print);
        }
    }
}