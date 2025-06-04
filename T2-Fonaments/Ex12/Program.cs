namespace Ex12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Introdueix un número enter: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num > 0)
                    Console.WriteLine("El número és positiu.");
                else if (num < 0)
                    Console.WriteLine("El número és negatiu.");
                else
                    Console.WriteLine("El número és zero.");

                if (num % 2 == 0)
                    Console.WriteLine("El número és parell.");
                else
                    Console.WriteLine("El número és senar.");
            }
            else
            {
                Console.WriteLine("Entrada no vàlida. Introdueix un número enter.");
            }
        }
    }
}
