namespace Ex9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 4;
            int y = 7;
            bool p = true;
            bool q = false;

            // Ex a)
            bool resultatA = y > x && p == q;

            // Ex c)
            bool resultatC = !(x * y < 30) && p;

        }
    }
}
