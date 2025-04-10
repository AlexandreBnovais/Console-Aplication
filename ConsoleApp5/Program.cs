using System;

class Program {
    static void Main(string[] args) {
        int a,b,c,d;

        // Processamento de dados
        Console.WriteLine(" ");
        Console.WriteLine("Defina um valor para a,b,c,d: ");
        Console.WriteLine(" ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        // Processamento de expressão

        int mult1,mult2,mult3,mult4,mult5;
        mult1 = a + b * a + c;
        mult2 = a + c * a + d;
        mult3 = a + d * b + c;
        mult4 = b + c * b + d;
        mult5 = b + d * c + d;

        // Resultado
        Console.WriteLine($"A expressão seguinte: ({a} + {b}) * ({a} + {c}) = {mult1}");
        Console.WriteLine($"A expressão seguinte: ({a} + {c}) * ({a} + {d}) = {mult2}");
        Console.WriteLine($"A expressão seguinte: ({a} + {d}) * ({b} + {c}) = {mult3}");
        Console.WriteLine($"A expressão seguinte: ({b} + {c}) * ({b} + {d}) = {mult4}");
        Console.WriteLine($"A expressão seguinte: ({b} + {d}) * ({c} + {d}) = {mult5}");

        Console.WriteLine(" ");
        
        

    }
}