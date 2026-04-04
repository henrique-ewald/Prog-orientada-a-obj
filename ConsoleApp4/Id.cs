using System;

namespace ConsoleApp4;

public abstract class Identificador
{
    protected string id;
   
    protected virtual string Id()
    {
        return Guid.NewGuid().ToString();
    }
    public virtual string ObterDescricao()
    {
        return Id();
    }
    
}
