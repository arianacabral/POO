using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGerente
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado empregado = new Empregado("Carlos", "Contabilidade");
            Gerente gerente = new Gerente("Marcus", "Finanças", "Maria");

            Console.WriteLine("\tDados do Gerente \n");
            Console.WriteLine("Nome do Gerente: " + gerente.getNome());
            Console.WriteLine("Seção do Gerente: " + gerente.getSecao());
            Console.WriteLine("Nome da Secretaria: " + gerente.getSecretaria());

            Console.WriteLine("\n\tDados do Empregado \n");
            Console.WriteLine("Nome do Empregado: " + empregado.getNome());
            Console.WriteLine("Seção do Empregado: " + empregado.getSecao());

            Console.Read();
        }
    }
}
