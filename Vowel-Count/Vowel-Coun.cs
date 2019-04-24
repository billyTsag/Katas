public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'u' || str[i] == 'o')
            {
                vowelCount++;
            }
        }
        return vowelCount;        
    }
}