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
    public static void AdicionaClienteNoVetor(Cliente novo, ref Cliente[] Consultas)
    {
        if (Consultas == null) Consultas = new Cliente[0];
        Cliente[] novoVetor = new Cliente[Consultas.Length+1];
        int cont;
        for(cont = 0; cont < Consultas.Length; cont++)
        {
            novoVetor[cont] = Consultas[cont];
        }
        novoVetor[Consultas.Length] = novo;

        Consultas = novoVetor;
    }
    public static void ListarVetor<Tipo>(Tipo[] vetor) where Tipo : Identificador
    {
        int i;
        if (vetor.Length == 0)
        {
            Console.WriteLine("Não tem nada no vetor.");
            return;
        }
        for (i=0; i < vetor.Length; i++)
        {
            Console.WriteLine($"{i + 1}:\n {vetor[i].ObterDescricao()}");
        }
    }
    public override string ObterDescricao()
    {
        return base.Id() + $"\nNome do cliente: {Nome}\nEmail do cliente: {Email}\nNumero do cliente: {Numero}\nPet do cliente: {pet.ObterDescricao()}";
    }
}
