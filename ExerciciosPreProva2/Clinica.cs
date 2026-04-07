using System;
using programa;

namespace ExerciciosPreProva2;

public class Clinica : Identificador
{
    private AnimalEstimacao petAtendido;
    private DateTime dataConsulta;
    private string descricaoConsulta;
    private string Tratamento;
    public Clinica(Cliente novo, ref Clinica[] consultas)
    {
        Console.WriteLine("Digite a data da consulta:\n");
        dataConsulta = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Digite informações da consulta:\n");
        descricaoConsulta = Console.ReadLine();
        Console.WriteLine("Digite a forma de tratamento:\n");
        Tratamento = Console.ReadLine();
        petAtendido = novo.pet;
        ID = Id();
        AdicionaConsultaNoVetor(this, ref consultas);
    }
    public static void AdicionaConsultaNoVetor(Clinica nova, ref Clinica[] consultas)
    {
        if (consultas == null) consultas = new Clinica[0];
        Clinica[] novoVetor = new Clinica[consultas.Length + 1];
        for (int i = 0; i < consultas.Length; i++)
        {
            novoVetor[i] = consultas[i];
        }
        novoVetor[consultas.Length] = nova;
        consultas = novoVetor;
    }
    public override string ObterDescricao()
    {
        return base.ObterDescricao() + $"\nPet: {petAtendido.ObterDescricao()} - {dataConsulta}\n{descricaoConsulta}\nTratamento: {Tratamento}";
    }
    

}
