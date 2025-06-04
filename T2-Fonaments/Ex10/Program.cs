using System.Text.RegularExpressions;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdueix la cadena: ");
            string cadena = Console.ReadLine();

            if (TeVuitDigitsILletra(cadena))
                Console.WriteLine("La cadena és vàlida (8 dígits seguits d’una lletra).");
            else
                Console.WriteLine("La cadena NO és vàlida.");
        }

        static bool TeVuitDigitsILletra(string cadena)
        {
            return Regex.IsMatch(cadena, @"^\d{8}[A-Za-z]$");
        }
    }
}
