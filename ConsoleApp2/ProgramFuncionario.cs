using System;

namespace ConsoleApp2;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome e salario:\n");
        string Nome = Console.ReadLine();
        decimal SalarioBruto = decimal.Parse(Console.ReadLine());
        
        Cargo Programador = new Cargo();
        Programador.Codigo = 123;
        Programador.Descricao = "Dev";

        ///// CÓDIGO NAO TERMINADO!!
        ///
        /// 
        /// 
        /// 
        Funcionario teste = new Funcionario(Nome, SalarioBruto);
        teste.posicao = new Cargo();
        teste.posicao = Programador;

        Console.WriteLine($"Relatório do salário:\n{teste.GerarSalarioLiquido()}\n");
    }
}