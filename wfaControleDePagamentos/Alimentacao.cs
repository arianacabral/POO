using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaControleDePagamentos
{
    class Alimentacao : Pagtos // classe filha 
    {
        // atributos 
        private String m_descricao;
        private double m_vlfatAliment;

        // construtor padrão 
        public Alimentacao() : base()
        {
            m_descricao = "";
            m_vlfatAliment = 0.0;
        }

        // construtor com argumentos
        public Alimentacao(long cpf, double valor, int codigo, String descricao) : base(cpf, valor, codigo)
        {
            m_descricao = descricao;
            m_vlfatAliment = 0.0;
        }

        // getters
        public String getDescricao()
        {
            return (m_descricao);
        }

        public double getValorFaturaAlimentacao()
        {
            return (m_vlfatAliment);
        }

        // setters
        public void setDescricao(String descricao)
        {
            m_descricao = descricao;
        }

        public void setValorFaturaAlimentacao(double valorFaturaAlimentacao)
        {
            m_vlfatAliment = valorFaturaAlimentacao;
        }
        // método para gerar o valor da fatura 
        public override void faturar()
        {
            m_vlfatAliment = Math.Round(m_valor + (0.05 * m_valor), 2);

        }
    }
}
