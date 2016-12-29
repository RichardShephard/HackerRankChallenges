using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpChallenges
{
    public class BotSavesPrincess
    {
        public void NextMoveToPrincess(int n, int r, int c, String[] grid)
        {
            Tuple<int, int> Princess = Find('p', n, grid);
            Tuple<int, int> Bot      = new Tuple<int, int>(r, c);

            // Move bot to the correct rank
            if(!MoveBotToPrincess(Bot.Item1, Princess.Item1, new String[] { "UP", "DOWN" }))
            {
                // Move bot to the correct file
                MoveBotToPrincess(Bot.Item2, Princess.Item2, new String[] { "LEFT", "RIGHT" });
            }
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

        private bool MoveBotToPrincess(int botIndex, int targetIndex, string[] direction)
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
                return true;
            }
            return false;
        }
    }

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

            BotSavesPrincess bot = new BotSavesPrincess();
            bot.NextMoveToPrincess(n, int_pos[0], int_pos[1], grid);

            Console.Read();
        }
    }
}
