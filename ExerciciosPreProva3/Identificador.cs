using System;

namespace ExerciciosPreProva3;

public abstract class Identificador
{
    public string ID {get;set;}
    protected string ObterId()
    {
        return Guid.NewGuid().ToString();
    }
    public virtual string ObtemInformacao()
    {
        return ObterId();
    }

}
