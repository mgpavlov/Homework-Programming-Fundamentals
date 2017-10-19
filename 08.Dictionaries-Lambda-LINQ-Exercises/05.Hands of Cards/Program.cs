using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine();
            var namesCards = new Dictionary<string, List<int>>();

            while (list != "JOKER")
            {
                var tokens = list.Split(':').ToArray();
                var name = tokens[0];

                var cards = tokens[1].ToString().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(a => CardsValue(a)).ToList();

                if (!namesCards.ContainsKey(name))
                {
                    namesCards[name] = new List<int>();
                }
                    namesCards[name].AddRange(cards);

                list = Console.ReadLine();
            }

            foreach (var nameCard in namesCards)
            {
                var kvp = nameCard.Value;
                var kvpDistinct = kvp.Distinct();

                var sum = kvpDistinct.Sum();
                Console.WriteLine($"{nameCard.Key}: {sum}");
            }
        }

        static int CardsValue(string card)
        {
            var cardPower = card.Substring(0, card.Length-1);
            var cardType = card.Substring(card.Length - 1);

            var cardPowerValue = new Dictionary<string, int>();
            cardPowerValue["J"] = 11;
            cardPowerValue["Q"] = 12;
            cardPowerValue["K"] = 13;
            cardPowerValue["A"] = 14;
            for (int i = 2; i < 11; i++)
            {
                cardPowerValue[i.ToString()] = i;
            }

            var cardTypeValue = new Dictionary<string, int>();
            cardTypeValue["S"] = 4;
            cardTypeValue["H"] = 3;
            cardTypeValue["D"] = 2;
            cardTypeValue["C"] = 1;

            var cardValue = new Dictionary<string, int>();
            cardValue[card] = cardPowerValue[cardPower]*cardTypeValue[cardType];

            var value = cardValue[card];
            return value;
        }
    }
}
