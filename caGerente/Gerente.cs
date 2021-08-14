using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGerente
{
    class Gerente: Empregado // Gerente herda de Empregado
    {
        // atributos 
        private String m_secretaria;

        // construtor padrão 
        public Gerente() : base()
        {

        }

        // construtor com argumentos 
        public Gerente(String nome, String secao, String secretaria) : base(nome, secao)
        {
            m_secretaria = secretaria;
        }

        //getter
        public String getSecretaria()
        {
            return (m_secretaria);
        }

        // setter
        public void setSecretaria(String secretaria)
        {
            m_secretaria = secretaria;
        }

    }
}
