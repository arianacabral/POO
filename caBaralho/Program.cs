using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caBaralho
{
    class Program
    {
        static void Main(string[] args)
        {
            // Baralho
            Console.WriteLine("\t\tBaralho");

            Queue<Carta> baralho = new Queue<Carta>();

            Carta carta;

            /// MENU

            int aux = 1;

            while (aux != 0)
            {
                Console.Clear();
                Console.WriteLine("\t\tMENU\n");
                Console.WriteLine(" [1] - Número de cartas na mão");
                Console.WriteLine(" [2] - Pegar carta na mesa");
                Console.WriteLine(" [3] - Descartar primeira carta da mão na mesa");
                Console.WriteLine(" [4] - Ver cartas na mão");
                Console.WriteLine(" [5] - Sair");
                Console.WriteLine("---------------------------------------\n");

                Console.Write("Digite a opção do MENU desejada: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":

                        Console.Clear();

                        Console.WriteLine("\nNúmero de cartas na mão: " + baralho.Count);

                        Console.ReadLine();

                        break;

                    case "2":

                        Console.Clear();

                        carta = new Carta();

                        carta.gerarCarta();

                        baralho.Enqueue(carta);

                        Console.WriteLine("\n Carta adicionada à mão: " + carta.getFace() + " - " + carta.getNaipe());

                        Console.ReadLine();

                        break;
                    case "3":

                        Console.Clear();

                        if(baralho.Count > 0)
                        {
                            Carta descarte = baralho.Dequeue();

                            Console.WriteLine("\nCarta lançada à mesa: " + descarte.getFace() + " - " + descarte.getNaipe());
                        }
                        else
                        {
                            Console.WriteLine("\nAdicionar carta à mão!");
                        }

                        Console.ReadLine();

                        break;
                    case "4":

                        Console.Clear();

                        Console.WriteLine("\nCartas na mão \n");

                        foreach(Carta carta_mao in baralho)
                        {
                            //string f = carta_mao.getFace();
                            //string c = carta_mao.getNaipe();
                            //Console.WriteLine(f + " - " + c);

                            Console.WriteLine(carta_mao.getFace() + " - " + carta_mao.getNaipe());
                        }

                        Console.ReadLine();

                        break;
                    case "5":

                        aux = 0; // sair do while

                        break;

                    default:

                        Console.Clear();

                        Console.Write("\nFavor, selecionar uma das opções do MENU!\n\n");

                        break;

                } // fim do switch

            } 
        }
    }
}
