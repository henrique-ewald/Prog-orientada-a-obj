using System;

namespace ConsoleApp4;

public class Local : Identificador
{
    public string Endereco {get;set;}
    public string Nome {get;set;}
    public int Capacidade {get;set;}

    public override string ObterDescricao()
    {
        return $"[ID: {id}] Nome: {Nome} | Endereço: {Endereco} | Capacidade: {Capacidade}";
    }
}
