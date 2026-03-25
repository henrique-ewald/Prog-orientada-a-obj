using System;

namespace ConsoleApp4;

public class Pessoa : Identificador
{
    public string Nome {get;set;}
    public string Email {get;set;}
    public string Telefone {get;set;}
    
    //ref string nome, ref string telefone, ref string email
    public void CadastrarPessoa(Pessoa nova)
    {
        nova = new Pessoa();

        Console.WriteLine("Informe o nome: ");
        nova.Nome = Console.ReadLine();
        Console.WriteLine("Informe o telefone: ");
        nova.Telefone = Console.ReadLine();
        System.Console.WriteLine("Informe o email: ");
        nova.Email = Console.ReadLine();
    }
}
