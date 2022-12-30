namespace Solutions
{
    public class SumOfDigitsOrDigitalRoot
    {
        public int Solution(long n) => (int)(1 + (n - 1) % 9);
    }
}
