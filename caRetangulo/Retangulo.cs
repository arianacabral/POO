using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    class Retangulo
    {
        // atributos da classe
        private double altura;
        private double largura;

        // métodos da classe

        // constructor: Método para definir os valores dos atribuitos 
        public Retangulo() // constructor padrão com aridade 0
        {
            altura = 0.00;
            largura = 0.00;
        }
        public Retangulo(double altura_, double largura_) // constructor com aridade 2 
        {
            altura = altura_;
            largura = largura_;
        }

        // getter: Método para obter o valor do atributo altura
        public double getAltura()
        {
            return(altura);
        }

        //getter: Método para obter o valor do atribuito largura
        public double getLargura()
        {
            return(largura);
        }

        // setter: Método para alterar o valor do atributo altura
        public void setAltura(double altura_)
        {
            altura = altura_;
        }

        //setter: Método para alterar o valor do atribuito largura
        public void setLargura(double largura_)
        {
            largura = largura_;
        }

        // Método Perimetro 
        public double Perimetro()
        {
            return (2 * (largura + altura));
        }

        // Método Area
        public double Area()
        {
            return (largura * altura);
        }
    }// fim da classe Retangulo
}
