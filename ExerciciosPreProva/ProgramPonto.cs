using System;
using ExerciciosPreProva;

namespace ProgramaPonto;


public class Programa
{
    static void Main(string[] args)
    {
        Ponto coordenada11 = new Ponto();
        Console.WriteLine(coordenada11.RetornaDescricao());
        Ponto coordenada = new Ponto(2, 3);
        Console.WriteLine(coordenada.RetornaDescricao());
    }
}