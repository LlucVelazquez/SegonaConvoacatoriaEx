namespace Ex7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char opcio;
            bool flag = true;
            while (flag)
            {
                MostrarMenu();
                opcio = char.Parse(Console.ReadLine());
                switch (opcio)
                {
                    case 'a':
                        CalcularAreaRectangle();
                        break;
                    case 'b':
                        ComprovarAnyTraspas();
                        break;
                    case 'c':
                        Console.WriteLine("Sortint del programa...");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Opció no vàlida. Torna-ho a provar.");
                        break;
                }
            }
        }
        public static void MostrarMenu()
        {
            Console.WriteLine("=== MENÚ ===");
            Console.WriteLine("a) Calcular àrea d'un rectangle");
            Console.WriteLine("b) Comprovar si un any és de traspàs");
            Console.WriteLine("c) Sortir");
            Console.Write("Selecciona una opció: ");
        }
        public static void CalcularAreaRectangle()
        {
            Console.WriteLine("--- Càlcul d'àrea del rectangle ---");

            double longitud = DemanarNumero("Introdueix la longitud (m): ");
            double amplada = DemanarNumero("Introdueix l'amplada (m): ");

            Console.WriteLine($"Àrea: {longitud * amplada} m2");
        }
        public static void ComprovarAnyTraspas()
        {
            Console.WriteLine("--- Comprovació d'any de traspàs ---");

            int any = (int)DemanarNumero("Introdueix l'any: ", esEnter: true);
            bool esTraspas = (any % 4 == 0 && (any % 100 != 0 || any % 400 == 0));

            Console.WriteLine($"{any} {(esTraspas ? "ÉS" : "NO ÉS")} un any de traspàs.");
        }
        public static double DemanarNumero(string missatge, bool esEnter = false)
        {
            double numero;
            Console.Write(missatge);

            while (!double.TryParse(Console.ReadLine(), out numero) ||
                  (esEnter && numero != Math.Floor(numero)) ||
                  numero <= 0)
            {
                Console.Write($"Valor no vàlid. {missatge}");
            }
            return numero;
        }
    }
}
