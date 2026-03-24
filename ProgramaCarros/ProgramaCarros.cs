using System;

namespace ProgramaCarros;

public class ProgramaMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escreva a marca, modelo, ano, velocidade e quantidade de portas:\n");
        Carro teste = new Carro
        (
            Console.ReadLine(),
            Console.ReadLine(),
            int.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine())
        );
        Console.WriteLine(teste.ExibirInformacoes());
        
    }
}
