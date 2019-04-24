public static class Kata 
{
    public static int summation(int num)
    {
      int result = 0;      
      while(!(num == 0))
      {        
        result = result + num;
        num--;
      }
      return result;
    }
}