using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaControleDePagamentos
{
    class Saude: Pagtos // classe filha
    {
        // atributos
        private String m_estabelecimento;
        private double m_vlfatSaude;

        // construtor padrão
        public Saude() : base()
        {
            m_estabelecimento = "";
            m_vlfatSaude = 0.0;
        }

        // construtor com argumentos
        public Saude(long cpf, double valor, int codigo, String estabelecimento) : base(cpf, valor, codigo)
        {
            m_estabelecimento = estabelecimento;
            m_vlfatSaude = 0.0;
        }

        // getters
        public String getEstabelecimento()
        {
            return (m_estabelecimento);
        }

        public double getValorFaturaSaude()
        {
            return (m_vlfatSaude);
        }

        // setters
        public void setEstabelecimento(String estabelecimento)
        {
            m_estabelecimento = estabelecimento;
        }

        public void setValorFaturaSaude(double valorFaturaSaude)
        {
            m_vlfatSaude = valorFaturaSaude;
        }

        // método para gerar o valor da fatura 
        public override void faturar()
        {
            m_vlfatSaude = Math.Round(m_valor + (0.12 * m_valor), 2);

        }

    } // fim da classe
}
