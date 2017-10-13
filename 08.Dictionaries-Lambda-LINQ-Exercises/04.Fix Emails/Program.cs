using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var email = Console.ReadLine();

            var dict = new Dictionary<string, string>();
            while (name != "stop")
            {
                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                   
                }
                else
                {
                    dict[name] = email;
                }

                name = Console.ReadLine();
                email = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
