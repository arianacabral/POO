using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace caPilhaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Testando os nós da pilha 

            // Declarando e instanciando um nó
            NohPilha no1 = new NohPilha();

            Console.WriteLine("\t\tVisualizando a estrutura dos elementos da pilha vazia\n");
            Console.WriteLine("Elemento: (" + no1.getData() + ") - " + " Para onde está apontando: ("+ no1.getNext() + ")");


            // Declarando e instanciando um nó, cujo elemento numérico é 2
            NohPilha no2 = new NohPilha(2);

            Console.WriteLine("\n\t\tVisualizando a estrutura dos elementos da pilha com um elemento\n");
            Console.WriteLine("Elemento: (" + no2.getData() + ") - " + " Para onde está apontando: (" + no2.getNext() + ")");

            // Declarando e instanciando um nó, cujo elemento numérico é 1 e o próximo nó é o no2
            NohPilha no3 = new NohPilha(1,no2);

            Console.WriteLine("\n\t\tVisualizando a estrutura dos elementos da pilha com mais de um elemento\n");
            Console.WriteLine("Elemento: (" + no3.getData() + ") - " + " Para onde está apontando: (" + no3.getNext().getData() + ")");

            Console.ReadLine();
            */

            /*
            // Testando o conceito de pilha

            // Declarando e instanciando uma pilha vazia
            Pilha pilha1 = new Pilha();

            Console.WriteLine("\t\tVisualizando a estrutura da pilha vazia\n");
            pilha1.print();

            // Declarando e instanciando uma pilha com um elemento
            Pilha pilha2 = new Pilha();
            pilha2.push(2);

            Console.WriteLine("\n\t\tVisualizando a estrutura da pilha com um elemento\n");
            pilha2.print();

            // Declarando e instanciando uma pilha com mais de um elemento
            Pilha pilha3 = new Pilha();
            pilha3 = pilha2;
            pilha3.push(3);
            pilha3.push(4);

            Console.WriteLine("\n\t\tVisualizando a estrutura da pilha com mais de um elemento\n");
            pilha3.print();

            Console.ReadLine();
            */


            Pilha pilha = new Pilha();

            TextReader leitor = System.Console.In;
            TextWriter escritor = System.Console.Out;

            float aux = 1;

            while (aux != 0)
            {
                Console.WriteLine("\n\t\t\tMENU\n");
                Console.WriteLine(" [1] - Inserir elemento na pilha");
                Console.WriteLine(" [2] - Remover elemento da pilha");
                Console.WriteLine(" [3] - Imprimir todos elementos da pilha");
                Console.WriteLine(" [4] - Sair");

                Console.Write("\nOpção selecionada: "); 
                string op = leitor.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("\nDigite o elemento a ser inserido: ");
                        String elemento = leitor.ReadLine();
                        int valor = Convert.ToInt32(elemento);
                        pilha.push(valor);
                        Console.Clear();
                        break;

                    case "2":
                        Console.Write("Um elemento  foi removido");
                        Console.WriteLine("\nRemoveu o " + pilha.pop());
                        Console.Clear();
                        break;

                    case "3":
                        Console.Write("\nA pilha encontra-se na seguinte disposição :\n");
                        pilha.print();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "4":
                        aux = 0;
                        Console.Clear();
                        break;
                    default:
                        Console.Write("Favor selecionar uma das opções mostradas no menu!\n");
                        break;
                }

            }

        }
    }
}
