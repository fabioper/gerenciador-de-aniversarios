using System;

namespace GerenciadorDeAniversarios.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGreeting();

            Console.ReadKey();
        }

        private static void StartGreeting()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bem vindo ao Gerenciador de Aniversários!");
            Console.WriteLine("-----------------------------------------\n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
