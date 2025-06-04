namespace Ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secret = rnd.Next(1, 51);
            int intents = 0;
            int resposta = 0;
            const string Msg = "Endevina el número (entre 1 i 50)!";
            const string InsertNum = "Introdueix la teva resposta: ";
            const string ErrorNum = "Entrada no vàlida. Introdueix un número entre 1 i 50.";
            const string Higher = "Més alt!";
            const string Lower = "Més baix!";
            Console.WriteLine(Msg);

            do
            {
                Console.Write(InsertNum);
                if (!int.TryParse(Console.ReadLine(), out resposta) || resposta < 1 || resposta > 50)
                {
                    Console.WriteLine(ErrorNum);
                    continue;
                }

                intents++;

                if (resposta < secret)
                    Console.WriteLine(Higher);
                else if (resposta > secret)
                    Console.WriteLine(Lower);
                else
                    Console.WriteLine($"Correcte! Has encertat el número {secret} en {intents} intents.");
            }
            while (resposta != secret);
        }
    }
}
