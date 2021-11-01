using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFilaDinamica
{
    class Fila
    {
        //atributos
        private NohFila start;
        private NohFila end;
        private int n;

        //construtor default
        public Fila()
        {
            start = null;
            end = null;
        }

        // função para verificar se está vazia
        bool isEmpty()
        {
            if (start == null)
            {
                return (true);
            }
            else
            {
                return (false);
            }

        }

        public void inserir(int valor)
        {
            NohFila novonoh = new NohFila(valor);

            if (isEmpty())
            {
                start = novonoh;
                end = novonoh;
            }
            else
            {
                end.setAnterior(novonoh);
                end = novonoh;
            }
        }

        public void imprimir()
        {
            if (isEmpty())
            {
                Console.WriteLine("Fila vazia");
            }
            else
            {
                NohFila aux = start;

                while (aux != null)
                {
                    Console.Write(aux.getData().ToString() + " ");
                    aux = aux.getAnterior();
                }
            }
        }

        public int retirar()
        {
            if (isEmpty())
            {
                Console.WriteLine("Fila Vazia");
                return (0);
            }

            else
            {
                int aux = start.getData();
                start = start.getAnterior();
                return (aux);

            } 
        }

        public int indexOf(int valor)
        {
            int index = -1; // sem item na pilha 

            int index_aux = 0;

            if (isEmpty())
            {
                return (index);
            }
            else
            {
                NohFila aux = start;

                while (aux != null)
                {
                    if(aux.getData() == valor)
                    {
                        index = index_aux;
                    }

                    aux = aux.getAnterior();
                    index_aux++;
                }

                return (index);
            }
        }
        public NohFila getNoh(int data)
        {
            NohFila temp = start;

            while (temp != end)
            {
                if (temp.getData().Equals(data))
                {
                    break;
                }
                else
                {
                    temp = temp.getAnterior();
                }
            }
            if (temp == null)
            {
                return (null);
            }
            else if (temp == end && !(temp.getData().Equals(data)))
            {
                return (null);
            }
            else
            {
                return(temp);
            }
        }

        public void inserirApos(int valor, int depois)
        {
            NohFila temp = getNoh(depois);

            NohFila newnoh = new NohFila(valor);

            if (isEmpty())
            {
                start = end = newnoh;
            }
            else if (temp.getAnterior() == null)
            {
                newnoh.setAnterior(null);
                temp.setAnterior(newnoh);
            }
            else
            {
                newnoh.setAnterior(temp.getAnterior());
                temp.setAnterior(newnoh);
            }
        }

        public Fila inverter()
        {        
            Pilha p_invertida = new Pilha();
            Fila f_invertida = new Fila();

            if (isEmpty())
            {
                return (f_invertida);
            }
            else
            {
                NohFila aux = start;

                while (aux != null)
                {
                    p_invertida.push(aux.getData());
                    aux = aux.getAnterior();
                }

                while (!p_invertida.isEmpty())
                {
                    f_invertida.inserir(p_invertida.pop());
                }

                return (f_invertida);
            }
        }
    }
}
