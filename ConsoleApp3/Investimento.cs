using System;

namespace ConsoleApp3;

public class Investimento
{
    public string NomeDoInvestidor {get; private set;}
    private double ValorAplicado;
    private double TaxaDeJuros;
    private int MesesInvestidos;

    public Investimento
    (
        string NomeDoInvestidor,
        double ValorAplicado,
        double TaxaDeJuros,
        int MesesInvestidos
    )
    {
        this.NomeDoInvestidor = NomeDoInvestidor;
        this.ValorAplicado = ValorAplicado;
        this.TaxaDeJuros = TaxaDeJuros;
        this.MesesInvestidos = MesesInvestidos;
    }
    public Double RetornaRendimento()
    {
        return CalculaMontante();
    }

    private Double CalculaMontante()
    {
        double montante;
        montante = ValorAplicado * Math.Pow(1+TaxaDeJuros, MesesInvestidos);
        return montante;
    }
}
