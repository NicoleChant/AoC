using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class SolutionPartI
    {
        static readonly string textFile = @"C:\Users\30697\source\repos\AoC\AoC\Day3\input.txt";
        public int solve()
        {
            int length = 12;

            // generator
            var lines = File.ReadLines(textFile);
            int[] sumDigits = new int[length];
            int gammaRate;
            double gammaDecimal = 0;
            double epsilonDecimal = 0;
            int total = 0;

            // Time Complexity: O(Nx12) = O(N)
            foreach (string line in lines)
            {
                total++;
                for(int i=0; i<length; ++i)
                {
                    sumDigits[i] += line[i] - '0';
                }
                
            }

            for(int i=0; i<length; ++i)
            {
                gammaRate = sumDigits[i] > total / 2 ? 1 : 0;  

                gammaDecimal += gammaRate * Math.Pow(2, length-1-i);
                epsilonDecimal += ( 1 - gammaRate ) * Math.Pow(2, length-1-i);
            }

            return (int)(gammaDecimal * epsilonDecimal);
        }
    }
}
