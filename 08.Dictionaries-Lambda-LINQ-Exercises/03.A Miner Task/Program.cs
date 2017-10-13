using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resource = Console.ReadLine();
            var quantity = Console.ReadLine();

            var dict = new Dictionary<string, string>();
            while (resource != "stop")
            {
                if (dict.ContainsKey(resource))
                {
                    var temp = int.Parse(dict[resource]) + int.Parse(quantity);
                    dict[resource] = temp.ToString();
                }
                else
                {
                    dict[resource] = quantity;
                }
                
                resource = Console.ReadLine();
                quantity = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
