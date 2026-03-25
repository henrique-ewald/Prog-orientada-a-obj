using System;

namespace ProgramaCarros;

public class Carro : Veiculo
{
    public int QuantidadePortas {get;set;}

    public Carro(string Marca, string Modelo, int Ano, double Velocidade, int QuantidadePortas)
    {
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Ano = Ano;
        this.Velocidade = Velocidade;
        this.QuantidadePortas = QuantidadePortas;
    }

    public override string ExibirInformacoes()
    {
        return base.ExibirInformacoes() + $", {QuantidadePortas} portas";
    }

}
