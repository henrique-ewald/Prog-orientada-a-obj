using System;

namespace ConsoleApp4;

public class Palestrante : Pessoa
{
    public decimal ValorHora {get;set;}

    public override string ObterDescricao()
    {
        return base.ObterDescricao() + $" | Valor/Hora: R$ {ValorHora:F2}";
    }
    
}
