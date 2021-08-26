using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregado
{
    class Horista : Empregado
    {
        // atributos
        private double m_numHoras;
        private double m_precoHora;

        // construtor padrão
        public Horista():base()
        {
            
        }

        // construtor com argumentos
        public Horista(String primeiroNome, String ultimoNome, String cpf, double numHoras, double precoHora) : base(primeiroNome, ultimoNome, cpf)
        {
            m_numHoras = numHoras;
            m_precoHora = precoHora;
        }

        // getters
        public double getNumHoras()
        {
            return (m_numHoras);
        }

        public double getPrecoHora()
        {
            return (m_precoHora);
        }

        // setters
        public void setNumHoras(double numHoras)
        {
            m_numHoras = numHoras;
        }

        public void setPrecoHora(double precoHora)
        {
            m_precoHora = precoHora;
        }

        public override double getSalarioLiquido()
        {
            return ((m_numHoras*m_precoHora)*0.85); // desconto de 15% no valor
        }


        public override void cadastrarEmpregado()
        {
            Console.Write("Informe o primeiro nome: ");
            m_primeiroNome = Console.ReadLine();

            Console.Write("\nInforme o último nome: ");
            m_ultimoNome = Console.ReadLine();

            Console.Write("\nInforme o CPF: ");
            m_cpf = Console.ReadLine();

            Console.Write("\nInforme o número de horas trabalhadas (em horas): ");
            m_numHoras = double.Parse(Console.ReadLine());

            Console.Write("\nInforme o preço pago por hora trabalhada (em R$): ");
            m_precoHora = double.Parse(Console.ReadLine());

        }

    }
}
