using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoDisciplina
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Ariana", "11611EBI029", 10);

            Materia materia1 = new Materia("Processamento de Sinais Biomédicos", "FEELT31612");
            Materia materia2 = new Materia("Álgebra Matricial e Geometria Analítica", "FAMAT39106");

            aluno1.adicionarMateria(materia1);
            aluno1.adicionarMateria(materia2);

            aluno1.imprimirDados();

            Console.ReadLine();

        }
    }
}
