namespace Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int tamany = 5;
            string[] paraules = new string[tamany];

            // Demanar 5 paraules
            for (int i = 0; i < tamany; i++)
            {
                Console.Write($"Introdueix la paraula {i + 1}: ");
                paraules[i] = Console.ReadLine();
            }

            // Mostrar les paraules en ordre invers
            Console.WriteLine("\nParaules en ordre invers:");
            for (int i = tamany - 1; i >= 0; i--)
            {
                Console.WriteLine(paraules[i]);
            }
        }
    }
}
