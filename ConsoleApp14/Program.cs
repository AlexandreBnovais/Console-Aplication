using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite um valor: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro valor: ");
        int b = int.Parse(Console.ReadLine());

        while(true) {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Verificar se um dos números é multiplo do outro");
            Console.WriteLine("2 - Verificar se os dois números são pares");
            Console.WriteLine("3 - Verificar se a media dos dois números é maior ou igual a 7");
            Console.WriteLine("4 - Sair");
            Console.WriteLine(" ");

            int valor = int.Parse(Console.ReadLine());

            switch (valor) {
                case 1: 
                    if ((a * 2) == b) {
                        Console.WriteLine($"{b} é multiplo de {a}");
                        continue;
                    }
                    else if ((b * 2) == a) {
                        Console.WriteLine($"{a} é multiplo de {b}");
                        continue;
                    }
                    else {
                        Console.WriteLine("Ambos os números não tem relação");
                    }
                return;

                case 2: 
                    if(a%2 == 0 && b%2 == 0) {
                        Console.WriteLine("Ambos os valores são pares");
                        continue;
                    }
                    else if (a%2 == 0) {
                        Console.WriteLine($"Somente o número {a} é par");
                        continue;
                    }
                    else if(b%2 == 0) {
                        Console.WriteLine($"Somente o número {b} é par");
                        continue;
                    }
                    else {
                        Console.WriteLine("Ambas são impares");
                    }
                return;

                case 3: 
                    double media = (a + b) / 2;
                    
                    if (media >= 7) {
                        Console.WriteLine("Aprovado");
                        continue;
                    }
                    else {
                        Console.WriteLine("Reprovado");
                    }
                return;

                case 4: 
                    Console.WriteLine("Saindo...");
                return;

                default: 
                    Console.WriteLine("Digite uma das opções");
                break;
            }
        }
    }
}