namespace Ex8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Divisió segura de dos nombres ===");
            double num1 = 0, num2 = 0;
            bool correcte = false;

            while (!correcte)
            {
                try
                {
                    num1 = DemanarNombre("Introdueix el primer nombre: ");
                    num2 = DemanarNombre("Introdueix el segon nombre: ");

                    double resultat = Dividir(num1, num2);
                    Console.WriteLine($"\nResultat: {num1} / {num2} = {resultat}");
                    correcte = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Has d'introduir un valor numèric vàlid.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: No es pot dividir per zero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperat: {ex.Message}");
                }
            }
        }

        public static double DemanarNombre(string missatge)
        {
            Console.Write(missatge);
            string entrada = Console.ReadLine();
            if (!double.TryParse(entrada, out double valor))
                throw new FormatException();
            return valor;
        }
        public static double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }
    }
}
