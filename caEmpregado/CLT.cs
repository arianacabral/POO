using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregado
{
    class CLT:Empregado
    {
        // atributo 
        private double m_salario;

        //construtor padrão
        public CLT():base()
        {

        }

        // construtor com argumentos
        public CLT(String primeiroNome, String ultimoNome, String cpf, double salario) : base(primeiroNome, ultimoNome, cpf)
        {
            m_salario = salario;
        }

        // getter
        public double getSalario()
        {
            return (m_salario);
        }

        // setter
        public void setSalario(double salario)
        {
            m_salario = salario;
        }

        public override double getSalarioLiquido()
        {
            if(m_salario >= 4000.0)
            {
                return (m_salario * (72.5/100));
            }
            else
            {
                return (m_salario * 85.0);
            }
        }

        public override void cadastrarEmpregado()
        {
            Console.Write("Informe o primeiro nome: ");
            m_primeiroNome = Console.ReadLine();

            Console.Write("\nInforme o último nome: ");
            m_ultimoNome = Console.ReadLine();

            Console.Write("\nInforme o CPF: ");
            m_cpf = Console.ReadLine();

            Console.Write("\nInforme o salário mensal (em R$): ");
            m_salario = double.Parse(Console.ReadLine());

        }

    }
}
