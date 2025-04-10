using System;

class Program {
    static void Main(string[] args) {
        double distancia, velocidade, tempo, litros_usados;
        
        Console.WriteLine(" ");
        Console.WriteLine("Digite o tempo total gasto em viagem: ");
        tempo = double.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        Console.WriteLine("Digite a velocidade aproximada: ");
        velocidade = double.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        distancia = tempo * velocidade;
        Console.WriteLine($"A distancia percorrida é de: {distancia} Km");

        litros_usados = distancia / 12;
        Console.WriteLine($"O total de litros usados é: {Math.Round(litros_usados)} L");
        Console.WriteLine(" ");



        

    }
}