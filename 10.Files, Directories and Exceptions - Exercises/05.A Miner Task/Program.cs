using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("../../input.txt");
            File.Delete("../../output.txt");

            var dict = new Dictionary<string, string>();
            for (int i = 0; i < lines.Length; i += 2)
            {
                if (lines[i] == "stop" || lines[i + 1] == "stop")
                {
                    break;
                }
                var resource = lines[i];
                var quantity = lines[i + 1];


                if (dict.ContainsKey(resource))
                {
                    var temp = int.Parse(dict[resource]) + int.Parse(quantity);
                    dict[resource] = temp.ToString();
                }
                else
                {
                    dict[resource] = quantity;
                }
            }
                foreach (var item in dict)
                {
                   File.AppendAllText("../../output.txt", ($"{item.Key} -> {item.Value}" + Environment.NewLine));
                }
            //var output = $"{name} -> {email}" + Environment.NewLine;
            //File.AppendAllText("output.txt", output);
        }
    }
}
