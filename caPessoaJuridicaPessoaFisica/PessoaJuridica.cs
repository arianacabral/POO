using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPessoaJuridicaPessoaFisica
{
    class PessoaJuridica:Pessoa
    {
        // atributos
        private long m_cnpj;

        // construtor padrão
        public PessoaJuridica() : base()
        {
            m_cnpj = 00000000000000;
        }

        // construtor com argumentos
        public PessoaJuridica(String nome, String tipo, long cnpj) : base(nome, tipo)
        {
            m_cnpj = cnpj;
        }

        // getter
        public long getCNPJ()
        {
            return (m_cnpj);
        }

        // setter
        public void setCNPJ(long cnpj)
        {
            m_cnpj = cnpj;
        }

        public override bool validarDocumento()
        {

            if (m_cnpj.ToString().Length == 14)
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
                "CNPF: " + m_cnpj + "\n\n");
        }

        public override void cadastrarPessoa()
        {
            Console.Write("Informar nome: ");
            m_nome = Console.ReadLine();

            Console.Write("Informar tipo de documento: ");
            m_tipo = Console.ReadLine();

            Console.Write("Informar CNPJ: ");
            m_cnpj = long.Parse(Console.ReadLine());

            Console.WriteLine("");

        }

    }
}
