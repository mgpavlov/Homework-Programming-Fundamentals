using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = Console.ReadLine()
                .Split("\t\\ \\/\\(\\)".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            var pattern = @"^[a-zA-Z][a-zA-Z0-9_]{2,24}$";

            var list = new List<string>();
            foreach (var item in text)
            {
                var isMatch = Regex.IsMatch(item, pattern);
                if (isMatch)
                {
                    list.Add(item);

                }
            }

            var temp = 0;
            var print1 = "";
            var print2 = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (i + 1 <= list.Count - 1)
                {
                    var sum = list[i].Length + list[i + 1].Length;

                    if (sum > temp)
                    {
                        temp = sum;
                        print1 = list[i].ToString();
                        print2 = list[i + 1].ToString();
                    }
                }
            }

            Console.WriteLine(print1);
            Console.WriteLine(print2);
        }
    }
}
