using System;

class Program { 
    static void Main(string[] args) {
        double C,F;

        Console.WriteLine(" ");
        Console.WriteLine("Digite a temperatura atual em graus Celsius: ");
        C = double.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        F = (9 * C + 160) / 5;

        Console.WriteLine($"A temperatura atual em Celsius é de: {C}ª");
        Console.WriteLine($"A temperatura em Fahrenheit é de: {F}º ");
        Console.WriteLine(" ");
    }
}