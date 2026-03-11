using System;

namespace ConsoleApp4;

public class Programa
{
    private static Local CadastraLocal()
    {
        Console.WriteLine("Informe o nome do local:");
        var nomeLocal = Console.ReadLine();
        Console.WriteLine("Informe o endereco do local:");
        var enderecoLocal = Console.ReadLine();
        Console.WriteLine("Informe a capacidade do local:");
        int capacidadeLocal = int.Parse(Console.ReadLine());
        Local local = new Local();
        local.Nome = nomeLocal;
        local.Endereco = enderecoLocal;
        local.Capacidade = capacidadeLocal;
        return local;
    }
    private static void Main(string[] args)
    {
        Local localDoEvento;
        Evento evento;
        Palestra palestra;

        Evento e1 = new Evento();
        
        Console.WriteLine("Sistema de gestao de eventos:\n");
        int opcao = 0;
        do
        {
            Console.WriteLine("1 - Cadastrar Local");
            Console.WriteLine("2 - Cadastrar Participante");
            Console.WriteLine("1 - Sair do sistema");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                localDoEvento = CadastraLocal();
            }
        } while (opcao != 99);

    }
}


