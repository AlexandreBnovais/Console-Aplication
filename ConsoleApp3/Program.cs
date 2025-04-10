using System;

class Program() {
    static int VerificarQuadrante(double x, double y) {
        if(x > 0 && y > 0) {
            return 1; // Quadrante 1;
        }
        else if (x > 0 && y < 0) {
            return 2; // Quadrante 2; 
        }
        else if (x < 0 && y > 0) {
            return 3; // Quadrante 3;
        } 
        else if (x < 0 && y < 0) {
            return 4; // Quadrante 4;
        }
        else {
            return 0;
        }
    }

    static void Main(string[] args) {
        Console.WriteLine("Digite um valor para x é outro para y");

        int numx = int.Parse(Console.ReadLine());
        int numy = int.Parse(Console.ReadLine());

        Console.WriteLine("Quadrante: " + VerificarQuadrante(numx,numy));

    }
}