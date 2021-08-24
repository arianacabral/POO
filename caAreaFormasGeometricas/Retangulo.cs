using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAreaFormasGeometricas
{
    class Retangulo : FormaGeometrica
    {
        // atributos 
        private double m_base;
        private double m_altura;

        // construtor padrão
        public Retangulo() : base()
        {

        }

        // construtor com argumentos
        public Retangulo(String forma, double Base, double Altura) : base(forma)
        {
            m_altura = Altura;
            m_base = Base;
        }

        // getters
        public double getBase()
        {
            return (m_base);
        }

        public double getAltura()
        {
            return (m_altura);
        }

        // setters
        public void setBase(double Base)
        {
            m_base = Base;
        }

        public void setAltura(double Altura)
        {
            m_altura = Altura;
        }

        // método de cálculo da área
        public override double calcularArea()
        {
            return (m_base * m_altura);
        }

    }// fim da classe
}
