namespace Ex5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introdueix un número enter positiu: ");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
            {
                Console.Write("Valor no vàlid. Torna-ho a provar: ");
            }
            long factorialIteratiu = FactorialIteratiu(num);
            long factorialRecursiu = FactorialRecursiu(num);
            bool primer = EsPrimer(num);

            Console.WriteLine($"\nFactorial iteratiu de {num}: {factorialIteratiu}");
            Console.WriteLine($"Factorial recursiu de {num}: {factorialRecursiu}");
            Console.WriteLine($"{num} {(primer ? "és" : "no és")} un nombre primer.");
        }
        public static long FactorialIteratiu(int n)
        {
            long resultat = 1;
            for (int i = 2; i <= n; i++)
            {
                resultat *= i;
            }
            return resultat;
        }
        public static long FactorialRecursiu(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * FactorialRecursiu(n - 1);
        }
        public static bool EsPrimer(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
