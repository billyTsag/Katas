public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
            char[] swap = dna.ToCharArray();
            
            for (int i = 0; i < swap.Length; i++)
            {
                if (swap[i] == 'A')
                {
                    swap[i] = 'T';
                }
                else if (swap[i] == 'T')
                {
                    swap[i] = 'A';
                }
                else if (swap[i] == 'C')
                {
                    swap[i] = 'G';
                }
                else if (dna[i] == 'G')
                {
                    swap[i] = 'C';
                }
            }   
            string result = new string(swap);
            return result;
        }
    }