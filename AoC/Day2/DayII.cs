using System;
using System.Linq;
using System.IO;


namespace Day2
{
    internal class SolutionPartI
    {

        static readonly string textFile = "C:\\Users\\30697\\source\\repos\\AoC\\AoC\\Day2\\input.txt";

        public int solve()
        {
            var lines = File.ReadLines(textFile);
            var splittedLines = lines.Select(line => line.Split(" ")).ToList();

            int horizontalDisplacement = 0;
            int depthDisplacement = 0;
            foreach (var line in splittedLines)
            {
                // Console.WriteLine($"{line.First()} {line.Skip(1).First()}");
                switch (line.First())
                {
                    case "forward":
                        horizontalDisplacement += int.Parse(line.Skip(1).First()); break;
                    case "up":
                        depthDisplacement -= int.Parse(line.Skip(1).First()); break;
                    case "down":
                        depthDisplacement += int.Parse(line.Skip(1).First()); break;
                }

                // Console.WriteLine($"{horizontalDisplacement}, {depthDisplacement}");
            }

            return horizontalDisplacement * depthDisplacement;

        }
    }

    public class SolutionPartII
    {

        static readonly string textFile = "C:\\Users\\30697\\source\\repos\\AoC\\AoC\\Day2\\input.txt";

        public int solve()
        {
            var lines = File.ReadLines(textFile);
            var splittedLines = lines.Select(line => line.Split(" ")).ToList();

            int horizontalDisplacement = 0;
            int depthDisplacement = 0;
            int aim = 0;
            foreach (var line in splittedLines)
            {
                int increment = int.Parse(line.Skip(1).First());
                switch (line.First())
                {
                    case "forward":
                        horizontalDisplacement += increment;
                        depthDisplacement += aim*increment;
                        break;
                    case "up":
                        // depthDisplacement -= increment;
                        aim -= increment;
                        break;
                    case "down":
                        // Some mistakes I did here!
                        // depthDisplacement += increment;
                        aim += increment;
                        break;
                }

            }

            return horizontalDisplacement * depthDisplacement;

        }
    }

}