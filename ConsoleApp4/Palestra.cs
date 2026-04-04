using System;

namespace ConsoleApp4;

public class Palestra : Identificador
{
    public Palestra(Participante[] todosParticipantes, Palestrante[] todosPalestrantes)
    {
        Console.WriteLine("Digite o Título da palestra:");
        Titulo = Console.ReadLine();
        Participantes = todosParticipantes;
        Palestrantes = todosPalestrantes;
        id = Id();
    }
    private string Titulo {get;set;}
    private Participante[] Participantes {get;set;}
    private Palestrante[] Palestrantes {get;set;}
    public override string ObterDescricao()
    {
        return $"[ID: {id}] Título: {Titulo} | Participantes: {Participantes?.Length ?? 0} | Palestrantes: {Palestrantes?.Length ?? 0}";
    }
}
