namespace Ex26
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Definim el número a comprovar
            int numero = 5;

            // Comprovem si el número és parell o senar
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número és parell."); // "E" de "Even" (parell)
            }
            else
            {
                Console.WriteLine("El número és senar."); // "O" de "Odd" (senar)
            }
        }
    }
}
