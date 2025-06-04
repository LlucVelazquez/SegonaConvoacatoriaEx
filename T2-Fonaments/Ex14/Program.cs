namespace Ex14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int tamany = 5;
            int[] numeros = new int[tamany];
            for (int i = 0; i < tamany; i++)
            {
                Console.Write($"Introdueix el número {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.Write("Entrada no vàlida. Torna-ho a provar: ");
                }
            }
            Console.WriteLine("\nNúmeros introduïts:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            int suma = 0;
            foreach (int num in numeros)
            {
                suma += num;
            }
            Console.WriteLine($"\nLa suma de tots els números és: {suma}");
        }
    }
}
