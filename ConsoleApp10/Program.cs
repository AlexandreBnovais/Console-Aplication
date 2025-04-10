using System;

class Program {
    static void Main(string[] args) {
        float nota1, nota2, nota3, nota4, media, notaRec;

        // Atribui valores ao usuario
        Console.WriteLine("Digite sua nota referente ao primeiro bimestre: ");
        nota1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua nota referente ao segundo bimestre: ");
        nota2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua nota referente ao terceiro bimestre: ");
        nota3 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua nota referente ao quarto bimestre: ");
        nota4 = float.Parse(Console.ReadLine());

        // Define a media 
        media = (nota1 + nota2 + nota3 + nota4) / 4;

        if (media >= 7) {
            Console.WriteLine("Você esta aprovado");
        }
        if (media < 7 ) {
            Console.WriteLine("Deseja incluir sua nota de recuperação: [s] ou [n]");
            char interaction = Console.ReadKey().KeyChar;

            if (interaction == 's') {
                Console.WriteLine("Digite sua nota de recuperação");
                notaRec = float.Parse(Console.ReadLine());

                media = notaRec + media;

                if (media >= 7) {
                    Console.WriteLine("Você esta aprovado!");
                } 
                else {
                    Console.WriteLine("Você esta reprovado!");
                }
            }
            else if (interaction == 'n') {
                Console.WriteLine("Você esta reprovado!");
            }
            else {
                Console.WriteLine("Error");
            }
            
        }
    } 
}