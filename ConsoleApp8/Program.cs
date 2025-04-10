using System;

class Program {
    static void Main(string[] args) {
        int dia, mes, ano, idade;

        Console.WriteLine(" ");
        Console.WriteLine("Digite o dia do seu nascimento: ");
        dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu mês de nascimento: ");
        mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o ano em que você nasceu: ");
        ano = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine($"Você nasceu em: {dia} / {mes} / {ano}");

        idade = ano * 365 * mes * 30 * dia;
        Console.WriteLine($"Sua idade em dias é: {idade}");

        Console.WriteLine(" ");
    }
}