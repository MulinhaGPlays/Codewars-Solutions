
namespace Solutions
{
    public class CountTheDigit
    {
        public static int Solution(int n, int d)
            => Enumerable.Range(0, n + 1)
            .Select(x => (x * x)
            .ToString()
            .Count(y => y - 48 == d))
            .Sum();
    }
}
