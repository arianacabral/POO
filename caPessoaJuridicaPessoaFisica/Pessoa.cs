using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPessoaJuridicaPessoaFisica
{
    class Pessoa
    {
        protected String m_nome;
        protected String m_tipo;

        // construtor padrão
        public Pessoa()
        {
            m_nome = "";
            m_tipo = "";

        }

        // construtor com argumentos
        public Pessoa(String nome, String tipo)
        {
            m_nome = nome;
            m_tipo = tipo;

        }

        // getters
        public String getNome()
        {
            return (m_nome);
        }

        public String getTipo()
        {
            return (m_tipo);
        }


        // setters
        public void setNome(String nome)
        {
            m_nome = nome;
        }

        public void setTipo(String tipo)
        {
            m_tipo = tipo;
        }

        // método para validar documento

        public virtual bool validarDocumento()
        {
            return(false);
        }

        public virtual void imprimirDados()
        {
            Console.Write("Nome: " + m_nome);
            Console.Write("\nTipo de documento: " + m_tipo);
        }


        public virtual void cadastrarPessoa()
        {

        }

    }
}
