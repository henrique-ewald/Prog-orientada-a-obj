using System;

namespace ConsoleApp4;

public abstract class Identificador
{
    public string id;
   
    public virtual string Id()
    {
          return Guid.NewGuid().ToString();
    }
    public virtual string ObterDescricao()
    {
        return Id();
    }
    
}
