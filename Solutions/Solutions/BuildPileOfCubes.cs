namespace Solutions
{
    public class BuildPileOfCubes
    {
        public static long Solution(long m)
        {
            long total = 1, i = 2;
            for (; total < m; i++) total += i * i * i;
            return total == m ? i - 1 : -1;
        }
    }
}
