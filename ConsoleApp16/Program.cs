using System;
using System.Net.Security;
using System.Xml.Schema;

class GeneciadorDeContas {
    static void Main() {
        while(true) {
            Console.WriteLine("1...Verificar Saldo");
            Console.WriteLine("2...Efetuar Deposito");
            Console.WriteLine("3...Efetuar Saque");

            int VerificarSelecao = Convert.ToInt32(Console.ReadLine());
            Servicos servicos = new Servicos();

            switch(VerificarSelecao) {
                case 1: 
                    servicos.VerificarSaldo();
                continue;

                case 2:
                    Console.WriteLine("Digite o valor do deposito");
                    double valorDoDeposito = Convert.ToDouble(Console.ReadLine());
                    servicos.Depositar(valorDoDeposito);
                continue;

                case 3:
                    Console.WriteLine("Digite o valor do saque"); 
                    double valorDoSaque = Convert.ToDouble(Console.ReadLine());
                    servicos.Sacar(valorDoSaque);
                continue;

                default: 
                    Console.WriteLine("Error! Digite somente números");
                break;
            }
        }
    }
}

class Servicos {
    public double saldo;

    public double Depositar(double dep) {
        return dep += saldo;
    } 

    public double Sacar(double sac) {
        return sac -+ saldo;
    }

    public void VerificarSaldo() {
        Console.WriteLine(saldo);
    }
}