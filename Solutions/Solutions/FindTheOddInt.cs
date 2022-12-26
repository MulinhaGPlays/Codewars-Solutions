namespace Solutions
{
    public class FindTheOddInt
    {
        public static int Solution(int[] seq)
            => seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
    }
}
