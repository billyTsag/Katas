using System.Linq;

public class Kata
{
  public static string TwoSort(string[] s)
        {
            string[] sortedArray = s.OrderBy(x => x).ToArray();
            string firstWord = sortedArray[0];
            string output = "";
            foreach (var character in firstWord)
            {
                if (character == firstWord[firstWord.Length -1])
                {
                    output += character;
                    break;
                }
                output += character + "***";
            }
            return output;
        }
}
