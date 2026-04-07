using System;

namespace ExerciciosPreProva3;

public class Livro : Identificador
{
    public string Titulo {get;set;}
    public string Autor {get;set;}
    public string ISBN {get;set;}
    public DateTime Lancamento {get;set;}
    public string Categoria {get;set;}
    public bool Disponivel {get;set;}
    public Livro()
    {
        Console.WriteLine("Insira o Título da obra:");
        Titulo = Console.ReadLine();
        Console.WriteLine("Insira o Autor da obra:");
        Autor = Console.ReadLine();
        Console.WriteLine("Insira o ISBN da obra:");
        ISBN = Console.ReadLine();
        Console.WriteLine("Insira a data de lançamento da obra:");
        Lancamento = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Insira a Categoria da obra:");
        Categoria = Console.ReadLine();
        Console.WriteLine("Informe se o livro esta disponivel ou não: (1/0)");
        Disponivel = bool.Parse(Console.ReadLine());
    }


}
