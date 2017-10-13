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
            var input = Console.ReadLine().Split(' ', ',', ':').Where(x => x!="").ToList();

            var cards = input.Skip(1);
            var cardsDict = new Dictionary<char, int>();
            foreach (var card in cards)
            {
                var cardType = card[0];
                var cardColour = card[0];
                cardsDict[cardType] = cardColour;
            }
            
        }
    }
}
