using System;

class Program {
    static void Main(string[] args) {
        int a,b,c;
        Console.WriteLine("Digite um valor para A");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor para b");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor para c");
        c = int.Parse(Console.ReadLine());

        if ((a + b) < c || (a + c) < b || (b + c) < a) {
            if (a == b && b == c) {
                Console.WriteLine("O trinagulo é equilatero");
            }
            else if (a == b || a == c || b == c) {
                Console.WriteLine("isociles");
            }
            else {
                Console.WriteLine("Escaleno");
            }
        }
        else {
            Console.WriteLine("Os dados fornecidos não se caracterizam um triângulo");
        }
    }
}