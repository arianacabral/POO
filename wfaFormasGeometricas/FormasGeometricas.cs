using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFormasGeometricas
{
    class FormasGeometricas
    {
        // atributos 
        protected String m_forma;

        public FormasGeometricas()
        {

        }

        public FormasGeometricas(String forma)
        {
            m_forma = forma;
        }

        public void setForma(String forma)
        {
            m_forma = forma;
        }

        public String getForma()
        {
            return (m_forma);
        }

        public virtual double calcularArea()
        {
            return (0.0);
        }

    }
}
