using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> gameChoices = new List<string> { "paper", "rock", "scissors" };

        Random rnd = new Random();
        int cpuChoice = rnd.Next(0, 3);

        decimal games = 0;
        decimal gamesWon = 0;
        int gamesLost = 0;
        int gamesDraw = 0;
        decimal percentWon = 0;

        int userChoice = -1;

        while (true)
        {
            cpuChoice = rnd.Next(0, 3);

            Console.WriteLine("\n[G:{0}] [W:{1}] [L:{2}] [D:{3}] [%{4:0.0}]", games,
                             gamesWon, gamesLost, gamesDraw, percentWon);

            Console.WriteLine("[paper, rock, or scissor?]");
            userChoice = gameChoices.IndexOf(Console.ReadLine());

            if (userChoice == -1)
            {
                Console.WriteLine("\nThat is not a valid choice!");
            }
            else
            {
                if (userChoice - cpuChoice == -1 || userChoice - cpuChoice == 2)
                {
                    Console.WriteLine("You won!");
                    gamesWon += 1;
                }
                if (userChoice - cpuChoice == -2 || userChoice - cpuChoice == 1)
                {
                    Console.WriteLine("You lose!");
                    gamesLost += 1;
                }
                if (userChoice - cpuChoice == 0)
                {
                    Console.WriteLine("Its a draw!");
                    gamesDraw += 1;
                }

                games += 1;

                percentWon = (gamesWon / games) * 100;
            }
        }
    }
}

