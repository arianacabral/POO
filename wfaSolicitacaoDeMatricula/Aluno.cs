using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaSolicitacaoDeMatricula
{
    class Aluno
    {
        // atributos
        private String m_nome;
        private String m_matricula;
        private int m_periodo;
        private String m_curso;
        private Disciplina[] m_materias = new Disciplina[10];
        private int m_count;
        private String m_disciplinas;

        // construtor padrão
        public Aluno()
        {
            m_nome = m_matricula = m_curso = "";
            m_periodo = 0;
            m_count = 0;
        }

        // construtor com argumentos
        public Aluno(String nome, String matricula, int periodo, String curso)
        {
            m_nome = nome;
            m_matricula = matricula;
            m_curso = curso;
            m_periodo = periodo;
            m_count = 0;
        }

        //getters
        public String getNome()
        {
            return (m_nome);
        }

        public String getMatricula()
        {
            return (m_matricula);
        }

        public String getCurso()
        {
            return (m_curso);
        }

        public int getPeriodo()
        {
            return (m_periodo);
        }

        // setters
        public void setNome(String nome)
        {
            m_nome = nome;
        }

        public void setMatricula(String matricula)
        {
            m_matricula = matricula;
        }

        public void setCurso(String curso)
        {
            m_curso = curso;
        }

        public void setPeriodo(int periodo)
        {
            m_periodo = periodo;
        }


        public void solicitarDisciplina(Disciplina disciplina)
        {
            m_materias[m_count] = new Disciplina(disciplina.getDisciplina(),disciplina.getCodigo());
            m_count++;


        }

        public String listarDisciplinas()
        {

            for(int i = 0; i < m_count; i++)
            {
                m_disciplinas = m_disciplinas  + m_materias[i].getCodigo() + " - " + m_materias[i].getDisciplina() + "\n";
            }

            return (m_disciplinas);

        }

    }// fim da classe
}
