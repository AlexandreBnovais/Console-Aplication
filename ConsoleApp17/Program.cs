using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;

class Product {
    private string nome;
    private  double preco;
    private double quantidade;

    public void Name() {
        Console.WriteLine("Digite seu nome");
        this.nome = Console.ReadLine();
    }
    public void AddStock(int add) {
        if(add <= 0) {
            Console.WriteLine("Quantidade insulficiente");
        }else {
            this.quantidade += add;
            this.preco += this.quantidade;
            this.preco *= 2.50;
            Console.WriteLine(" ");
            Console.WriteLine($"Foram adcionados {add} novos itens com sucesso");
            Console.WriteLine(" ");
        }
    }

    public void RemoveStock(int remove) {
        this.quantidade -= remove;
        this.preco = this.quantidade;
        this.preco *= 2.50;
        Console.WriteLine(" ");
        Console.WriteLine($"Foram removidos {remove} itens com sucesso");
        Console.WriteLine(" ");
    }

    public void StockInfo() {
        Console.WriteLine($"Bem vindo {nome}\n Total de itens selecionados: {this.quantidade}\n Custo Total: {this.preco.ToString("C")}");
    }

    public void StockItem() {
        Console.WriteLine($"Bem vindo {nome}\n Total de Itens em estoque: {this.quantidade}");
    }
}

class Program {
    static void Main(string[] args) {
        Product ProductStock = new Product();

        ProductStock.Name();
        Console.Clear();

        do { 
            Console.WriteLine(" "); 
            Console.WriteLine("Selecione um alternativa");
            Console.WriteLine("1. Verificar Estoque\t 2. Verificar itens \t 3. Adcionar item \t 4. remover item\t 5. Sair");

            int choose = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch(choose) {
                case 1:
                    ProductStock.StockInfo();
                break;

                case 2: 
                    ProductStock.StockItem();
                break;

                case 3: 
                    Console.Write("Digite um número: ");
                    int add = Convert.ToInt32(Console.ReadLine());
                    ProductStock.AddStock(add);
                break;

                case 4: 
                    Console.WriteLine("Digite um número: ");
                    int rem = Convert.ToInt32(Console.ReadLine());
                    ProductStock.RemoveStock(rem);
                break;

                case 5:
                    Console.WriteLine("Saindo...");
                    Console.Clear();
                return;

                default: 
                    Console.Write("Função invalida");
                break;

            }
        }while(true);
    }
}
