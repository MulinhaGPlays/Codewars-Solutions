namespace Solutions
{
    public class RGBToHexConversion
    {
        public static string Solution(int r, int g, int b)
            => String.Join("", new[] { r, g, b }.Select(n => Math.Clamp(n, 0, 255).ToString("X2")));
    }
}
