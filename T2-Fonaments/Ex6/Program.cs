namespace Ex6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int TAMANY = 10;
            int[] numeros = DemanarNumeros(TAMANY);

            double mitjana = CalcularMitjana(numeros);
            int parells = ComptarParells(numeros);
            int senars = TAMANY - parells;

            Console.WriteLine($"\nMitjana: {mitjana}");
            Console.WriteLine($"Nombre de valors parells: {parells}");
            Console.WriteLine($"Nombre de valors senars: {senars}");
        }
        static int[] DemanarNumeros(int quantitat)
        {
            int[] array = new int[quantitat];
            for (int i = 0; i < quantitat; i++)
            {
                Console.Write($"Introdueix el número {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.Write("Valor no vàlid. Torna-ho a provar: ");
                }
            }
            return array;
        }
        static double CalcularMitjana(int[] array)
        {
            int suma = 0;
            foreach (int num in array)
            {
                suma += num;
            }
            return (double)suma / array.Length;
        }
        static int ComptarParells(int[] array)
        {
            int comptador = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                    comptador++;
            }
            return comptador;
        }
    }
}
