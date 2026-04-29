using System;
using Lanchonete;

namespace Program;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escreva (1) se for Brasileiro\nEscreva (2) se for Argentino\n");
        Pedido Novo;
        if (int.Parse(Console.ReadLine()) == 1)
        {
            Novo = new IMenuBR();
        }
        else
        {
            Novo = new IMenuAR();
        }
        
        Console.WriteLine(Novo.Prato1());
        Console.WriteLine(Novo.Prato2());
        Console.WriteLine(Novo.Prato3());
        
    }
}