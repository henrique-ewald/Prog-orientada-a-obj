using System;
using System.Security.Cryptography.X509Certificates;

public class Ola
{
    public string nome;
    public Ola(string nome)
    {
        this.nome = nome;
    }
    public Ola() : this("Random")
    {
        Console.WriteLine("Nao escreveu nada.");
    }
    public void SayHello()
    {
        Console.WriteLine($"\nOla, {nome}, como voce esta?\n");
    }
}

public class Program
{
public static void Main(string[] args)
    {
        Ola Hey = new Ola(Console.ReadLine());
        Hey.SayHello();
    }
}