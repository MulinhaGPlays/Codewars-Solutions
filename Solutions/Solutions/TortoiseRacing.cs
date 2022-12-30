namespace Solutions
{
    public class TortoiseRacing
    {
        public static int[]? Solution(int v1, int v2, int g)
        {
            if (v1 >= v2)
                return null;
            var ts = TimeSpan.FromSeconds((g * 3600) / (v2 - v1)) ;
            return new[] { ts.Hours, ts.Minutes, ts.Seconds };
        }
    }
}