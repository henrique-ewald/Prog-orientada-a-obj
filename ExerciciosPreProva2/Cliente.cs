using System;

namespace ExerciciosPreProva2;

public class Cliente : Identificador
{
    private string Nome;
    private string Email;
    private string Numero;
    public AnimalEstimacao pet {get; private set;}
    public Cliente() 
    {
        Console.WriteLine("Digite o nome do cliente:");
        Nome = Console.ReadLine();
        Console.WriteLine("Digite o email do cliente:");
        Email = Console.ReadLine();
        Console.WriteLine("Digite o numero do cliente:");
        Numero = Console.ReadLine();
        ID = Id();
        pet = new AnimalEstimacao();

    }
    public override string ObterDescricao()
    {
        return base.Id() + $"\nNome do cliente: {Nome}\nEmail do cliente: {Email}\nNumero do cliente: {Numero}";
    }
}
