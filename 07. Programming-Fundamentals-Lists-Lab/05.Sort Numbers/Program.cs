using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfIntegres = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            //listOfIntegres.Sort();
            for (int i = 0; i < listOfIntegres.Count-1; i++)
            {
                if (listOfIntegres[i] >= listOfIntegres[i + 1])
                {
                    Console.Write($"{listOfIntegres[i+1]} <= {listOfIntegres[i]}");
                }
                else
                {
                    Console.Write($"{listOfIntegres[i]} <= {listOfIntegres[i+1]}");
                }
            }
            //Console.WriteLine(String.Join(" <= ", listOfIntegres));
        }
    }
}
