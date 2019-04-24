public static class Kata 
{
    public static int TotalPoints(string[] games) 
    {
        int points = 0;
        for (int i = 0; i < games.Length; i++)
        {                
            char[] Game = games[i].ToCharArray();
            if (int.Parse(Game[0].ToString()) > int.Parse(Game[2].ToString()))
            {
                points += 3;
            }
            else if (int.Parse(Game[0].ToString()) == int.Parse(Game[2].ToString()))
            {
                points += 1;
            }
            else
            {

            }
        }
        return points;
    }
}