using System;
using System.IO;
using System.Linq;

namespace DayI {

    internal class SolutionPartI
    {

        static readonly string textFile = "C:\\Users\\30697\\source\\repos\\AoC\\AoC\\Day1\\input.txt";

        public int solve()
        {
            if (File.Exists(textFile))
            {
                // Read a text file line by line.
                string[] rawLines = File.ReadAllLines(textFile);
                int[] lines = Array.ConvertAll(rawLines, s => int.Parse(s));
                int totalIncrements = 0;
                int previousLine = lines[0];

                // Time Complexity: O(N) , N = lines.Length();
                for (int i = 1; i < lines.Length; ++i)
                {
                    if (previousLine < lines[i])
                    {
                        totalIncrements++;
                    }
                    previousLine = lines[i];
                }
                return totalIncrements;

            }

            return -1;
        }

    }


    public class SolutionPartII
    {

        static readonly string textFile = "C:\\Users\\30697\\source\\repos\\AoC\\AoC\\input.txt";

        public int solve() {

            string[] rawLines = File.ReadAllLines(textFile);
            int[] lines = Array.ConvertAll(rawLines, s => int.Parse(s));
            int totalIncrements = 0;

            // Time Complexity: O(N-3)=O(N), N = lines.Length();
            for (int i = 0; i < lines.Length-3; ++i)
            {
                totalIncrements += lines[i] < lines[i + 3] ? 1: 0;
            }
            return totalIncrements;

        }
    }
}
