using System;

namespace ConsoleApp2;

public class Program
{
    static void Main(string[] args)
    {
        string Nome = Console.ReadLine();
        string Cargo = Console.ReadLine();
        decimal SalarioBruto = decimal.Parse(Console.ReadLine());

        Funcionario teste = new Funcionario
        (
            Nome,
            Cargo,
            SalarioBruto
        );
        Console.WriteLine($"Relatório do salário:\n{teste.GerarSalarioLiquido()}\n");
    }
}