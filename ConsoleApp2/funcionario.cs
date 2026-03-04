using System;

namespace ConsoleApp2;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public decimal SalarioBruto { get; set; }

    private decimal SalarioLiquido { get; set; }
    private void DescontarINSS()
    {
        if (SalarioBruto <= 1518)
        {
            SalarioLiquido = SalarioBruto * 0.925m;
        }
    }
    private void DescontarIR()
    {
        
    }
    private void ContribuirFGTS()
    {
        
    }
    public decimal GerarSalarioLiquido()
    {
        DescontarINSS();
        DescontarIR();
        ContribuirFGTS();

        return SalarioLiquido;
    }
}
