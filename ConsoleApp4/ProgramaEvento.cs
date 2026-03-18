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
        local.Id = local.NovoIdentificador();
        local.Nome = nomeLocal;
        local.Endereco = enderecoLocal;
        local.Capacidade = capacidadeLocal;
        return local;
    }
    private static Palestrante CadastrarPalestrante()
    {
        string Nome = "";
        string Email = "";
        string Telefone = "";
        System.Console.WriteLine("Informe o Valor Hora em R$: ");
        var valorHora = Console.ReadLine();
        Palestrante palestrante = new Palestrante();
        palestrante.CadastrarPessoa(ref Nome, ref Email, ref Telefone);
        palestrante.Id = palestrante.NovoIdentificador();
        palestrante.ValorHora = decimal.Parse(valorHora);

        return palestrante;
    }

    private static Participante CadastrarParticipante()
    {
        Console.
    }

    static Palestrante[] AdicionarPalestrante(Palestrante cliente)
    {
        Palestrante[] novoVetor = new Palestrante[todosPalestrantes.Length + 1];

        int cont;

        for (cont = 0; cont < todosPalestrantes.Length; cont++)
        {
            novoVetor[cont] = todosPalestrantes[cont];
        }

        novoVetor[novoVetor.Length - 1] = cliente;

        return novoVetor;
    }
    static Participante[] todosParticipantes = [];
    static Palestrante[] todosPalestrantes = [];

    private static void Main(string[] args)
    {
        Local localDoEvento;
        Evento evento;
        Palestra palestra;

        Console.WriteLine("Sistema de Gestão de Eventos");
        int opcao = 0;
        do
        {
            Console.WriteLine("10 - Cadastrar Local");
            Console.WriteLine("20 - Cadastrar Participante");
            Console.WriteLine("30 - Cadastrar Palestrante");
            Console.WriteLine("31 - Listar todos os Palestrantes");
            Console.WriteLine("99 - Sair do sistema");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 10)
            {
                localDoEvento = CadastraLocal();
            }
            else if (opcao == 30)
            {
                //Pede para o usuario as informacoes e gera o objeto Palestrante
                var novoPalestrante = CadastrarPalestrante();
                //aqui esta adicionando no vetor de todosPalestrantes.
                todosPalestrantes = AdicionarPalestrante(novoPalestrante);
            }
            else if (opcao == 31)
            {
                foreach (var item in todosPalestrantes)
                {
                    Console.WriteLine($"{item.Nome} - {item.Email} - {item.Telefone}");
                }   
            }

        }while(opcao != 99);
    }
}
