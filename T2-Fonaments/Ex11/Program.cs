using System.Globalization;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdueix una data (dd/MM/yyyy): ");
            string entrada = Console.ReadLine();

            if (DataValida(entrada, out DateTime data))
            {
                string[] diesSetmana = { "diumenge", "dilluns", "dimarts", "dimecres", "dijous", "divendres", "dissabte" };
                string diaSetmana = diesSetmana[(int)data.DayOfWeek];

                Console.WriteLine($"La data és vàlida. Cau en {diaSetmana}.");
            }
            else
            {
                Console.WriteLine("La data NO és vàlida.");
            }
        }

        static bool DataValida(string entrada, out DateTime data)
        {
            return DateTime.TryParseExact(
                entrada,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out data
            );
        }
    }
}
