using System;

namespace ProgramaCarros;

public abstract class Veiculo
{
    public string Marca {get;set;}
    public string Modelo {get;set;}
    public int Ano {get;set;}
    public double Velocidade {get;set;}



    public virtual string ExibirInformacoes()
    {
        return $"É um {Marca}, modelo {Modelo}, ano {Ano} e chega a {Velocidade}";
    }
}
