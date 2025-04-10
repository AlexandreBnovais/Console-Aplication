using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1 {
    class Calculater {
        static double Soma(double a, double b) {
            return a + b;
        }

        static double Subtrair(double a, double b) {
            return a - b;
        }

        static double Multiplicar(double a, double b) {
            return a * b;
        }

        static double Dividir(double a, double b) {
            if (a == 0 || b == 0) {
                Console.WriteLine("Parametro invalido");
            }

            return a / b;
        } 

        static void Main(string[] args) {
            double num1, num2, resultado;

            Console.WriteLine("Escolha um operação: \n [a] Somar \n [b] Subtrair \n [c] Multiplicar \n [d] Dividir");
            char options = Console.ReadKey().KeyChar;

            switch (options) {
                case 'a':
                    Console.WriteLine("Digite dois algarismos: ");

                    num1 = double.Parse(Console.ReadLine());
                    num2 = double.Parse(Console.ReadLine());
                    resultado = Soma(num1 , num2);

                    Console.WriteLine("O resultado será: " + resultado);
                break;

                case 'b': 
                    Console.WriteLine("Digite dois algarismos");

                    num1 = double.Parse(Console.ReadLine());
                    num2 = double.Parse(Console.ReadLine());

                    resultado = Subtrair(num1,num2);

                    Console.WriteLine("O resultado será: " + resultado);
                break;

                case 'c': 
                    Console.WriteLine("Digite dois algarismos");

                    num1 = double.Parse(Console.ReadLine());
                    num2 = double.Parse(Console.ReadLine());

                    resultado = Multiplicar(num1,num2);

                    Console.WriteLine("O resultado será: " + resultado);
                break;

                case 'd': 
                    Console.WriteLine("Digite dois algarismos");

                    num1 = double.Parse(Console.ReadLine());
                    num2 = double.Parse(Console.ReadLine());

                    resultado = Dividir(num1,num2);

                    Console.WriteLine("O resultado será: " + resultado);
                break;

                default:
                    Console.WriteLine("Error: opção não disponivel");
                break;
            }
        }
    }
}