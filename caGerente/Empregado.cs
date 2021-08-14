using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGerente
{
    class Empregado
    {
        // atributos
        protected String m_nome;
        protected String m_secao;

        // construtor padrão
        public Empregado()
        {

        }

        // construtor com argumentos 
        public Empregado(String nome, String secao)
        {
            m_nome = nome;
            m_secao = secao;
        }

        // getters
        public String getNome()
        {
            return(m_nome);
        }

        public String getSecao()
        {
            return (m_secao);
        }

        public void setNome(String nome)
        {
            m_nome = nome;
        }

        public void setSecao(String secao)
        {
            m_secao = secao;
        }

    } // fim da classe
}
