using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Drago
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dragonsTypeNameList = new Dictionary<string, SortedDictionary<string, List<double>>>();
           

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var tokens = line.Split().ToArray();

                var type = tokens[0];
                var name = tokens[1];

                var damege = 45.00;
                var health = 250.00;
                var armor = 10.00;
                if (tokens[2] != "null")
                {
                    damege = double.Parse(tokens[2]);
                }
                if (tokens[3] != "null")
                {
                    health = double.Parse(tokens[3]);
                }
                if (tokens[4] != "null")
                {
                    armor = double.Parse(tokens[4]);
                }

                var list = new List<double> { damege, health, armor };
                if (!dragonsTypeNameList.ContainsKey(type))
                {
                    var dragonNameList = new SortedDictionary<string, List<double>>();
                    dragonNameList.Add(name, list);
                    dragonsTypeNameList.Add(type, dragonNameList);
                }
                else
                {
                    if (!dragonsTypeNameList[type].ContainsKey(name))
                    {
                        dragonsTypeNameList[type].Add(name, list);
                    }
                    dragonsTypeNameList[type][name] = list;
                }
            }
            foreach (var typeOfDragon in dragonsTypeNameList)
            {
                int count = 0;
                double sumeDamage = 0.00;
                double sumeHealth = 0.00;
                double sumeArmor = 0.00;
                
                foreach (var dragonName in typeOfDragon.Value)
                {
                    sumeDamage += dragonName.Value[0];
                    sumeHealth += dragonName.Value[1];
                    sumeArmor += dragonName.Value[2];
                    count++;
                }
                double avarageDamage = sumeDamage/count;
                double avarageHealth = sumeHealth/count;
                double avarageArmor = sumeArmor/count;

                Console.WriteLine($"{typeOfDragon.Key}::({avarageDamage:f2}/{avarageHealth:f2}/{avarageArmor:f2})");

                foreach (var dragonName in typeOfDragon.Value)
                {
                    Console.WriteLine($"-{dragonName.Key} -> damage: {dragonName.Value[0]}, health: {dragonName.Value[1]}, armor: {dragonName.Value[2]}");
                }
            }
        }
    }
}
