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
        Console.WriteLine("Informe o Valor Hora em R$: ");
        var valorHora = Console.ReadLine();
        Palestrante palestrante = new Palestrante();
        palestrante.CadastrarPessoa(palestrante);
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
        qualquer.CadastrarPessoa(qualquer);
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
                todosPalestrantes = (Palestrante)AdicionaVetor(novoPalestrante, //AQUI FALTA IMPLEMENTAR);
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
