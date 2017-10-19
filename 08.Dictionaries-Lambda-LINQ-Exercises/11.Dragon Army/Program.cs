using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dragonsList = new List<Dragon>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                Dragon dragon = CreateDragon(input);
                dragonsList.Add(dragon);
            }

            foreach (var typesDragon in dragonsList.Select(d => d.Type).Distinct().ToList())
            {
                var avarageDamage = dragonsList.Where(d => d.Type == typesDragon).Average(e => e.Damage);
                var avarageHealth = dragonsList.Where(d => d.Type == typesDragon).Average(e => e.Health);
                var avarageArmor = dragonsList.Where(d => d.Type == typesDragon).Average(e => e.Armor);
                Console.WriteLine($"{typesDragon}::({avarageDamage:f2}/{avarageHealth:f2}/{avarageArmor:f2})");

                foreach (var drago in dragonsList.Where(d => d.Type == typesDragon).OrderBy(e => e.Name))
                {
                    Console.WriteLine($"-{drago.Name} -> damage: {drago.Damage}, health: {drago.Health}, armor: {drago.Armor}");
                }
            }
        }

        public static Dragon CreateDragon(string[] input)
        {
            Dragon dragon = new Dragon();
            dragon.Type = input[0];
            dragon.Name = input[1];

            if (input[2] == "null")
            {
                dragon.Damage = 45;
            }
            else
            {
                dragon.Damage = int.Parse(input[2]);
            }
            if (input[3] == "null")
            {
                dragon.Health = 250;
            }
            else
            {
                dragon.Health = int.Parse(input[3]);
            }
            if (input[4] == "null")
            {
                dragon.Armor = 10;
            }
            else
            {
                dragon.Armor = int.Parse(input[4]);
            }
            return dragon;
        }
    }

    public class Dragon
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }

}
