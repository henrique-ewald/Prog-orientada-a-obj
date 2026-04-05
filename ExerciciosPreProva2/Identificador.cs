using System;

namespace ExerciciosPreProva2;

public abstract class Identificador
{
    public string ID;

    protected virtual string Id()
    {
        return Guid.NewGuid().ToString();
    }
    public virtual string ObterDescricao()
    {
        return Id();
    }
}
