namespace Solutions
{
    public class BitCounting
    {
        public static int Solution(int n) => Convert.ToString(n, 2).Count(x => x == '1');
    }
}
