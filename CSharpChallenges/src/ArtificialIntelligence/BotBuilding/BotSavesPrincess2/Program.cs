using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpChallenges
{
    /// <summary>
    /// Solution class for the Bot Saves Princess 2 challenge resulting in a score of 17.5 (max 17.5)
    /// </summary>
    public class BotSavesPrincess2
    {
        /// <summary>
        /// Main entry point for the solution to the BotSavePrincess2 challenge
        /// </summary>
        /// <param name="n">Number of Rows in the grid given by <paramref name="grid"/></param>
        /// <param name="r">Bot row index</param>
        /// <param name="c">Bot column index</param>
        /// <param name="grid">Character grid</param>
        public void NextMoveToPrincess(int n, int r, int c, String[] grid)
        {
            Tuple<int, int> Princess = Find('p', n, grid);
            Tuple<int, int> Bot      = new Tuple<int, int>(r, c);

            // Check if bot and princess are on the same row
            int row = Princess.Item1 - Bot.Item1;
            if(row == 0)
            {
                // We are in the same row, now find the column that the princess is in compared to the bot
                int column = Princess.Item2 - Bot.Item2;
                if(column > 0)
                {
                    Console.WriteLine("RIGHT");
                }
                else if(column < 0)
                {
                    Console.WriteLine("LEFT");
                }
            }
            else if(row > 0)
            {
                Console.WriteLine("DOWN");
            }
            else
            {
                Console.WriteLine("UP");
            }
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
    }

    /// <summary>
    /// Console application entry point taken from HackerRank sample code
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            String pos;
            pos = Console.ReadLine();
            String[] position = pos.Split(' ');
            int[] int_pos = new int[2];
            int_pos[0] = Convert.ToInt32(position[0]);
            int_pos[1] = Convert.ToInt32(position[1]);
            String[] grid = new String[n];
            for(int i = 0; i < n; i++)
            {
                grid[i] = Console.ReadLine();
            }

            BotSavesPrincess2 bot = new BotSavesPrincess2();
            bot.NextMoveToPrincess(n, int_pos[0], int_pos[1], grid);
        }
    }
}
