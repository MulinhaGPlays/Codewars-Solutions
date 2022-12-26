namespace Solutions
{
    public class CreditCardMask
    {
        public static string Solution(string cc)
        {
            int len = cc.Length;
            if (len <= 4)
                return cc;

            return cc[(len - 4)..].PadLeft(len, '#');
        }
    }
}
