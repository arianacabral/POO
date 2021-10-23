using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPalindromo
{
    class Pilha
    {
        // atributos 
        private NohPilha topo;
        private int count = 0;

        // contrutor padrão
        public Pilha()
        {
            topo = null;
        }

        // método verificar se há elementos na pilha
        public bool isEmpty()
        {
            if (topo == null)
            {
                return (true); 
            }

            else
            {
                return (false); 
            }
        }

        // método para empilhar
        public void push(string item)
        {
            if (isEmpty()) 
            {
                topo = new NohPilha(item); 
            }

            else
            {
                NohPilha novoNoh = new NohPilha(item);
                novoNoh.setNext(topo);

                topo = novoNoh;
            }
            count++;
        }

        // método para desempinhar
        public string pop()
        {
            if (isEmpty())
            {
                count--;
                return ("");
            }
            else
            {
                string temp = topo.getData();
                topo = topo.getNext();
                count--;
                return (temp);
            }
        }

        // método para imprimir pilha
        public string print()
        {
            string str = "";
            if (isEmpty())
            {
                return (str);
            }
            else
            {
                NohPilha temp = topo;

                while (temp != null)
                {
                    str = str + temp.getData() + "\r\n";
                    temp = temp.getNext();
                }

                return (str);
            }
        }

        // método para retormar o tamanho
        public int lenght()
        {
            return (count);
        }

        // método para retornar o topo
        public string peek()
        {
            return (topo.getData());
        }

        // método para inverter
        public string invert()
        {
            string str = "";
            if (isEmpty())
            {
                return (str);
            }
            else
            {
                NohPilha temp = topo;
                Pilha pilha = new Pilha();

                while (temp != null)
                {
                    pilha.push(temp.getData());
                    temp = temp.getNext();
                }

                str = pilha.print();

                return (str);
            }

        }

        // método para verificar se é palindromo
        public bool isPalindromo()
        {
            if (isEmpty())
            {
                return(true);
            }
            else
            {
                int tam = lenght();
                int meio = tam / 2; 

                Pilha pilha = new Pilha();

                NohPilha temp = topo;

                while(pilha.lenght() < meio)
                {
                    pilha.push(temp.getData());
                    temp = temp.getNext();
                }

                while(temp != null)
                {
                    if(temp.getData() == pilha.peek())
                    {
                        pilha.pop();

                    }

                    temp = temp.getNext();
                }

                if (pilha.isEmpty())
                {
                    return (true);
                }
                else
                {
                    return (false);
                }
            }
        }
    }
}
