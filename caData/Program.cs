using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construtor por argumentos
            Data data1 = new Data(30, 8, 2021);
            Data data2 = new Data(30,8,2032);
            Data data3 = new Data(31, 12, 2012);

            Console.WriteLine("Comparando " + data1.getDia() + "/" + data1.getMes() + "/" + data1.getAno() + " com " +
                 data2.getDia() + "/" + data2.getMes() + "/" + data2.getAno() + ": " + data1.compara(data2).ToString());

            Console.WriteLine("\nO ano " + data2.getAno() + " é bissexto? " + data2.isBissexto().ToString());

            Console.WriteLine("\nO mês por extenso da data " + data1.getDia() + "/" + data1.getMes() + "/" + data1.getAno() + ": " + data3.getMesExtenso());
            
            Console.ReadLine();
        }
    }
}
