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
        local.id = local.Id();
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
        Palestrante palestrante = new Palestrante();
        palestrante.CadastrarPessoa();
        Console.WriteLine("Informe o Valor Hora em R$: ");
        var valorHora = Console.ReadLine();
        palestrante.id = palestrante.Id();
        palestrante.ValorHora = decimal.Parse(valorHora);

        return palestrante;
    }

    private static Participante CadastrarParticipante()
    {
        string Nome = "";
        string Email = "";
        string Telefone = "";
        Participante qualquer = new Participante();
        qualquer.CadastrarPessoa();
        qualquer.id = qualquer.Id();

        return qualquer;
    }

    public static TipoGenerico[] AdicionaVetor<TipoGenerico>(TipoGenerico cliente, TipoGenerico[] VetorGenerico)
    {
        TipoGenerico[] novoVetor = new TipoGenerico[VetorGenerico.Length + 1];

        int cont;

        for (cont = 0; cont < VetorGenerico.Length; cont++)
        {
            novoVetor[cont] = VetorGenerico[cont];
        }

        novoVetor[novoVetor.Length - 1] = cliente;

        return novoVetor;
    }

    static void Listar<TipoObj>(TipoObj[] meuVetor) where TipoObj : Identificador
    {
        if (meuVetor.Length == 0)
        {
            Console.WriteLine("Nenhum registro encontrado.");
            return;
        }
        for (int i = 0; i < meuVetor.Length; i++)
        {
            Console.WriteLine($"{i + 1} {meuVetor[i].ObterDescricao()}");
        }
    }

    static Participante[] todosParticipantes = [];
    static Palestrante[] todosPalestrantes = [];
    static Local[] TodosLocais = [];

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
            Console.WriteLine("21 - Listar Participantes");
            Console.WriteLine("30 - Cadastrar Palestrante");
            Console.WriteLine("31 - Listar todos os Palestrantes");
            Console.WriteLine("99 - Sair do sistema");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 10)
            {
                var NovoLocal = CadastraLocal();
                TodosLocais = AdicionaVetor(NovoLocal, TodosLocais);
            }
            else if (opcao == 11)
            {
                      
            }
            else if (opcao == 20)
            {
                var NovoParticipante = CadastrarParticipante();
                todosParticipantes = AdicionaVetor(NovoParticipante, todosParticipantes);
            }
            else if (opcao == 21)
            {
                Listar(todosParticipantes);
            }
            else if (opcao == 30)
            {
                var novoPalestrante = CadastrarPalestrante();
                todosPalestrantes = AdicionaVetor(novoPalestrante, todosPalestrantes);
            }
            else if (opcao == 31)
            {
                Listar(todosPalestrantes);
            }

        }while(opcao != 99);
    }
}
