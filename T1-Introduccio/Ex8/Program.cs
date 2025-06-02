namespace Ex8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix quants números vols introduir: ";
            Console.WriteLine(Msg);
            int n = int.Parse(Console.ReadLine());
            int suma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introdueix el número {0}: ", i + 1);
                int num = int.Parse(Console.ReadLine());
                suma += num;
            }

            double mitjana = (double)suma / n;
            Console.WriteLine("La mitjana dels {0} números és: {1:F2}", n, mitjana);
        }
    }
}
