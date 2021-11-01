using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPortoSeguro
{
    class Pilha
    {
        // atributos 
        private NohPilha topo; // elemento da pilha
        private int count = 0; // número de elementos

        //construtor padrão
        public Pilha()
        {
            topo = null; // não foi inserido elemento à pilha

        }

        // método para verificar se a pilha está vazia
        public bool isEmpty()
        {
            if (topo == null)
            {
                return (true); // se a pilha está vazia
            }

            else
            {
                return (false); // se a pilha tem elementos
            }
        }

        // método para adicionar elementos à pilha
        public void push(int insertItem)
        {
            if (isEmpty()) // se a pilha está vazia
            {
                topo = new NohPilha(insertItem); // inserir novo elemento
            }

            else
            {
                NohPilha novoNoh = new NohPilha(insertItem); // inserir elemento na pilha
                novoNoh.setNext(topo); // atualizar o valor do topo da pilha

                topo = novoNoh; 
            }

            count++;

        }

        // método para remover elementos da pilha
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
                count--;
                return (temp);
            }

        }

        // método para adicionar elementos à pilha
        public string print()
        {
            string str_pilha = "";

            if (!isEmpty())
            {
                NohPilha temp = topo;

                while (temp != null)
                {
                    str_pilha = str_pilha + temp.getData() + "\r\n";
                    temp = temp.getNext();
                }

            }

            return (str_pilha);

        }

        // método para retornar o topo da pilha
        public NohPilha peek()
        {
            return (topo);
        }

        // método para retornar o tamanho da pilha
        public int lenght()
        {
            return (count);
        }

        // método para retornar o índice
        public int indexOf(int valor)
        {
            int index = -1; // sem item na pilha 

            int index_aux = 0;

            if (!isEmpty())
            {
                NohPilha aux = topo;

                while (aux != null)
                {
                    if (aux.getData() == valor)
                    {
                        index = index_aux; // buscando valor na pilha

                    }

                    aux = aux.getNext();
                    index_aux++;

                }
            }
            return index;

        }
    }
}
