using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaSolicitacaoDeMatricula
{
    class Disciplina
    {
        // atributos 
        private String m_disciplina;
        private String m_codigo;

        // construtor padrão
        public Disciplina()
        {
            m_disciplina = m_codigo = "";
        }

        //construtor com argumento
        public Disciplina(String disciplina, String codigo)
        {
            m_disciplina = disciplina;
            m_codigo = codigo;
        }

        //getters
        public String getDisciplina()
        {
            return (m_disciplina);
        }

        public String getCodigo()
        {
            return (m_codigo);
        }

        //setters
        public void setDisciplina(String disciplina)
        {
            m_disciplina = disciplina;
        }

        public void setCodigo(String codigo)
        {
            m_codigo = codigo;
        }

    }
}
