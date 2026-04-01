using System;

namespace ConsoleApp4;

public class Pessoa : Identificador
{
    public string Nome {get;set;}
    public string Email {get;set;}
    public string Telefone {get;set;}
    
    public void CadastrarPessoa()
    {
        Console.WriteLine("Informe o nome: ");
        this.Nome = Console.ReadLine();
        Console.WriteLine("Informe o telefone: ");
        this.Telefone = Console.ReadLine();
        System.Console.WriteLine("Informe o email: ");
        this.Email = Console.ReadLine();
    }
    public override string ObterDescricao()
    {
        return $"[ID: {id}] Nome: {Nome} | Email: {Email} | Telefone: {Telefone}";
    }
}
