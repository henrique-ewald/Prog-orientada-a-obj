using System;

namespace ExerciciosPreProva3;

public class Emprestimo : Identificador
{
    public decimal Multa {get;set;}
    public DateTime Hoje {get;set;}
    public DateTime Reserva {get;set;}
    public DateTime Devolucao {get;set;}
    public Usuario Leitor {get;set;}
    public Emprestimo(Usuario[] TodosUsuarios)
    {
        Console.WriteLine("Insira o ID do leitor:");
        string idLeitor = Console.ReadLine();
        if (TodosUsuarios.Length == 0){Console.WriteLine("Não tem usuario nenhum.\n"); return;}
        for (int i=0; i < TodosUsuarios.Length; i++)
        {
            if (TodosUsuarios[i].ID == idLeitor)
            {
                Leitor = TodosUsuarios[i];
                Console.WriteLine("Insira o dia de hoje:");
                Hoje = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Insira o dia de reserva:");
                Reserva = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Insira o dia de devolucao:");
                Devolucao = DateTime.Parse(Console.ReadLine());
                Multa = 0;
            }
        }
    }
    public decimal ConfereData(Usuario leitor)
    {
        if (Hoje > Devolucao)
        {
            Console.WriteLine($"Usuário em questão: {leitor.Nome}\nID do mesmo: {Leitor.ID}\n");    
            Console.WriteLine("Data de devolução expirada! Aplicando multa\n");    
            for (int i=0; i < (Hoje - Devolucao).TotalDays; i++)
            {
                Multa += 2;
            }
            return Multa;
        }
        else
        {
            Console.WriteLine("Ainda não passou da data, multa permanece nula");
            return Multa;
        }
    }

}
