using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Vetor 2D

            // Usando o construtor com argumetos
            Vetor2D v1 = new Vetor2D(2.0,2.0);
            Vetor2D v2 = new Vetor2D(2.0, 1.0);

            Console.WriteLine("\tVetor 2D\n");

            Console.WriteLine("v1 = (" + v1.getX() + ", " + v1.getY() + ") \n");

            Console.WriteLine("v2 = (" + v2.getX() + ", " + v2.getY() + ") \n");

            // Apresentando no Console o modulo dos vetores

            Console.WriteLine("Módulo de (" + v1.getX() + "," +
               v1.getY() + "): " + Math.Round(v1.modulo(), 2) + " \n");

            Console.WriteLine("Módulo de (" + v2.getX() + "," +
                v2.getY() + "): " + Math.Round(v2.modulo(),2) + " \n");

            // Apresentando no Console o produto escalar entre os vetores

            Console.WriteLine("Produto escalar entre (" + v2.getX() + "," + v2.getY() +
                ") e (" + v1.getX() + "," + v1.getY() + "): " + v2.prodctEscalarCom(v1) + "\n");

            // Apresentando no Console o ângulo entre os vetores

            Console.WriteLine("Angulo entre (" + v2.getX() + "," + v2.getY() +
                ") e (" + v1.getX() + "," + v1.getY() + "): " + Math.Round(v2.anguloCom(v1), 2) + "º\n");

            // Apresentando no Console a projecão de um vetor em outro

            Vetor2D vproj = new Vetor2D();

            vproj = v2.projecaoEm(v1);

            Console.WriteLine("Projeção de (" + v2.getX() + ", " + v2.getY() +
                ") em (" + v1.getX() + ", " + v1.getY() + "): (" + vproj.getX() +
                ", " + vproj.getY() + ")" + "\n");

            /// Vetor 3D

            // Usando o construtor com argumetos
            Vetor3D v3 = new Vetor3D(1.0, 2.0, 1.0);
            Vetor3D v4 = new Vetor3D(3.0, -2.0, 8.0);

            Vetor3D v5 = new Vetor3D();

            Console.WriteLine("\tVetor 3D\n");

            Console.WriteLine("v3 = (" + v3.getX() + ", " + v3.getY() + ", " + v3.getZ() +") \n");

            Console.WriteLine("v4 = (" + v4.getX() + ", " + v4.getY() + ", " + v4.getZ() + ") \n");

            Console.WriteLine("Módulo de (" + v3.getX() + ", " + v3.getY() + ", " + v3.getZ() + ")" +
                ": " + Math.Round(v3.modulo(), 2) + " \n");

            Console.WriteLine("Módulo de (" + v4.getX() + ", " + v4.getY() + ", " + v4.getZ() + ")" +
                ": " + Math.Round(v4.modulo(), 2) + " \n");

            v5 = v3.prodctVetorialCom(v4);

            Console.WriteLine("Produto vetorial de (" + v3.getX() + ", " + v3.getY() + ", " + v3.getZ() + ")" +
                " com (" + v4.getX() + ", " + v4.getY() + ", " + v4.getZ() + "): " +
               "(" + v5.getX() + ", " + v5.getY() + ", " + v5.getZ() + ")" + " \n");

            Console.ReadLine();
        }
    }
}
