using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_projects
{
    class Program
    {
        class Team
        {
            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var teamList = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                var inputCreatorTeam = Console.ReadLine();
                var tokens = inputCreatorTeam.Split('-');
                var creatorName = tokens[0];
                var teamName = tokens[1];

                var membersList = new List<string>();
                Team team = new Team();
                team.Name = teamName;
                team.Creator = creatorName;
                team.Members = membersList;

                if (!teamList.Select(x => x.Name).Contains(team.Name))
                {
                    if (!teamList.Select(x => x.Creator).Contains(team.Creator))
                    {
                        teamList.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creatorName} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            var inputUsersTeam = Console.ReadLine();

            while (inputUsersTeam != "end of assignment")
            {
                var tokenss = inputUsersTeam.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var userName = tokenss[0];
                var teamName = tokenss[1];
                if (!teamList.Select(x => x.Name).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teamList.Select(x => x.Members).Any(x=>x.Contains(userName)) || teamList.Select(x => x.Creator).Contains(userName))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                }
                else
                {
                    int teamToJoinIndex = teamList.FindIndex(x => x.Name == teamName);
                    teamList[teamToJoinIndex].Members.Add(userName);
                }

                inputUsersTeam = Console.ReadLine();
            }

            var printTeams = teamList.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).Where(x => x.Members.Count > 0);
            foreach (var team in printTeams)
            {
                team.Members.Sort();
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                Console.WriteLine($"-- {String.Join("\r\n-- ", team.Members)}");
            }

            var teamDisbandList = teamList.OrderBy(x => x.Name).Where(x => x.Members.Count == 0);
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamDisbandList)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
