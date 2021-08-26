using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregado
{
    class Empregado
    {
        // atributos
        protected String m_primeiroNome;
        protected String m_ultimoNome;
        protected String m_cpf;

        // construtor padrão
        public Empregado()
        {

        }

        // construtor com argumentos
        public Empregado(String primeiroNome, String ultimoNome, String cpf)
        {
            m_primeiroNome = primeiroNome;
            m_ultimoNome = ultimoNome;
            m_cpf = cpf;
        }

        // getters
        public String getPrimeiroNome()
        {
            return (m_primeiroNome);
        }

        public String getUltimoNome()
        {
            return (m_ultimoNome);
        }

        public String getCPF()
        {
            return(m_cpf);
        }

        // setters
        public void setPrimeiroNome(String primeiroNome)
        {
            m_primeiroNome = primeiroNome;
        }

        public void setUltimoNome(String ultimoNome)
        {
            m_ultimoNome = ultimoNome;
        }

        public virtual double getSalarioLiquido()
        {
            return (0.0);
        }

        public virtual void cadastrarEmpregado()
        {

        }

        public void dadosEmpregado()
        {
            Console.WriteLine("Nome: " + m_primeiroNome + " " + m_ultimoNome);
            Console.WriteLine("CPF: " + m_cpf + "\n");

        }
    }
}
