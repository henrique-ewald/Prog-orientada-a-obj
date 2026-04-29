using System;

namespace Lanchonete;

public class IMenuAR : Pedido
{
    public string Prato1()
    {
        return $"Arroz y frijoles\n";
    }
    public string Prato2()
    {
        return $"Patatas asadas";
    }
    public string Prato3()
    {
        return $"Lasaña";
    }
}
