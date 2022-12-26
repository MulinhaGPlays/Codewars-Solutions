namespace Solutions
{
    public class CountCharactersInYourString
    {
        public static Dictionary<char, int> Solution(string str)
            => str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
    }
}
