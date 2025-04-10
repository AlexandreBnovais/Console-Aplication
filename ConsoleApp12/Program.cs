using System;

class Program 
{
    static int LerValor(string mensagem) {
        
        int valor;
        
        do {
            Console.Write(mensagem);
            if (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0) {
                Console.WriteLine("Valor invalido! Digite um numero inteiro diferente de zero.");
            }
        }
        while (valor <= 0);

        return valor;
    }

    static void Main() {
        int a = LerValor("Digite um valor para a: ");
        int b = LerValor("Digite um valor para b: ");
        int c = LerValor("Digite um valor para c: ");

        int menor = Math.Min(a, Math.Max(b,c));
        int maior = Math.Max(a, Math.Max(b,c));

        int multiplicaçao = menor * maior;
        double divisao = (double)maior / menor;

        Console.WriteLine($"Menor valor multiplicado pelo maior: {multiplicaçao}");
        Console.WriteLine($"Maior valor dividido pelo menor: {divisao:F2}");
    }
}