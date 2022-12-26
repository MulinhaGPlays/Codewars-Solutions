﻿namespace Solutions
{
    public class TwoSum
    {
        public static int[] Solution(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
                for (int j = i + 1; j < numbers.Length; j++)
                    if (numbers[i] + numbers[j] == target)
                        return new int[] { i, j };

            return Array.Empty<int>();
        }
    }
}
