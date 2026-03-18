using System;

namespace ConsoleApp4;

public abstract class Identificador
{
    public string Id {get;set;}

    public string NovoIdentificador()
    {
        return Guid.NewGuid().ToString();
    }
}
