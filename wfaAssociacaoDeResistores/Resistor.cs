using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaAssociacaoDeResistores
{
    class Resistor
    {
        private double m_resistencia;

        // construtor padrão
        public Resistor()
        {
            m_resistencia = 0;
        }

        // construtor com argumentos
        public Resistor(double resistencia)
        {
            m_resistencia = 0;
        }

        // setter
        public void setResistencia(double resistencia)
        {
            m_resistencia = resistencia;
        }

        // getter
        public double getResistencia()
        {
            return (m_resistencia);
        }

        public double associacaoSerieCom(Resistor r)
        {
            return (m_resistencia + r.getResistencia());
        }

        public double associacaoParaleloCom(Resistor r)
        {
            return ((m_resistencia*r.getResistencia())/ (m_resistencia + r.getResistencia()));
        }


    }// fim da classe
}
