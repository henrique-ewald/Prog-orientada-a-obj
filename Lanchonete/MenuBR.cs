using System;

namespace Lanchonete;

public class IMenuBR : Pedido
{
    public string Prato1()
    {
        return $"Arroz e Feijão\n";
    }
    public string Prato2()
    {
        return $"Batata Assada";
    }
    public string Prato3()
    {
        return $"Lasanha";
    }
    

}
