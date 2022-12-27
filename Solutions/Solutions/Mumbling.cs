namespace Solutions
{
    public class Mumbling
    {
        public static String Solution(string s)
            => string.Join("-", s.Select((x, i) 
                => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }
}
