namespace Ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Introdueix un número enter: ");
            num = int.Parse(Console.ReadLine());
            {
                int suma = SumaDigits(Math.Abs(num));
                Console.WriteLine($"La suma dels dígits de {num} és {suma}");
            }
        }
        static int SumaDigits(int n)
        {
            int suma = 0;
            while (n > 0)
            {
                suma += n % 10;
                n /= 10;
            }
            return suma;
        }
    }
}
