namespace Solutions
{
    public class RectangleIntoSquares
    {
        public static List<int>? Solution(int lng, int wdth)
        {
            if (lng == wdth) return null;
            var squares = new List<int>();
            while (lng > 0 && wdth > 0)
            {
                if (lng < wdth)
                {
                    squares.Add(lng);
                    wdth -= lng;
                }
                else
                {
                    squares.Add(wdth);
                    lng -= wdth;
                }
            }
            return squares;
        }
    }
}
