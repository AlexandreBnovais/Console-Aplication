using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite um valor: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro valor: ");
        double b = double.Parse(Console.ReadLine());

        while(true) {
            Console.WriteLine(" ");
            Console.WriteLine("1..somar");
            Console.WriteLine("2..Subtrair");
            Console.WriteLine("3..Multiplicar");
            Console.WriteLine("4..Dividir");
            Console.WriteLine("5..Sair");
            Console.WriteLine(" ");

            int client = int.Parse(Console.ReadLine());

            switch(client) {
                case 1:
                    Console.WriteLine($"A soma dos algarismos {a} + {b} = {a + b}");
                    Console.WriteLine("[s] Sair");
                    char exit = Console.ReadKey().KeyChar;

                    if(exit == 's') {
                        Console.WriteLine("Saindo...");
                        continue;
                    }
                return;
                
                case 2:
                    Console.WriteLine($"A subtração dos algarismos {a} - {b} = {a - b}");
                    Console.WriteLine("[s] Sair");
                    exit = Console.ReadKey().KeyChar;

                    if(exit == 's') {
                        Console.WriteLine("Saindo...");
                        continue;
                    }
                return;

                case 3:
                    Console.WriteLine($"A Multiplicação dos algarismos {a} * {b} = {a * b}");
                    Console.WriteLine("[s] Sair");
                    exit = Console.ReadKey().KeyChar;

                    if(exit == 's') {
                        Console.WriteLine("Saindo...");
                        continue;
                    }
                return;

                case 4:
                    if (a%0 == 0 || b%0 == 0) {
                        Console.WriteLine("Digite um número maior que 0");
                    }
                    
                    Console.WriteLine($"A divisão dos algarismos {a} / {b} = {a / b}");
                    Console.WriteLine("[s] Sair");

                    exit = Console.ReadKey().KeyChar;

                    if(exit == 's') {
                        Console.WriteLine("Saindo...");
                        continue;
                    }
                return;

                case 5:
                    Console.WriteLine("Saindo...");
                return;

                default: 
                    Console.WriteLine("Selecione às opções novamente:");
                break;
            }
        }   
    }
}