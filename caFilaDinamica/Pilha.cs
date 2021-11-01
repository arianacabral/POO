using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFilaDinamica
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

                topo = novoNoh; // o topo agora aponta para mim -- this
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

        // método para retornar o tamanho da pilha
        public int lenght()
        {
            return (count);
        }
    }
}
