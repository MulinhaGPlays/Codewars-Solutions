namespace Solutions
{
    public class HelpTheBookseller
    {
        public static string Solution(String[] lstOfArt, String[] lstOf1stLetter) 
            => lstOfArt.Any() ? String.Empty : String.Join(" - ", lstOf1stLetter.Select(
                c => String.Format("({0} : {1})", c, lstOfArt.Where(
                    a => a[0] == c[0]).Sum(
                    a => int.Parse(a.Split(' ')[1])))));
    }
}
