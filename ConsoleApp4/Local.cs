using System;

namespace ConsoleApp4;

public class Local : Identificador
{
    public string Endereco {get; private set;}
    public string Nome {get;private set;}
    public int Capacidade {get;private set;}
    
    public Local()
    {
        Console.WriteLine("Informe o nome do local:");
        Nome = Console.ReadLine();
        Console.WriteLine("Informe o endereco do local:");
        Endereco = Console.ReadLine();
        Console.WriteLine("Informe a capacidade do local:");
        Capacidade = int.Parse(Console.ReadLine());
        id = Id();
    }

    public override string ObterDescricao()
    {
        return $"[ID: {id}] Nome: {Nome} | Endereço: {Endereco} | Capacidade: {Capacidade}";
    }
}
