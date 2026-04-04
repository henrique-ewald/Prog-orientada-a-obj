using System;

namespace ConsoleApp4;

public class Programa
{
    private static void Main(string[] args)
    {
        Local localDoEvento;
        Evento evento;
        Palestra palestra;
        GestaoDeEventos Geral = new GestaoDeEventos();

        Console.WriteLine("Sistema de Gestão de Eventos");
        int opcao;
        do
        {
            Console.WriteLine("10 - Cadastrar Local");
            Console.WriteLine("11 - Listar todos os Locais");
            Console.WriteLine("20 - Cadastrar Participante");
            Console.WriteLine("21 - Listar todos os Participantes");
            Console.WriteLine("30 - Cadastrar Palestrante");
            Console.WriteLine("31 - Listar todos os Palestrantes");
            Console.WriteLine("40 - Cadastrar Palestra");
            Console.WriteLine("41 - Listar todas as Palestras");
            Console.WriteLine("50 - Cadastrar Eventos");
            Console.WriteLine("51 - Listar todos os Eventos");
            Console.WriteLine("99 - Sair do sistema");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 10)      Geral.coracao(10);
            else if (opcao == 11) Geral.coracao(11);

            else if (opcao == 20) Geral.coracao(20);
            else if (opcao == 21) Geral.coracao(21);

            else if (opcao == 30) Geral.coracao(30);
            else if (opcao == 31) Geral.coracao(31);

            else if (opcao == 40) Geral.coracao(40);
            else if (opcao == 41) Geral.coracao(41);

            else if (opcao == 50) Geral.coracao(50);
            else if (opcao == 51) Geral.coracao(51);

        }while(opcao != 99);
    }
}
