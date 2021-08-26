using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPessoaJuridicaPessoaFisica
{
    class PessoaFisica:Pessoa
    {
        // atributos
        private String m_cpf;

        // construtor padrão
        public PessoaFisica() : base()
        {
            m_cpf = "XXX.XXX.XXX-XX";
        }

        // construtor com argumentos
        public PessoaFisica(String nome, String tipo, String cpf) : base(nome, tipo)
        {
            m_cpf = cpf;
        }

        // getter
        public String getCPF()
        {
            return (m_cpf);
        }

        // setter
        public void setCPF(String cpf)
        {
            m_cpf = cpf;
   
        }

        public override bool validarDocumento()
        {

            if(m_cpf.ToString().Length == 11)
            {
                return (true);
            }
            else
            {
                return (false);
            }

        }

        public override void imprimirDados()
        {
            Console.WriteLine("Nome: " + m_nome + "\n" + 
                "CPF: " + m_cpf + "\n\n"); 
        }

        public override void cadastrarPessoa()
        {
            Console.Write("Informar nome: ");
            m_nome = Console.ReadLine();

            Console.Write("Informar tipo de documento: ");
            m_tipo = Console.ReadLine();

            Console.Write("Informar CPF: ");
            m_cpf = Console.ReadLine();

            Console.WriteLine("");
        }

    }
}
