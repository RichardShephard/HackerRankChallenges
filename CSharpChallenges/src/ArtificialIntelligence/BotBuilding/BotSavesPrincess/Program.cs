using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpChallenges
{
    /// <summary>
    /// Solution class for the Bot Saves Princess challenge resulting in a score of 13.9 (max 13.9)
    /// </summary>
    public class BotSavesPrincess
    {
        /// <summary>
        /// Main entry point for the BotSavesPrincess challenge. This moves the bot on the row first and the moves to the correct column.
        /// </summary>
        /// <param name="n">Number of Rows in the grid given by <paramref name="grid"/></param>
        /// <param name="grid">Character grid</param>
        public void SavePrincess(int n, string[] grid)
        {
            // Find the position of the bot and the princess
            Tuple<int, int> Princess = Find('p', n, grid);
            Tuple<int, int> Bot      = Find('m', n, grid);

            // Move bot to the correct row
            MoveBotToPrincess(Bot.Item1, Princess.Item1, new String[] { "UP", "DOWN" });
            // Move bot to the correct column
            MoveBotToPrincess(Bot.Item2, Princess.Item2, new String[] { "LEFT", "RIGHT" });
        }

        /// <summary>
        /// Attempts to find character <paramref name="c"/> in the given grid
        /// </summary>
        /// <param name="c">Character to find</param>
        /// <param name="n">Number of Rows in the grid given by <paramref name="grid"/></param>
        /// <param name="grid">Character grid to search for <paramref name="c"/></param>
        /// <returns>A tuple of the format (row, column)</returns>
        private Tuple<int, int> Find(char c, int n, string[] grid)
        {
            int row = 0, column = 0;
            for(row = 0; row < n; ++row)
            {
                // If we found the character IndexOf will return the index of it and we can exit
                if((column = grid[row].IndexOf(c)) != -1)
                {
                    break;
                }
            }
            return new Tuple<int, int>(row, column);
        }

        /// <summary>
        /// Prints out the direction(s) that the bot needs to take in order to move to the princess. The directions the bot moves is given by the <paramref name="direction"/>
        /// </summary>
        /// <param name="botIndex">Bot starting position</param>
        /// <param name="targetIndex">Bot target index</param>
        /// <param name="direction">Text to print when moving the bot in a given direction from <paramref name="botIndex"/> to <paramref name="targetIndex"/></param>
        private void MoveBotToPrincess(int botIndex, int targetIndex, string[] direction)
        {
            while(botIndex != targetIndex)
            {
                // Move the bot in the direction to the target until the bot reaches the target index
                if(botIndex > targetIndex)
                {
                    --botIndex;
                    Console.WriteLine(direction[0]);
                }
                else
                {
                    ++botIndex;
                    Console.WriteLine(direction[1]);
                }
            }
        }
    }

    /// <summary>
    /// Console application entry point taken from HackerRank sample code
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            int m;

            m = int.Parse(Console.ReadLine());

            String[] grid = new String[m];
            for(int i = 0; i < m; i++)
            {
                grid[i] = Console.ReadLine();
            }

            BotSavesPrincess bot = new BotSavesPrincess();
            bot.SavePrincess(m, grid);
        }
    }
}
