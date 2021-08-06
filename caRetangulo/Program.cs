using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo(); // instanciando (criando um objeto da classe Retangulo)

            /*
            Console.WriteLine("Perimetro = " + ret.Perimetro()); // imprimindo no Console

            ret.setAltura(3.0); // alterando o valor da altura
            Console.WriteLine("Perimetro = " + ret.Perimetro());
            */

            // definindo os valores dos atributos do objeto da classe Retangulo
            ret.setAltura(5.0);
            ret.setLargura(7.5);

            // apresentando no console os valores dos atributos do objeto
            Console.WriteLine("Altura do retângulo = " + ret.getAltura());
            Console.WriteLine("Largura do retângulo = " + ret.getLargura() + "\n");

            // apresentando no console o valor do método Perimetro
            Console.WriteLine("Perimetro = " + ret.Perimetro());

            // apresentando no console o valor do método Area
            Console.WriteLine("Area = " + ret.Area());

            // Usando o construtor para definir os valores dos atributos 
            Retangulo ret2 = new Retangulo(2.0,3.0);

            Console.WriteLine("\n Altura do retângulo = " + ret2.getAltura());
            Console.WriteLine("Largura do retângulo = " + ret2.getLargura() + "\n");

            Console.ReadLine();
        }
    }
}
