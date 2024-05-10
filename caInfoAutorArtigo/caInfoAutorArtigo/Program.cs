using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caInfoAutorArtigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NomeProprio nome = new NomeProprio();

            Console.Write("Informe o nome completo do autor: ");
            nome.Nome_completo = Console.ReadLine();

            Console.WriteLine();

            nome.ImprimeNomePaper();

            Console.ReadLine();
        }
    }
}
