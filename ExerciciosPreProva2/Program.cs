using System;
using ExerciciosPreProva2;

namespace programa;

public class ProgramaMain
{
    public static Clinica[] Consultas;
    public static Cliente[] todosClientes;
    int ContClientes=0;
    public static void Main(string[] args)
    {
        Cliente NovoCliente = new Cliente();
        int opcao = 0;
        int flag = 0;
        do
        {
            Console.WriteLine("Digite 10 para cadastrar um novo cliente");
            Console.WriteLine("Digite 11 para listar todos os cliente");
            Console.WriteLine("Digite 20 para cadastrar uma nova consulta");
            Console.WriteLine("Digite 21 para listar todos as consultas");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 10)
            {
                Cliente Novo = new Cliente();
                Cliente.AdicionaClienteNoVetor(Novo, ref todosClientes);
                NovoCliente = Novo;
                flag=1;
            }
            else if (opcao == 11)
            {
                Cliente.ListarVetor(todosClientes);
            }
            else if (opcao == 20 && flag == 1)
            {
                Clinica Novo = new Clinica(NovoCliente, ref Consultas);
            }
            else if (opcao == 21)
            {
                Cliente.ListarVetor(Consultas);
            }


        }while(opcao != 99);
    }
}