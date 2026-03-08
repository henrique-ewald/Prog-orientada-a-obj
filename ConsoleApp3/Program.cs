using System;
using ConsoleApp3;

namespace Programa;

public class Programa
{
    static void Main(string[] args)
    {
        Investimento Rafa = new Investimento
        (
            "Rafa querida",
            13000,
            0.01275,
            12
        );
        Console.WriteLine(Rafa.NomeDoInvestidor);
        double montante = Rafa.RetornaRendimento();
        double rendimento = montante - 13000;
        Console.WriteLine($"Seu dinheiro rendeu: {rendimento}!! Parabens meu amor!\nAgora voce tem {montante} Na conta!");
    }
}