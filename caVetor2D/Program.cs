using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor2D
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando o construtor padrão
            Vetor v1 = new Vetor();

            Console.WriteLine("Construtor padrão");
            Console.WriteLine("Vetor: (" + v1.getX() + ", " + v1.getY()+") \n");

            // Usando o construtor com argumetos
            Vetor v2 = new Vetor(2.0,1.0);

            Console.WriteLine("Construtor com argumentos");
            Console.WriteLine("Vetor: (" + v2.getX() + ", " + v2.getY() + ") \n");

            // Lendo valores do console
            Console.Write("Entre com a coordenada X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Entre com a coordenada Y: ");
            double y = double.Parse(Console.ReadLine());
            Vetor v3 = new Vetor(x, y);
            Console.WriteLine("\nVetor informado pelo usuario: (" + v3.getX() + ", " + v3.getY() + ") \n");

            // Apresentando no Console o modulo do vetor
            Console.WriteLine("Módulo de (" + v3.getX() + "," + 
                v3.getY() + "): " + v3.modulo() + " \n");

            Console.WriteLine("Produto escalar entre (" + v2.getX() + "," + v2.getY() + 
                ") e (" + v3.getX() + "," + v3.getY() + "): " + v2.prodctEscalarCom(v3) + "\n");

            Console.WriteLine("Angulo entre (" + v2.getX() + "," + v2.getY() +
                ") e (" + v3.getX() + "," + v3.getY() + "): " + v2.anguloCom(v3) + "º\n");

            // Apresentando no Console a projecão de um vetor em outro
            double[] proj = v2.projecaoEm(v3);

            Console.WriteLine("Projeção de (" + v2.getX() + ", " + v2.getY() +
                ") em (" + v3.getX() + ", " + v3.getY() + "): (" + proj[0].ToString() + 
                ", " + proj[1].ToString() + ")" + "\n");

            Console.ReadLine();

        }
    }
}
