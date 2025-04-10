using System;

class TrocarValores () {
    static void Main() {
        int a = 2;
        int b = 3;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(" ");
        Console.WriteLine("Pressione enter para trocar os valores");
        Console.ReadKey();

        if (a == 2 || b == 3) {
            a = 3;
            b = 2;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        else {
            Console.WriteLine("error");
        }
    }
}