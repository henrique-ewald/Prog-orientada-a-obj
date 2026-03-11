using System;

namespace ConsoleApp4;

public class Evento
{
    public DateTime Inicio {get;set;}
    public DateTime Fim {get;set;}
    public Local local {get;set;}
    public Palestra[] Palestras {get;set;}
}
