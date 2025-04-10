using System;

class Program {
    static void Main(string[] args) {
        int n1, n2;

        Console.WriteLine("Digite um numero: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro numero: ");
        n2 = int.Parse(Console.ReadLine());

        if (n1 == n2) {
            Console.WriteLine($"{n1} é maior que {n2}");
        }
        if (n1 != n2) {
            Console.WriteLine($"{n1} não é igual a {n2}");
        }
        if (n1 > n2){
            Console.WriteLine($"{n1} é maior que {n2}");
        }
        if (n1 < n2) {
            Console.WriteLine($"{n1} é menor que {n2}");
        }
        if (n1 >= n2) {
            Console.WriteLine($"{n1} é menor igual a {n2}");
        }
        if (n1 <= n2) {
            Console.WriteLine($"{n1} é menor igual a {n2}");
        }
        else {
            Console.WriteLine("error");
        }
     }
}