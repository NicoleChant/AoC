using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class SolutionPartI
    {
        static readonly string textFile = @"Day3/input.txt";

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


    internal class SolutionPartII
    {
      static readonly string textFile = @"Day3/input.txt";

      public int calculateRating(string[] lines, bool mostCommon){
        int index;
        int count;
        double rating = 0.0;
        char winningSymbol;
        int totalNewLines;
        int zeroCounts;

        HashSet<string> filterLines = new HashSet<string>();

        foreach(string line in lines){
          filterLines.Add(line);
        }

        int totalLines = lines.Length;
        index = 0;

        while(filterLines.Count() > 1){
          count = 0;
          zeroCounts = 0;
          totalNewLines = 0;

          for(int i=0; i<totalLines; ++i){
            if(!filterLines.Contains(lines[i])) continue;
            if(lines[i][index] == '1') count++;
            totalNewLines++;
          }

          zeroCounts = totalNewLines - count;

          if(mostCommon){
            winningSymbol = count >= zeroCounts ? '1': '0';
          }
          else{
            winningSymbol = count >= zeroCounts ? '0': '1';
          }

          for(int i=0; i<totalLines; ++i){
            if(filterLines.Contains(lines[i]) && lines[i][index] != winningSymbol){
              filterLines.Remove(lines[i]);
            }
          }
          index++;
      }

          string survivor = filterLines.First().ToString();

          for(int i=0; i<survivor.Length; ++i){
            rating += Math.Pow(2, i) * ((double) survivor[survivor.Length - i - 1] - 48);
          }

          return (int) rating;
      }

      public int solve(){
        string[] lines = File.ReadAllLines(textFile);
        int oxygenRating = calculateRating(lines, true);
        Console.WriteLine($"Oxygen Rating: {oxygenRating}");

        int C02Rating = calculateRating(lines, false);
        Console.WriteLine($"C02Rating {C02Rating}.");

        int LifeSupportRating = C02Rating * oxygenRating;
        Console.WriteLine($"Life Support Rating: {LifeSupportRating}.");

      return LifeSupportRating;
    }

  }
}
