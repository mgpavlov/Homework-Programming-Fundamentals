using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().TrimStart(new char[] { '0' }).ToList();
            var second = Console.ReadLine().TrimStart(new char[] { '0' }).ToList();
            var shorter = first.Count > second.Count ? second : first;
            var longer = first.Count > second.Count ? first : second;
            var temp = new char[longer.Count];
            
            var reminder = 0;
            var addIndex = 0;
            var list = new int[longer.Count];
            for (int i = longer.Count-shorter.Count; i < longer.Count; i++)
            {
                temp[i] = shorter[addIndex];
                addIndex++;
            }
            for (int i = 0; i < longer.Count - shorter.Count; i++)
            {
                temp[i] = '0';
            }

            for (int i = longer.Count-1; i >= 0; i--)
            {
                var a = (int)Char.GetNumericValue(longer[i]);
                var b = (int)Char.GetNumericValue(temp[i]);
                var c = (a + b+reminder);
                list[i] = c % 10;
                reminder = c / 10;
            }
            var print = list.ToList();
            if (reminder>0)
            {
                print.Insert(0, reminder);
            }
            Console.WriteLine(String.Join("",print));
        }
    }
}
