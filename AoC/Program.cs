using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to C# Edition Advent of Code!");


        int solution = new Day3.SolutionPartI().solve();
        // int solution2 = new Day3.SolutionPartII().solve();
           
        Console.WriteLine($"PartI: Total Increments {solution}");
        // Console.WriteLine($"PartII: Total Increments {solution2}");
    }

}