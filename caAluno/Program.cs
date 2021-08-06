using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando o construtor padrão
            Aluno aluno1 = new Aluno();

            Console.WriteLine("Construtor padrão \n");
            Console.WriteLine("Nome: " + aluno1.getNome());
            Console.WriteLine("Matricula: " + aluno1.getMatricula()); 
            Console.WriteLine("Telefone: " + aluno1.getTelefone() + "\n");

            // Usando o construtor com argumetos
            Aluno aluno2 = new Aluno("Ariana","11611EBI029","(34) XXXX-XXXX");

            Console.WriteLine("Construtor com argumentos \n");
            Console.WriteLine("Nome: " + aluno2.getNome());
            Console.WriteLine("Matricula: " + aluno2.getMatricula());
            Console.WriteLine("Telefone: " + aluno2.getTelefone() + "\n");

            // Lendo valores do console
            Aluno aluno3 = new Aluno();
            Console.Write("Informe o nome do aluno: ");
            aluno3.setAluno();
            Console.Write("Informe o numero de matricula do aluno: ");
            aluno3.setMatricula();
            Console.Write("Informe o telefone de contato do aluno: ");
            aluno3.setTelefone();

            // Exibindo as informações 
            Console.WriteLine("\nDados do aluno informado pelo usuario \n");
            Console.WriteLine("Nome: " + aluno3.getNome());
            Console.WriteLine("Matricula: " + aluno3.getMatricula());
            Console.WriteLine("Telefone: " + aluno3.getTelefone() + "\n");

            Console.ReadLine();

        }
    }
}
