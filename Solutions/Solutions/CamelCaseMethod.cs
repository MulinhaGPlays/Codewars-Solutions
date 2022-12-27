using System.Globalization;

namespace Solutions
{
    public static class CamelCaseMethod
    {
        public static string Solution(this string str)
            => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str).Replace(" ", String.Empty);
    }
}
