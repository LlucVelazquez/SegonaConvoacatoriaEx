namespace Ex7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix un nombre enter positiu: ";
            Console.Write(Msg);
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Els divisors parells de {num} són:");
            for (int i = 2; i <= num; i += 2)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{i} és divisor de {num}");
                }
            }
        }
    }
}
