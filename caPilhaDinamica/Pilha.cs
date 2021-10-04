using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    class Pilha
    {
        // atributos 
        private NohPilha topo; // elemento da pilha

        // métodos
        public Pilha()
        {
            topo = null; // não foi inserido elemento à pilha
        }

        public bool isEmpty()
        {
            if (topo == null)
            {
                return(true); // se a pilha está vazia
            }

            else
            {
                return(false); // se a pilha tem elementos
            }
        }

        public void push(int insertItem)
        {
            if (isEmpty()) // se a pilha está vazia
            {
                topo = new NohPilha(insertItem); // inserir novo elemento
            }
                
            else
            {
                // NohPilha novoNoh = new NohPilha(insertItem, topo); OU
                NohPilha novoNoh = new NohPilha(insertItem); // atualizar o valor do topo da pilha
                novoNoh.setNext(topo);

                topo = novoNoh; // o topo agora aponta para mim -- this
            }
        } // fim do método push



        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
                return 0;
            }
            else
            {
                int temp = topo.getData();
                topo = topo.getNext();
                return (temp);
            }

        }

        public void print()
        {
            if (isEmpty())
                Console.WriteLine("Pilha Vazia");
            else
            {
                Console.WriteLine("Status atual da Pilha:");
                NohPilha temp = topo;

                while (temp != null)
                {
                    Console.WriteLine(temp.getData() + " ");
                    temp = temp.getNext();
                } 

            } 

        } 

    }
}
