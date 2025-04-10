using System;
using System.Formats.Tar;
using System.Runtime.CompilerServices;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("DIgite sua altura");
        double h = double.Parse(Console.ReadLine());

        while (true) {
            Console.WriteLine("Pressione [M] Masculino: ");
            Console.WriteLine("Pressione [F] Feminino");
            Console.WriteLine("Pressione [s] Sair");

            char gender = Console.ReadKey().KeyChar;

            if (gender == 'm') {
                Console.WriteLine($"Seu peso ideal é de: {(72.7 * h) - 58}[F:2]");
                Console.WriteLine(" ");
                Console.WriteLine("[s] para sair");

                char exit = Console.ReadKey().KeyChar;
                
                if (exit == 's') {
                    Console.WriteLine("saindo...");
                }
                continue;
            }
            else if (gender == 'f') {
                Console.WriteLine($"Seu peso ideal é de: {(62.1 * h) - 44.7}");
                Console.WriteLine(" ");
                Console.WriteLine("[s] para sair");

                char exit = Console.ReadKey().KeyChar;
                if (exit == 's') {
                    Console.WriteLine("saindo...");
                }
                continue;
            }
            else if (gender == 's') {
                Console.WriteLine("saindo...");
                return;
            }
        }
    }
}