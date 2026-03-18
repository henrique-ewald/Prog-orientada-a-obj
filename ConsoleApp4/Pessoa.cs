using System;

namespace ConsoleApp4;

public abstract class Pessoa : Identificador
{
    public string Nome {get;set;}
    public string Email {get;set;}
    public string Telefone {get;set;}

    

    public void CadastrarPessoa(ref string nome, ref string telefone, ref string email)
    {
        Console.WriteLine("Informe o nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Informe o telefone: ");
        telefone = Console.ReadLine();
        System.Console.WriteLine("Informe o email: ");
        email = Console.ReadLine();
    }
}
