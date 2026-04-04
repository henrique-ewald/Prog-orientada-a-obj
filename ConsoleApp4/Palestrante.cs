using System;

namespace ConsoleApp4;

public class Palestrante : Pessoa
{
    public Palestrante()
    {
        CadastrarPessoa();
        Console.WriteLine("Informe o Valor Hora em R$: ");
        this.ValorHora = decimal.Parse(Console.ReadLine());
    }
    private decimal ValorHora {get;set;}

    public override string ObterDescricao()
    {
        return base.ObterDescricao() + $" | Valor/Hora: R$ {ValorHora:F2}";
    }
    
}
