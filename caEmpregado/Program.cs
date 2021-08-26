using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregado
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Empregado> listaEmpregados = new List<Empregado>();

            /// MENU
        
            int aux = 1;
            while (aux != 0)
            {
                Console.Clear();
                Console.WriteLine("\t\tMENU\n");
                Console.WriteLine(" [1] - Cadastrar um EMPREGADO HORISTA");
                Console.WriteLine(" [2] - Cadastrar um EMPREGADO CLT");
                Console.WriteLine(" [3] - Imprimir salário líquido dos empregados");
                Console.WriteLine(" [4] - Sair");
                Console.WriteLine("---------------------------------------\n");
                
                Console.Write("Digite a opção do MENU desejada: ");
                string op = Console.ReadLine();
                
                switch (op)
                {
                    case "1":
                        
                        Console.Clear();

                        Console.WriteLine("\t Cadastrando empregado hosrista \n");

                        Horista empregadoHorista = new Horista();

                        empregadoHorista.cadastrarEmpregado();

                        listaEmpregados.Add(empregadoHorista);

                        break;

                    case "2":
                        
                        Console.Clear();


                        Console.WriteLine("\t Cadastrando empregado CLT \n");

                        CLT empregadoCLT = new CLT();

                        empregadoCLT.cadastrarEmpregado();

                        listaEmpregados.Add(empregadoCLT);

                        break;

                    case "3":
                        
                        Console.Clear();

                        foreach(Empregado empregado in listaEmpregados)
                        {

                            Console.WriteLine("\t\n Dados do Empregado\n\n");
                            empregado.dadosEmpregado();

                            Console.WriteLine("Salário Líquido: R$ " + Math.Round(empregado.getSalarioLiquido(),2));

                        }

                        Console.ReadLine();

                        break;

                    case "4":

                        aux = 0; // sair do while

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
