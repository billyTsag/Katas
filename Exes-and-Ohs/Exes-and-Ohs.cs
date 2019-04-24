public static class Kata 
{
  public static bool XO(string input)
    {
        int result = 0;                
        for (int i = 0; i < input.Length; i++)
        {
            if (input.ToLower()[i] == 'x')
            {
                result++;
            }
            else if (input.ToLower()[i] == 'o')
            {
                result--;
            }                
            else {
  
            }
        }
        if (result == 0)
        {
            return true;
        }
        else
        {
            return false;
        }             
    }
}