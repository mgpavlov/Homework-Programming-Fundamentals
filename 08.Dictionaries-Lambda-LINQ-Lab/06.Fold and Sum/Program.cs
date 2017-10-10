using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            var k = list.Count()/4;
            var leftList = list.Take(k).Reverse().ToList();
            var rightList = list.Skip(3*k).Take(k).Reverse().ToList();

            var middleList = list.Skip(k).Take(2 * k).ToList();
            var leftRightList = leftList.Concat(rightList).ToList();

            int[] newList = new int [2*k];

            for (int i = 0; i < 2*k; i++)
            {
                newList[i] = middleList[i] + leftRightList[i];
            }
            Console.WriteLine(String.Join(" ",newList));
        }
    }
}
