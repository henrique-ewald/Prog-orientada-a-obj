using System;

namespace ConsoleApp4;

public class Palestra : Identificador
{
    public string Titulo {get;set;}
    public Participante[] Participantes {get;set;}
    public Palestrante[] Palestrantes {get;set;}
   public override string ObterDescricao()
    {
        return $"[ID: {id}] Título: {Titulo} | Participantes: {Participantes?.Length ?? 0} | Palestrantes: {Palestrantes?.Length ?? 0}";
    }
}
