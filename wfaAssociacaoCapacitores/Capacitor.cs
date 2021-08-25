using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaAssociacaoCapacitores
{
    class Capacitor
    {
        // atributo 

        private double m_capacitancia;

        // construtor padrão 
        public Capacitor()
        {
            m_capacitancia = 0.0;
        }

        // construtor com argumentos 
        public Capacitor(double capacitancia)
        {
            m_capacitancia = capacitancia;
        }

        // getter
        public double getCapacitancia()
        {
            return (m_capacitancia);
        }

        // setter
        public void setCapacitancia(double capacitancia)
        {
            m_capacitancia = capacitancia;
        }

        public double associacaoSerieCom(Capacitor c)
        {
            return ((m_capacitancia*c.getCapacitancia())/(m_capacitancia + c.getCapacitancia()));
        }

        public double associacaoParaleloCom(Capacitor c)
        {
            return (m_capacitancia + c.getCapacitancia());
        }

    }
}
