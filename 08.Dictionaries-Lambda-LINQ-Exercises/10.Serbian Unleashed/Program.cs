using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Serbian_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {

            var concertsInfo = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();
           

            while (input != "End")
            {
                List<string> splitedInfo = input.Split(new char[] { '@' }).ToList();
                
                string singer = splitedInfo[0];

                string venueAndtickets = splitedInfo[1];

                List<string> splitVenueAndTickets = venueAndtickets.Split(new char[] { ' ' }).ToList();

                int ticketsPrice;
                bool isCorrect = int.TryParse(splitVenueAndTickets[splitVenueAndTickets.Count - 2], out ticketsPrice);

                int ticketsCount;
                bool ticket = int.TryParse(splitVenueAndTickets.Last(), out ticketsCount);

                splitVenueAndTickets.RemoveRange(splitVenueAndTickets.Count - 2, 2);
                string venue = splitVenueAndTickets.;

                if (isCorrect && ticket && singer.Last() == ' ' && venue.Length <= 3 && singer.ToArray().Count() <= 4 )
                {
                    long totalMoney = ticketsPrice * ticketsCount;

                    if (!concertsInfo.ContainsKey(venue))
                    {
                        concertsInfo.Add(venue, new Dictionary<string, long>());
                    }

                    if (!concertsInfo[venue].ContainsKey(singer))
                    {
                        concertsInfo[venue].Add(singer, 0);
                    }

                    concertsInfo[venue][singer] += totalMoney;
                }
                input = Console.ReadLine();
            }

            foreach (var venue in concertsInfo)
            {
                Console.WriteLine($"{venue.Key}");

                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
                }
            }
        }
    }
}
