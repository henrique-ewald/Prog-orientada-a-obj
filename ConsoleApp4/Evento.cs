using System;

namespace ConsoleApp4;

public class Evento : Identificador
{
    public Evento(Participante[] todosParticipantes, Palestrante[] todosPalestrantes)
    {
        id = Id();
        Console.WriteLine("Digite a data de inicio do evento");
        Inicio = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Digite a data de termino do evento");
        Fim = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Digite os dados do local do evento");
        local = new Local();
        Console.WriteLine("Quantas palestras você quer cadastrar?: ");
        int cont = int.Parse(Console.ReadLine());
        EventoPalestras = new Palestra[cont];
        for (int i=0; i < cont; i++)
            EventoPalestras[i] = new Palestra(todosParticipantes, todosPalestrantes);
        }
    private DateTime Inicio {get;set;}
    private DateTime Fim {get;set;}
    private Local local {get;set;}
    private Palestra[] EventoPalestras {get;set;}

    public override string ObterDescricao()
    {
        return base.ObterDescricao() + $"\nInicio: {Inicio}\nFinal: {Fim}\nNome do local: {local.Nome}\nLocal do evento: {local.Endereco}\nCapacidade do local: {local.Capacidade}";
    }
}
