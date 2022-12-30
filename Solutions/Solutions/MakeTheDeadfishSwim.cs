namespace Solutions
{
    public class MakeTheDeadfishSwim
    {
        public static int[] Solution(string data)
        {
            var output = new List<int>();
            int value = 0;
            foreach (var instruction in data)
            {
                switch (instruction)
                {
                    case 'i':
                        ++value;
                        break;
                    case 'd':
                        --value;
                        break;
                    case 's':
                        value *= value;
                        break;
                    case 'o':
                        output.Add(value);
                        break;
                }
            }
            return output.ToArray();
        }
    }
}
