using System;

namespace ConsoleApp4;

public class GestaoDeEventos
{
    private Tipo CadastraGenerico<Tipo>() where Tipo : new()
    {
        return new Tipo();
    }
    private TipoGenerico[] AdicionaVetor<TipoGenerico>(TipoGenerico cliente, TipoGenerico[] VetorGenerico)
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

    private void Listar<TipoObj>(TipoObj[] meuVetor) where TipoObj : Identificador
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

    private Participante[] todosParticipantes = [];
    private Palestrante[] todosPalestrantes = [];
    private Palestra[] todasPalestras = [];
    private Local[] TodosLocais = [];
    private Evento[] todosEventos = [];

    public void coracao(int opcao)
    {
        if (opcao == 10)
        {
            var NovoLocal = CadastraGenerico<Local>();
            TodosLocais = AdicionaVetor(NovoLocal, TodosLocais);
        }
        else if (opcao == 11)
        {
            Listar(TodosLocais);
        }
        else if (opcao == 20)
        {
            var NovoParticipante = CadastraGenerico<Participante>();
            todosParticipantes = AdicionaVetor(NovoParticipante, todosParticipantes);
        }
        else if (opcao == 21)
        {
            Listar(todosParticipantes);
        }
        else if (opcao == 30)
        {
            var novoPalestrante = CadastraGenerico<Palestrante>();
            todosPalestrantes = AdicionaVetor(novoPalestrante, todosPalestrantes);
        }
        else if (opcao == 31)
        {
            Listar(todosPalestrantes);
        }
        else if (opcao == 40)
        {
            var novaPalestra = new Palestra(todosParticipantes, todosPalestrantes);
            todasPalestras = AdicionaVetor(novaPalestra, todasPalestras);
        }
        else if (opcao == 41)
        {
            Listar(todasPalestras);
        }
        else if (opcao == 50)
        {
            var novoEvento = new Evento(todosParticipantes, todosPalestrantes);
            todosEventos = AdicionaVetor(novoEvento, todosEventos);
        }
        else if (opcao == 51)
        {
            Listar(todosEventos);
        }
    }
}
