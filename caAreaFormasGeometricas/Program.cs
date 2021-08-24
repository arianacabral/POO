using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAreaFormasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {

            FormaGeometrica[] formasGeometricas = new FormaGeometrica[5];

            Triangulo triangulo = new Triangulo("triângulo",2.0,7.5);
            Retangulo retangulo = new Retangulo("retângulo", 2.0, 7.5);
            Quadrado quadrado = new Quadrado("quadrado",6.0);
            Circulo circulo = new Circulo("círculo",3.0);
            Trapezio trapezio = new Trapezio("trapézio", 4.0, 2.0, 3.0);

            formasGeometricas[0] = triangulo;
            formasGeometricas[1] = retangulo;
            formasGeometricas[2] = quadrado;
            formasGeometricas[3] = circulo;
            formasGeometricas[4] = trapezio;

           int ind = formasGeometricas.Length;

            Console.WriteLine("\tCálculo da área de diferentes formas geométricas \n\n");

            for (int i = 0; i < formasGeometricas.Length; i++)
            {
                Console.WriteLine("Forma geométrica: " + formasGeometricas[i].getForma());
                Console.WriteLine("Área = " + Math.Round(formasGeometricas[i].calcularArea(),2).ToString() + "\n");
            }

            Console.ReadLine();

        }
    }
}
