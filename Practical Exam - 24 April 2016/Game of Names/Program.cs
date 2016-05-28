using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Names
{
    class Game_of_Names
    {
        static void Main()
        {
            int numberOfPlayers = int.Parse(Console.ReadLine());
            int initialScore = 0;
            string playerName = String.Empty;
            int finalScore = int.MinValue;
            string winnerName = String.Empty;

            for (int i = 0; i < numberOfPlayers; i++)
            {
                playerName = Console.ReadLine();
                initialScore = int.Parse(Console.ReadLine());
                int currentScore = 0;
                int nameScore = 0;

                for (int charNumber = 0; charNumber < playerName.Length; charNumber++)
                {
                    if (playerName[charNumber] % 2 == 0)
                    {
                        nameScore += playerName[charNumber];
                    }
                    else
                    {
                        nameScore -= playerName[charNumber];
                    }
                }

                currentScore = initialScore + nameScore;

                if (currentScore > finalScore)
                {
                    finalScore = currentScore;
                    winnerName = playerName;
                }
            }

            Console.WriteLine("The winner is {0} - {1} points", winnerName, finalScore);

        }
    }
}
