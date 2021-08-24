using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAreaFormasGeometricas
{
    class FormaGeometrica // classe mãe
    {
        // atributos 
        protected String m_forma;

        public FormaGeometrica()
        {

        }

        public FormaGeometrica(String forma)
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
