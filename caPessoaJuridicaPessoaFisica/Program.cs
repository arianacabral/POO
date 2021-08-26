using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPessoaJuridicaPessoaFisica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            /// MENU

            int aux = 1;
            while (aux != 0)
            {
                Console.Clear();
                Console.WriteLine("\t\tMENU\n");
                Console.WriteLine(" [1] - Cadastrar uma pessoa física");
                Console.WriteLine(" [2] - Cadastrar uma pessoa jurídica");
                Console.WriteLine(" [3] - Validar documentos das pessoas");
                Console.WriteLine(" [4] - Sair");
                Console.WriteLine("---------------------------------------\n");

                Console.Write("Digite a opção do MENU desejada: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":

                        Console.Clear();

                        Console.WriteLine("\t Cadastrando pessoa física\n");

                        PessoaFisica pessoaFisica = new PessoaFisica();

                        pessoaFisica.cadastrarPessoa();

                        listaPessoas.Add(pessoaFisica);

                        break;

                    case "2":

                        Console.Clear();


                        Console.WriteLine("\t Cadastrando empregado CLT \n");

                        PessoaJuridica pessoaJuridica = new PessoaJuridica();

                        pessoaJuridica.cadastrarPessoa();

                        listaPessoas.Add(pessoaJuridica);

                        break;

                    case "3":

                        Console.Clear();

                        Console.WriteLine("\t\n Validando o documento informado \n\n");

                        Console.WriteLine("---------------------------------------\n");

                        foreach (Pessoa pessoa in listaPessoas)
                        {
                            pessoa.imprimirDados();

                            if (pessoa.validarDocumento())
                            {
                                Console.WriteLine("Status: Documento informado válido!");
                            }
                            else
                            {
                                Console.WriteLine("Status: Documento informado inválido!");
                            }

                            Console.WriteLine("\n\n---------------------------------------\n");

                        }

                        Console.ReadLine();

                        break;

                    case "4":

                        aux = 0;

                        break;

                    default:

                        Console.Clear();

                        Console.Write("\nFavor, selecionar uma das opções do MENU! \n\n");

                        break;

                } // fim do switch

            }
        }
    }
}
