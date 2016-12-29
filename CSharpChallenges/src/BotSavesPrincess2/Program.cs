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

            // Check if bot and princess are on the same rank
            int rank = Princess.Item1 - Bot.Item1;
            if(rank == 0)
            {
                int file = Princess.Item2 - Bot.Item2;
                if(file > 0)
                {
                    Console.WriteLine("RIGHT");
                }
                else if(file < 0)
                {
                    Console.WriteLine("LEFT");
                }
            }
            else if(rank > 0)
            {
                Console.WriteLine("DOWN");
            }
            else
            {
                Console.WriteLine("UP");
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
