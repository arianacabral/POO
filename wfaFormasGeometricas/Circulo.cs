using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFormasGeometricas
{
    class Circulo:FormasGeometricas
    {
        // atributos 
        private double m_raio;

        // construtor padrão
        public Circulo() : base()
        {

        }

        // construtor com argumentos
        public Circulo(String forma, double Raio) : base(forma)
        {
            m_raio = Raio;
        }

        // getters
        public double getRaio()
        {
            return (m_raio);
        }

        // setters
        public void setRaio(double Raio)
        {
            m_raio = Raio;
        }

        // método de cálculo da área
        public override double calcularArea()
        {
            return (Math.PI * Math.Pow(m_raio, 2));
        }

    }
}
