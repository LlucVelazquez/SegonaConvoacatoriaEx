namespace Ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int tamany = 8;
            int[] numeros = new int[tamany];
            for (int i = 0; i < tamany; i++)
            {
                Console.Write($"Introdueix el número {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.Write("Entrada no vàlida. Torna-ho a provar: ");
                }
            }
            int maxim = numeros[0];
            int minim = numeros[0];
            int suma = 0;
            foreach (int num in numeros)
            {
                if (num > maxim) maxim = num;
                if (num < minim) minim = num;
                suma += num;
            }
            double mitjana = (double)suma / tamany;
            Console.WriteLine($"\nEl número més gran és: {maxim}");
            Console.WriteLine($"El número més petit és: {minim}");
            Console.WriteLine($"La mitjana és: {mitjana}");
        }
    }
}
