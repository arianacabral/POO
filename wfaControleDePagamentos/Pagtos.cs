using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaControleDePagamentos
{
    class Pagtos // classe mãe
    {
        //  atributos 
        protected long m_cpf;
        protected double m_valor;
        protected int m_cod;

        // construtor padrão
        public Pagtos()
        {
            m_cpf = 000000000000;
            m_valor = 0.0;
            m_cod = 0;
        }

        // construtor com argumentos (aridade 3)
        public Pagtos(long cpf, double valor, int cod)
        {
            m_cpf = cpf;
            m_valor = valor;
            m_cod = cod;
        }

        //  getters
        public long getCPF()
        {
            return (m_cpf);
        }

        public double getValor()
        {
            return (m_valor);
        }

        public int getCod()
        {
            return (m_cod);
        }

        // setters
        public void setCPF(long cpf)
        {
            m_cpf = cpf;
        }

        public void setValor(double valor)
        {
            m_valor = valor;
        }

        public void setCod(int cod)
        {
            m_cod = cod;
        }

        // método para gerar o valor da fatura 
        public virtual void faturar()
        {
       
        }

    } // fim da classe
}
