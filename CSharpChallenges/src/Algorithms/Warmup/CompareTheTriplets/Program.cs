using System;
using System.Linq;

namespace CSharpChallenges
{
    /// <summary>
    /// Solution class for the Compare the Triplets challenge resulting in a score of 10 (max 10)
    /// </summary>
    public class CompareTheTriplets
    {
        /// <summary>
        /// Main entry point for the challenge to compare the numbers of Alice and Bob
        /// </summary>
        /// <param name="A">Alice's numbers</param>
        /// <param name="B">Bob's numbers</param>
        public void Compare(int [] A, int[] B)
        {
            int aliceScore = 0, bobScore = 0;
            for(int i = 0; i < A.Count(); ++i)
            {
                aliceScore += A[i] > B[i] ? 1 : 0;
                bobScore   += A[i] < B[i] ? 1 : 0;
            }

            Console.Write($"{aliceScore} {bobScore}");
        }
    }

    public class Program
    {
        /// <summary>
        /// Console application entry point taken from HackerRank sample code
        /// </summary>
        public static void Main(string[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            CompareTheTriplets compare = new CompareTheTriplets();
            compare.Compare(new[] { a0, a1, a2 }, new[] { b0, b1, b2 });
        }
    }
}
