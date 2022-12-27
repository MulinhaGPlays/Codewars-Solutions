namespace Solutions
{
    public class MakeFunctionThatDoesArithmetic
    {
        public static double Solution(double a, double b, string op)
            => op.ToLower() switch
            {
                "add" => a + b,
                "subtract" => a - b,
                "multiply" => a * b,
                "divide" => a / b,
                _ => throw new NotImplementedException()
            };
    }
}
