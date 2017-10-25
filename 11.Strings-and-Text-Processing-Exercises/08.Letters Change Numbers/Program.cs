using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            decimal sum = 0;
            foreach (var str in input)
            {
                var strr = str.ToCharArray();
                decimal num = decimal.Parse(str.Remove(str.Length - 1).Remove(0, 1));

                if (strr[0] >= 'A' && str[0] <= 'Z')
                {
                    num = num / (strr[0] - 64);
                }
                else if (strr[0] >= 'a' && str[0] <= 'z')
                {
                    num = num * (strr[0] - 96);
                }

                if (strr[strr.Length - 1] >= 'A' && str[strr.Length - 1] <= 'Z')
                {
                    num = num - (strr[strr.Length - 1] - 64);
                }
                else if (strr[strr.Length - 1] >= 'a' && str[strr.Length - 1] <= 'z')
                {
                    num = num + (strr[strr.Length - 1] - 96);
                }
                sum += num;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
