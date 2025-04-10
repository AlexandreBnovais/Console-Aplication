using System;

class Program {
    static void Main(string[] args) {
        double preçoUnitario, Qtd_vendas, comissao;

        Console.WriteLine("Digite a quantidade de vendas feitas: ");
        Qtd_vendas = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do produto: ");
        preçoUnitario = double.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        preçoUnitario += preçoUnitario * Qtd_vendas;
        comissao = preçoUnitario * 0.05;

        Console.WriteLine($"Preço unitario: {preçoUnitario.ToString("c")}\nComissão: {comissao.ToString("C")}");
        Console.WriteLine(" ");
    }
}