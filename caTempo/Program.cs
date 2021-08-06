using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construtor padrão
            Tempo t1 = new Tempo();
            Console.WriteLine("Construtor padrão");
            Console.Write("Horário: ");
            t1.imprimeTempo();

            // Construtor com argumentos
            Console.WriteLine("\nConstrutor com argumentos");
            Console.Write("Horário: ");
            Tempo t2 = new Tempo(13, 58, 23);
            t2.imprimeTempo();

            // Lendo valores do console
            Console.WriteLine("\nLendo valores do console");
            Tempo t3 = new Tempo();
            t3.registraHorario();

            // Apresentando horário informado pelo usuário 
            Console.Write("\nHorário informado pelo usuário: ");
            t3.imprimeTempo();

            // Método para somar horários
            Console.WriteLine("\nSomando Horários");
            Console.Write("Horário: ");
            t2.soma(t3).imprimeTempo();

            Console.ReadLine();
        }
    }
}
