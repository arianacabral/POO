using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando e instanciando uma Fila do tipo string
            Queue<string> animais = new Queue<string>();

            // Adicionando elementos à Fila
            animais.Enqueue("cachorro");
            animais.Enqueue("gato");
            animais.Enqueue("peixe");
            animais.Enqueue("arara");
            animais.Enqueue("elefante");
            animais.Enqueue("coelho");

            // Apresentando o número de elementos da Fila
            Console.WriteLine("\tNúmero de elementos da fila\n");
            Console.WriteLine("Há " + animais.Count + " animais na fila!");

            // Verificando se um elemento pertence à Fila

            Console.WriteLine("\n\tProcurando elemento na Fila\n");

            string pet = "cachorro";

            if (animais.Contains(pet))
            {
                Console.WriteLine(pet.ToUpper() + " encontrado na fila!");
            }
            else
            {
                Console.WriteLine(pet.ToUpper() + " não encontrado na fila!");
            }

            // Removendo o primeiro elemento da Fila

            Console.WriteLine("\n\tApresentando e removendo elementos da Fila\n");

            int i = 0;

            while(animais.Count != 0)
            {
                Console.WriteLine("Animal na posicão " + i.ToString() + " da Fila: " + animais.Dequeue().ToUpper());
                Console.WriteLine("Agora, há " + animais.Count + " animais na Fila! \n");

                i++;

            }

            // Limpando elementos da Fila

            // adicionando elementos à fila
            animais.Enqueue("cachorro");
            animais.Enqueue("gato");
            animais.Enqueue("peixe");
            animais.Enqueue("arara");
            animais.Enqueue("elefante");
            animais.Enqueue("coelho");

            Console.WriteLine("\n\tAnimais:\n");

            foreach(string animal in animais)
            {
                Console.WriteLine(animal.ToUpper());
            }

            Console.WriteLine("\n\tLimpando elementos da Fila\n");

            animais.Clear();

            Console.WriteLine("Há " + animais.Count + " animais na fila!");

            Console.ReadLine();

        }
    }
}
