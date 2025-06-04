namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = DemanarNumeroEntre1i100();
            Console.WriteLine($"Has introduït el número {num} correctament!");
        }
        static int DemanarNumeroEntre1i100()
        {
            int num;
            bool entradaValida = false;

            do
            {
                Console.Write("Introdueix un número entre 1 i 100: ");
                if (int.TryParse(Console.ReadLine(), out num) && num >= 1 && num <= 100)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada no vàlida. Torna-ho a intentar.");
                }
            } while (!entradaValida);

            return num;
        }
    }
}
