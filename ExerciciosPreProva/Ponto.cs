using System;

namespace ExerciciosPreProva;

public class Ponto
{

    private double x;
    private double y;
    public Ponto(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public Ponto(Ponto cord)
    {
        x = cord.x;
        y = cord.y;
    }
    public Ponto() : this(1, 1)
    {
        x = 1;
        y = 1;
    }
    public string RetornaDescricao()
    {
        return $"({x},{y})\n";
    }
}   
