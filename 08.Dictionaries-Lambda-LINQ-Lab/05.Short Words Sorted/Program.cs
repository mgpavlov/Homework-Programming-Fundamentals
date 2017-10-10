using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var separator = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!',' ', '?'};
            var list = Console.ReadLine().ToLower().Split(separator).ToList();
            var orderedByWordLength = list.Where(w => w !="").Where(w => w.Length < 5).OrderBy(w => w).Distinct();
            Console.WriteLine(String.Join(", ", orderedByWordLength));
        }
    }
}
