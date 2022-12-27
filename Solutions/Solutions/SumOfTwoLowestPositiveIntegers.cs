namespace Solutions
{
    public class SumOfTwoLowestPositiveIntegers
    {
        public static int Solution(int[] numbers) => numbers.OrderBy(i => i).Take(2).Sum();
    }
}
