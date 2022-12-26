namespace Solutions
{
    public class OddOrEven
    {
        public static string Solution(int[] array) => array.Sum() % 2 == 0 ? "even" : "odd";
    }
}
