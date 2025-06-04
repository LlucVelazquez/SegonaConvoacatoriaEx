namespace Ex15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix un número: ";
            Console.Write(Msg);
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                double resultat = Quadrat(num);
                Console.WriteLine($"El quadrat de {num} és {resultat}");
            }
            else
            {
                Console.WriteLine("Entrada no vàlida.");
            }
        }
        public static double Quadrat(double n)
        {
            return n * n;
        }
    }
}
