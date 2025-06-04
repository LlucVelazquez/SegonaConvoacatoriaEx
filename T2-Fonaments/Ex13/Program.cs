using Microsoft.VisualBasic;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Msg = "Introdueix un número enter: ";
            Console.WriteLine(Msg);
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine($"\nTaula de multiplicar del {num}:");
                MostrarTaulaMultiplicar(num);
            }
            else
            {
                Console.WriteLine("Entrada no vàlida. Introdueix un número enter.");
            }
        }

        static void MostrarTaulaMultiplicar(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
