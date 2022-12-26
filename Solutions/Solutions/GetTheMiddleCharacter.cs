namespace Solutions
{
    public class GetTheMiddleCharacter
    {
        public static string Solution(string s)
            => string.IsNullOrEmpty(s) ? s : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
    }
}
