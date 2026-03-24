using System;
using System.Runtime.Versioning;

namespace ProgramaCarros;

public class Moto : Veiculo
{
    public int Cilindradas {get;set;}

    public override string ExibirInformacoes()
    {
        return base.ExibirInformacoes() + $" e {Cilindradas} Cilindradas!";
    }
}
