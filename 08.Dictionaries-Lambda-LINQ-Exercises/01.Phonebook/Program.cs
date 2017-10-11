using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split().ToList();
            var command = new Dictionary<string, string>();
            while (str[0] != "END")
            {
                if (str[0] == "A")
                {
                    foreach (var item in str)
                    {
                        command[str[1]] = str[2];
                    }
                }
                else if (str[0] == "S")
                {
                        if (command.ContainsKey(str[1]))
                        {
                            Console.WriteLine($"{str[1]} -> {command[str[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {str[1]} does not exist.");
                        }
                }
                str = Console.ReadLine().Split().ToList();
            }
        }
    }
}
