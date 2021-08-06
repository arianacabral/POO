using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoDisciplina
{
    class Materia
    {
        // atributos da classe
        private String m_nome;
        private String m_codigo;

        // construtor padrão 
        public Materia()
        {
            m_nome = "";
            m_codigo = "";
        }

        // construtor com argumentos
        public Materia(String nome, String codigo)
        {
            m_nome = nome;
            m_codigo = codigo;
        }

        // getters
        public String getNome()
        {
            return (m_nome);
        }

        public String getCodigo()
        {
            return (m_codigo);
        }

        //setters
        public void setNome(String nome)
        {
            m_nome = nome;
        }

        public void setCodigo(String codigo)
        {
            m_codigo = codigo;
        }

    }// fim da classe
}
