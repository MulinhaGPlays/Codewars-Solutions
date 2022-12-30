namespace Solutions
{
    public class RomanNumeralsDecoder
    {
        public static int Solution(string roman)
        {
            var literals = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };

            int result = 0;
            int max = 0;

            foreach (var c in roman.Reverse())
            {
                int value = literals[c];

                if (value < max)
                {
                    result -= value;
                }
                else
                {
                    result += value;
                    max = value;
                }
            }
            return result;
        }
    }
}
