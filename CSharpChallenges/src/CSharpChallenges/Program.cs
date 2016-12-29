using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpChallenges
{
    public class BotSavesPrincess
    {
        public void SavePrincess(int n, string[] grid)
        {
            Tuple<int, int> Princess = Find('p', n, grid);
            Tuple<int, int> Bot      = Find('m', n, grid);

            // Move bot to the correct rank
            MoveBotToPrincess(Bot.Item1, Princess.Item1, new String[] { "UP", "DOWN" });
            // Move bot to the correct file
            MoveBotToPrincess(Bot.Item2, Princess.Item2, new String[] { "LEFT", "RIGHT" });
        }

        private Tuple<int, int> Find(char c, int n, string[] grid)
        {
            int rank = 0, file = 0;
            for(rank = 0; rank < n; ++rank)
            {
                if(grid[rank].Contains(c))
                {
                    file = grid[rank].IndexOf(c);
                    break;
                }
            }
            return new Tuple<int, int>(rank, file);
        }

        private void MoveBotToPrincess(int botIndex, int targetIndex, string[] direction)
        {
            while(botIndex != targetIndex)
            {
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

            Console.Read();
        }
    }
}
