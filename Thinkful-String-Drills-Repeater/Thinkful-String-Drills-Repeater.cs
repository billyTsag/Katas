public class Kata
{
  public static string Repeater(string s, int n)
  {
      string result = "";
      for (int i = 0; i < n; i++)
      {
          result += s;
      }
      return result;
  }
}