using System;

namespace ConsoleApp4;

public class Palestra : Identificador
{
    public string Titulo {get;set;}
    public Participante[] Participantes {get;set;}
    public Palestrante[] Palestrantes {get;set;}
    // public override string Id()
    // {
    //    return Guid.NewGuid().ToString();
       
    // }
   
}
