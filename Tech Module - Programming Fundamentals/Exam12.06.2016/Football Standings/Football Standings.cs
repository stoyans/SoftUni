using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Standings
{
    class Program
    {
        static void Main()
        {
            string pattern = Console.ReadLine();
            string firstTeamExtract = string.Empty;
            string firstTeam = string.Empty;
            string secondTeamExtract = string.Empty;
            string secondTeam = string.Empty;
            SortedDictionary<string, int> league = new SortedDictionary<string, int>();
            SortedDictionary<string, int> topGoal = new SortedDictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "final")
                {
                    break;
                }

                int startFirstTeam = line.IndexOf(pattern) + pattern.Length;
                int endFirstTeam = line.IndexOf(" ");
                firstTeamExtract = line.Substring(startFirstTeam, endFirstTeam - startFirstTeam);
                firstTeam = firstTeamExtract.Substring(0, firstTeamExtract.IndexOf(pattern));
                firstTeam = GetName(firstTeam);

                secondTeamExtract = line.Substring(line.IndexOf(" "));
                secondTeam = secondTeamExtract.Substring(secondTeamExtract.IndexOf(pattern) + pattern.Length);
                secondTeam = secondTeam.Substring(0, secondTeam.IndexOf(pattern));
                secondTeam = GetName(secondTeam);

                int firstTeamScore = line[line.Length - 3] - 48;
                int secondTeamScore = line[line.Length - 1] - 48;

                if (!league.ContainsKey(firstTeam))
                {
                    league.Add(firstTeam, 0);
                    topGoal.Add(firstTeam, firstTeamScore);

                    if (firstTeamScore > secondTeamScore)
                    {
                        league[firstTeam] += 3;
                    }
                    if (firstTeamScore == secondTeamScore)
                    {
                        league[firstTeam] += 1;
                    }
                }
                else
                {
                    topGoal[firstTeam] += firstTeamScore;

                    if (firstTeamScore > secondTeamScore)
                    {
                        league[firstTeam] += 3;
                    }
                    if (firstTeamScore == secondTeamScore)
                    {
                        league[firstTeam] += 1;
                    }
                }
                if (!league.ContainsKey(secondTeam))
                {
                    topGoal.Add(secondTeam, secondTeamScore);
                    league.Add(secondTeam, 0);

                    if (firstTeamScore < secondTeamScore)
                    {
                        league[secondTeam] += 3;
                    }
                    if (firstTeamScore == secondTeamScore)
                    {
                        league[secondTeam] += 1;
                    }
                }
                else
                {
                    topGoal[secondTeam] += secondTeamScore;

                    if (firstTeamScore < secondTeamScore)
                    {
                        league[secondTeam] += 3;
                    }
                    if (firstTeamScore == secondTeamScore)
                    {
                        league[secondTeam] += 1;
                    }
                }

            }

            int count = 1;
            Console.WriteLine("League standings:");
            foreach (var pair in league.OrderByDescending(key => key.Value))
            {
                Console.WriteLine("{0}. {1} {2}", count, pair.Key, pair.Value);
                count++;
            }

            count = 1;
            Console.WriteLine("Top 3 scored goals:");
            foreach (var pair in topGoal.OrderByDescending(key => key.Value).Take(3))
            {
                Console.WriteLine("- {0} -> {1}", pair.Key, pair.Value);
            }
        }

        static string GetName(string reversedName)
        {
            char[] charArray = reversedName.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray).ToUpper();
 
        }
    }
}
