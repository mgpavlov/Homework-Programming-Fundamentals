using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var first = input[0].ToCharArray().ToList();
            var fir = input[0];
            var second = input[1].ToCharArray().ToList();
            var sec = input[1];
            var maxLength = Math.Max(first.Count, second.Count);
            var minLength = Math.Min(first.Count, second.Count);
        


            var temp = new Dictionary<char, char>();

            for (int i = 0; i < minLength; i++)
            {
                if (!temp.Keys.Contains(first[i]))
                {
                    temp.Add(first[i], second[i]);
                }
                else
                {
                    if (temp[first[i]] != second[i])
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    temp[first[i]] = second[i];
                    first[i] = second[i];
                }
            }

            if (fir.Length > sec.Length)
            {
                var substring = fir.Substring(sec.Length).ToCharArray();
                var sub = fir.Substring(0, sec.Length).ToCharArray();
                for (int i = 0; i < substring.Length; i++)
                {
                    if (!sub.Contains(substring[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }
            else if (fir.Length < sec.Length)
            {
                var substring = sec.Substring(fir.Length).ToCharArray();
                var sub = sec.Substring(0, fir.Length).ToCharArray();
                for (int i = 0; i < substring.Length; i++)
                {
                    if (!sub.Contains(substring[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }

            Console.WriteLine("true");

        }
    }
}