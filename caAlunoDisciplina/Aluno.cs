using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoDisciplina
{
    class Aluno
    {
        // atributos da classe
        private String m_nome;
        private String m_matricula;
        private int m_periodo;
        private int m_cont;
        private Materia[] m_materias = new Materia[8];

        // construtor padrão
        public Aluno()
        {
            m_nome = "";
            m_matricula = "";
            m_periodo = 0;
            m_cont = 0; 
        }

        // construtor com argumentos
        public Aluno(String nome, String matricula, int periodo)
        {
            m_nome = nome;
            m_matricula = matricula;
            m_periodo = periodo;
            m_cont = 0; 
        }

        // getters
        public String getNome()
        {
            return (m_nome);
        }

        public String getMatricula()
        {
            return (m_matricula);
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

        public void setMatriicula(String matricula)
        {
            m_matricula = matricula;
        }

        public void setPeriodo(int periodo)
        {
            m_periodo = periodo;
        }

        // método para vincular materias ao aluno
        public void adicionarMateria(Materia m)
        {
            m_materias[m_cont] = new Materia(m.getNome(), m.getCodigo());
            m_cont++;
        }

        public void imprimirDados()
        {
            Console.WriteLine("\t\t\t"+"Dados do Aluno");
            Console.WriteLine("\nNome: " + m_nome);
            Console.WriteLine("Número de Matrícula: " + m_matricula);
            Console.WriteLine("Período: " + m_periodo);
            Console.WriteLine("\n\t\t\tDisciplinas \n");

            for(int i = 0; i < m_cont; i++)
            {
                Console.WriteLine(m_materias[i].getCodigo() + " - " + m_materias[i].getNome());
            }

        }

    } // fim da classe
}
