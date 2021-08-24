using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAreaFormasGeometricas
{
    class Trapezio:FormaGeometrica
    {
        // atributos 
        private double m_baseMaior;
        private double m_baseMenor;
        private double m_altura;

        // construtor padrão
        public Trapezio() : base()
        {

        }

        // construtor com argumentos
        public Trapezio(String forma, double Base_maior, double Base_menor, double Altura) : base(forma)
        {
            m_altura = Altura;
            m_baseMaior = Base_maior;
            m_baseMenor = Base_menor;

        }

        // getters
        public double getBaseMaior()
        {
            return (m_baseMaior);
        }

        public double getBaseMenor()
        {
            return (m_baseMenor);
        }

        public double getAltura()
        {
            return (m_altura);
        }

        // setters
        public void setBaseMaior(double Base_maior)
        {
            m_baseMaior = Base_maior;
        }

        public void setBaseMenor(double Base_menor)
        {
            m_baseMenor = Base_menor;
        }

        public void setAltura(double Altura)
        {
            m_altura = Altura;
        }

        // método de cálculo da área
        public override double calcularArea()
        {
            return (((m_baseMaior + m_baseMenor)* m_altura)/2);
        }

    } // fim da classe
}
