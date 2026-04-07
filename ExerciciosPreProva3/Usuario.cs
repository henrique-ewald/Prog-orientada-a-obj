using System;

namespace ExerciciosPreProva3;

public class Usuario : Identificador
{
    public string Nome {get;set;}
    public string Email {get;set;}
    public Livro[] LivrosEmPosse {get;set;}
    public Livro[] LivrosEmprestados {get;set;}
    public Usuario()
    {
        Console.WriteLine("Insira o nome do Usuario:");
        Nome = Console.ReadLine();
        Console.WriteLine("Insira o Email do Usuario:");
        Email = Console.ReadLine();
        ID = ObterId();
    }
    public static Tipo[] AdicionaGenerico<Tipo>(Tipo novo, Tipo[] Vetor)
    {
        Tipo[] NovoVetor = new Tipo[Vetor.Length+1];
        if (Vetor.Length == 0)
        {
            Vetor = [];
            Vetor[0] = novo;// Aqui da dando erro, porque diz que vetor[0] não existe.
        }
        for (int i=0; i < Vetor.Length; i++)
        {
            NovoVetor[i] = Vetor[i];
        }
        NovoVetor[Vetor.Length] = novo;
        
        return NovoVetor;
    }
    public static TipoRemove[] RemoveGenerico<TipoRemove>(TipoRemove Livro, TipoRemove[] Vetor) where TipoRemove : Identificador
    {
        TipoRemove[] NovoVetor = new TipoRemove[Vetor.Length-1];
        if (Vetor.Length == 0)
        {
            Console.WriteLine("O vetor esta vazio, não é possivel remover nada dele\n");
            return NovoVetor;
        }
        for (int i=0; i< Vetor.Length; i++)
        {
            if (Vetor[i].ID == Livro.ID)
            {
                continue;
            }
            else
            {
                NovoVetor[i] = Vetor[i];
            }
        }
        return NovoVetor;
    }
    public static void EnviaNotificacao(Emprestimo hoje, Emprestimo devolucao, Usuario Novo)
    {
        if(hoje.Hoje > devolucao.Devolucao)
        {
            hoje.ConfereData(Novo);
        }
        else if (hoje.Hoje == devolucao.Devolucao)
        {
            Console.WriteLine($"O período de devolução acaba hoje! Devolva o livro reservado no dia: {hoje.Reserva}");
        }
    }


}
