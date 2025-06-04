using System.Runtime.CompilerServices;

namespace Ex21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix la temperatura en graus Celsius: ";
            const string Select = "Vols convertir a Fahrenheit (F) o Kelvin (K)? ";
            double num;
            Console.WriteLine(Msg);
            num = double.Parse(Console.ReadLine());
            Console.WriteLine(Select);
            string opcio = Console.ReadLine().Trim().ToUpper();
            switch (opcio)
            {
                case "F":
                    double fahrenheit = CelsiusAFahrenheit(num);
                    Console.WriteLine($"{num} ºC són {fahrenheit} ºF");
                    break;
                case "K":
                    double kelvin = CelsiusAKelvin(num);
                    Console.WriteLine($"{num} ºC són {kelvin} K");
                    break;
                default:
                    Console.WriteLine("Opció no vàlida. Escriu 'F' per Fahrenheit o 'K' per Kelvin.");
                    break;
            }
        }
        public static double CelsiusAFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }

        public static double CelsiusAKelvin(double c)
        {
            return c + 273.15;
        }
    }
}
