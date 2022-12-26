namespace Solutions
{
    public class ComplementaryDNA
    {
        public static string Solution(string dna)
            => string.Concat(dna.Select(GetComplement));

        public static char GetComplement(char symbol)
        {
            return symbol switch
            {
                'A' => 'T',
                'T' => 'A',
                'C' => 'G',
                'G' => 'C',
                _ => throw new ArgumentException(),
            };
        }
    }
}