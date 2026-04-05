using System;

namespace ExerciciosPreProva2;

public class AnimalEstimacao : Identificador
{
    private string Nome;
    private string Especie;
    private string Raca;
    private int Idade;
    public AnimalEstimacao()
    {
        Console.WriteLine("Digite o nome do animal de estimação:");
        Nome = Console.ReadLine();
        Console.WriteLine("Digite a espécie do animal de estimação:");
        Especie = Console.ReadLine();
        Console.WriteLine("Digite a raça do animal de estimação:");
        Raca = Console.ReadLine();
        Console.WriteLine("Digite a idade do animal de estimação:");
        Idade = int.Parse(Console.ReadLine());
        ID = Id();
    }
    public override string ObterDescricao()
    {
        return base.Id() + $"\nNome do animal de estimação: {Nome}\nEspécie do animal de estimação: {Especie}\nRaça do animal de estimação: {Raca}\nIdade do animal de estimação: {Idade}\n";
    }
}
