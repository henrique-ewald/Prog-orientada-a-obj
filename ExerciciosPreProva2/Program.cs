using System;
using ExerciciosPreProva2;

namespace programa;

public class ProgramaMain : Identificador
{
    public static void Main(string[] args)
    {
        Cliente Rafa = new Cliente();
        Console.WriteLine(Rafa.ObterDescricao());
        Console.WriteLine(Rafa.pet.ObterDescricao());
        int opcao = 0;
        do
        {
            Console.WriteLine("Digite 10 para cadastrar um novo cliente");


            // FALTA CRIAR UMA CLASSE "CLINICA" QUE RECEBE NO CONSTRUTOR O CLIENTE, PARA
            // SALVAR OS DADOS DE UMA CONSULTA..




        }while(opcao != 99);
    }
}