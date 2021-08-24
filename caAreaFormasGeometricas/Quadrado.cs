using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAreaFormasGeometricas
{
    class Quadrado : FormaGeometrica
    {
        // atributos 
        private double m_lado;

        // construtor padrão
        public Quadrado() : base()
        {

        }

        // construtor com argumentos
        public Quadrado(String forma, double Lado) : base(forma)
        {
            m_lado = Lado;
        }

        // getters
        public double getLado()
        {
            return (m_lado);
        }

        // setters
        public void setLado(double Lado)
        {
            m_lado = Lado;
        }

        // método de cálculo da área
        public override double calcularArea()
        {
            return (Math.Pow(m_lado,2));
        }
    }
}
