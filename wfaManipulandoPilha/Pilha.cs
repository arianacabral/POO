using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaManipulandoPilha
{
    class Pilha
    {
        private NohPilha topo;

        // construtor padrão
        public Pilha()
        {
            topo = null;
        }

        // método para ver se há elementos
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

        // método para empilhar
        public void push(int item)
        {
            if (isEmpty())
            {
                topo = new NohPilha(item);
            }
            else
            {
                NohPilha novoNoh = new NohPilha(item); // insere o valor novo do topo da pilha
                novoNoh.setNext(topo); // atualiza para onde aponta

                topo = novoNoh;
            }
        }

        // método para desempilhar
        public int pop()
        {
            if (isEmpty())
            {
                MessageBox.Show("Pilha Vazia!");
                return (0); // pilha vazia
            }
            else
            {
                int temp = topo.getData(); // dado a ser removido
                topo = topo.getNext(); // atualiza o valor do topo
                return (temp);
            }
        }

        // método para imprimir
        public string print()
        {
            string str = "";

            if (isEmpty())
            {
                return (str); // pilha vazia
            }
            else
            {
                NohPilha temp = topo;

                while(temp != null)
                {
                    str = str + temp.getData() + "\r\n";
                    temp = temp.getNext();
                }

                return (str);
            }
        }

        // método para retornar o valor máximo
        public int max()
        {
            if (isEmpty())
            {
                MessageBox.Show("Pilha Vazia!");
                return (0);
            }
            else
            {
                NohPilha temp = topo;

                int max = topo.getData();

                while(temp != null)
                {
                    if(max < temp.getData())
                    {
                        max = temp.getData();
                    }
                    temp = temp.getNext();
                }

                return (max);
            }
        }

        // método para retornar o valor mínimo
        public int min()
        {
            if (isEmpty())
            {
                MessageBox.Show("Pilha Vazia!");
                return (0);
            }
            else
            {
                NohPilha temp = topo;

                int min = topo.getData();

                while (temp != null)
                {
                    if (min > temp.getData())
                    {
                        min = temp.getData();
                    }
                    temp = temp.getNext();
                }

                return (min);
            }
        }
    }
}
