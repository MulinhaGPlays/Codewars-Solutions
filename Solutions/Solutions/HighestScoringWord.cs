namespace Solutions
{
    public class HighestScoringWord
    {
        public static string Solution(string s)
            => s.Split(' ').OrderBy(a => a.Select(b => b - 96).Sum()).Last();
    }
}
