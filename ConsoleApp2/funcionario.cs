using System;

namespace ConsoleApp2;

public class Funcionario
{
    public string Nome { get; private set; }
    public string Cargo { get; private set; }
    public decimal SalarioBruto { get; private set; }

    public Funcionario(string Nome, string Cargo, decimal SalarioBruto)
    {
        this.Nome = Nome;
        this.Cargo = Cargo;
        this.SalarioBruto = SalarioBruto;
    }

    private decimal SalarioLiquido { get; set; }
    private decimal FGTS { get; set; }
    private void DescontarINSS()
    {
        SalarioLiquido = SalarioBruto;
        if (SalarioBruto <= 1518)
        {
            SalarioLiquido -= SalarioBruto * 0.075m;
        }
        else if (SalarioLiquido <= 2793.88m)
        {
            SalarioLiquido -= SalarioBruto * 0.09m;
        }
        else if (SalarioLiquido <= 4190.83m)
        {
            SalarioLiquido -= SalarioBruto * 0.12m;
        }
        else if (SalarioLiquido > 4190.83m)
        {
            SalarioLiquido -= SalarioBruto * 0.14m;
        }
    }
    private void DescontarIR()
    {
        if (SalarioLiquido < 2259.20m){;}
        else if (SalarioLiquido < 2826.65m)
        {
            SalarioLiquido -= SalarioLiquido * 0.075m;
        }
        else if (SalarioLiquido < 3751.05m)
        {
            SalarioLiquido -= SalarioLiquido * 0.15m;
        }
        else if (SalarioLiquido < 4664.68m)
        {
            SalarioLiquido -= SalarioLiquido * 0.225m;
        }
        else if (SalarioLiquido > 4664.68m)
        {
            SalarioLiquido -= SalarioLiquido * 0.275m;
        }
    }
    private void ContribuirFGTS()
    {
        FGTS = SalarioBruto * 0.08m;
        Console.WriteLine($"\nO FGTS é igual a: {FGTS}\n");
    }
    public decimal GerarSalarioLiquido()
    {
        DescontarINSS();
        DescontarIR();
        ContribuirFGTS();

        return SalarioLiquido;
    }
}
