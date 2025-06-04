namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int tamany = 10;
            int[] numeros = new int[tamany];
            for (int i = 0; i < tamany; i++)
            {
                Console.Write($"Introdueix el número {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.Write("Entrada no vàlida. Torna-ho a provar: ");
                }
            }
            Console.Write("\nIntrodueix el número a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int aBuscar))
            {
                bool trobat = false;
                Console.WriteLine();
                for (int i = 0; i < tamany; i++)
                {
                    if (numeros[i] == aBuscar)
                    {
                        Console.WriteLine($"El número {aBuscar} es troba a la posició {i}.");
                        trobat = true;
                    }
                }
                if (!trobat)
                {
                    Console.WriteLine($"El número {aBuscar} NO es troba a l'array.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no vàlida.");
            }
        }
    }
}
