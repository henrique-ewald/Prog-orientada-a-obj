using System;
using ExerciciosPreProva3;

class ProgramBiblioteca
{
    static void Main(string[] args)
    {
        Usuario[] TodosUsuarios = [];
        Livro[] TodosLivros = [];
        Emprestimo[] TodosEmprestimos = [];
        int opcao;
        do
        {
            Console.WriteLine("\n----------------------------------------\n");
            Console.WriteLine("Digite 10 para registrar um novo usuario:\n");
            Console.WriteLine("Digite 20 para registrar um novo livro:\n");
            Console.WriteLine("Digite 30 para registrar um emprestimo de um livro:\n");
            Console.WriteLine("Digite 99 para SAIR\n");
            Console.WriteLine("\n----------------------------------------\n");
            opcao = int.Parse(Console.ReadLine());
            if(TodosUsuarios.Length != 0 && TodosEmprestimos.Length != 0)
            {
                for(int i=0 ;i < TodosEmprestimos.Length; i++)
                {
                    TodosEmprestimos[i].ConfereData(TodosEmprestimos[i].Leitor);
                }
            }
            if(opcao == 10)
            {
                Usuario Novo = new Usuario();
                TodosUsuarios = Usuario.AdicionaGenerico(Novo, TodosUsuarios);
            }
            if(opcao == 20)
            {
                Livro Novo = new Livro();
                TodosLivros = Usuario.AdicionaGenerico(Novo, TodosLivros);
            }
            if(opcao == 30)
            {
                Emprestimo Novo = new Emprestimo(TodosUsuarios);
                TodosEmprestimos = Usuario.AdicionaGenerico(Novo, TodosEmprestimos);
            }
        }while (opcao != 99);
    }
}