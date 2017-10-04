using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < list.Count - 1; i++)
            {

                if (list[i] == list[i + 1])
                {
                    list.RemoveAt(i + 1);
                    list[i] *= 2;
                    for (int j = 0; j < list.Count - 1; j++)
                    {
                        if (list[j] == list[j + 1])
                        {
                            list.RemoveAt(j + 1);
                            list[j] *= 2;
                            break;
                        }
                        i = 0;
                        break;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
