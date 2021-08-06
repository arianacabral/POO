using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno
{
    class Aluno
    {
        // atributos da classe
        private string m_nome;
        private string m_matricula;
        private string m_telefone;

        // métodos da classe 
        public Aluno() // construtor padrão da classe
        {
            m_nome = "";
            m_matricula = "";
            m_telefone = "";
        }

        public Aluno(string nome_, string n_matricula_, string telefone_) // construtor da classe com argumentos
        {
            m_nome = nome_;
            m_matricula = n_matricula_;
            m_telefone = telefone_;
        }

        //getters
        public string getNome()
        {
            return (m_nome);
        }

        public string getMatricula()
        {
            return (m_matricula);
        }

        public string getTelefone()
        {
            return (m_telefone);
        }

        // setters
        public void setAluno()
        {
            m_nome = Console.ReadLine();
   
        }

        public void setMatricula()
        {
            m_matricula = Console.ReadLine();

        }

        public void setTelefone()
        {
            m_telefone = Console.ReadLine();

        }

    } // fim da classe
}
