namespace Ex9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Introdueix una contrasenya: ");
            string password = Console.ReadLine();

            if (EsContrasenyaValida(password))
                Console.WriteLine("La contrasenya és vàlida.");
            else
                Console.WriteLine("La contrasenya NO és vàlida.");
        }

        public static bool EsContrasenyaValida(string password)
        {
            if (password.Length < 8 || password.Length > 12)
                return false;

            bool teMajuscula = false;
            bool teMinuscula = false;
            bool teNumero = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) teMajuscula = true;
                else if (char.IsLower(c)) teMinuscula = true;
                else if (char.IsDigit(c)) teNumero = true;
                else if (char.IsWhiteSpace(c)) return false;
            }

            return teMajuscula && teMinuscula && teNumero;
        }
    }
}
