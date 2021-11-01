using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFilaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();

            /// MENU

            int aux = 1;

            while (aux != 0)
            {
                /*[1] Insira um inteiro na Fila; 
                 * [2] Remova um inteiro da Fila; 
                 * [3] Insira um inteiro APÓS um outro a ser escolhido; 
                 * [4] Reverte a  Fila – o início da fila torna-se o fim, e vice-versa;  
                 * [5] Imprima a Fila;
                 * [6] SAIR*/

                Console.Clear();
                Console.WriteLine("\t\tMENU\n");
                Console.WriteLine(" [1] - Inserir um inteiro na Fila");
                Console.WriteLine(" [2] - Remover um inteiro da Fila");
                Console.WriteLine(" [3] - Inserir um inteiro na Fila APÓS um outro escolhido");
                Console.WriteLine(" [4] - Reverter a Fila");
                Console.WriteLine(" [5] - Imprimir Fila");
                Console.WriteLine(" [6] - Sair");
                Console.WriteLine("---------------------------------------\n");

                Console.Write("Digite a opção do MENU desejada: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":

                        Console.Clear();

                        Console.WriteLine("\t Inserindo um inteiro na Fila \n");

                        Console.Write("Valor a ser inserido: ");

                        try
                        {
                            fila.inserir(int.Parse(Console.ReadLine()));
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Valor inválido! \n");

                            Console.ReadLine();
                        }

                        break;

                    case "2":

                        Console.Clear();

                        Console.WriteLine("\t Removendo primeiro inteiro da Fila \n");

                        Console.WriteLine("Valor removido: " + fila.retirar());

                        Console.ReadLine();

                        break;

                    case "3":

                        Console.Clear();

                        Console.WriteLine("\t Inserindo um inteiro na Fila APÓS um outro escolhido\n");
                        
                        Console.Write("Valor a ser inserido: ");
                        int valor = int.Parse(Console.ReadLine());

                        Console.Write("Valor da fila que o valor informado será inserido APÓS: ");
                        int depois = int.Parse(Console.ReadLine());

                        fila.inserirApos(valor, depois);

                        break;
                    case "4":
                        Console.Clear();

                        Console.WriteLine("\t Revertendo a Fila\n");

                        Fila invertida = fila.inverter();

                        invertida.imprimir();

                        Console.ReadLine();

                        break;
                    case "5":

                        Console.Clear();

                        Console.WriteLine("\t Imprimindo elementos da Fila \n");

                        Console.Write("Fila: ");

                        fila.imprimir();

                        Console.ReadLine();

                        break;

                    case "6":

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
