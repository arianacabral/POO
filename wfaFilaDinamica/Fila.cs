using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaFilaDinamica
{
    class Fila
    {
        //atributos
        private NohFila start;
        private NohFila end;

        //construtor default
        public Fila()
        {
            start = null;
            end = null;
        }

        //função para verificar se esta vazia
        public bool isEmpty()
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

        public void insere(int valor)
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

        public string imprime()
        {
            string str = "";

            if (isEmpty())
            {
                return (str);
            }
            else
            {
                NohFila aux = start;
                while (aux != null)
                {
                    str = str + aux.getData() + " ";
                    aux = aux.getAnterior();
                }

                return (str);
            }
        }

        public int retirar()
        {
            if (isEmpty())
            {
                MessageBox.Show("Fila Vazia");
                return (0);
            }

            else
            {
                int aux = start.getData();
                start = start.getAnterior();
                return (aux);

            }
        }

        public int inicio()
        {
            if (isEmpty())
            {
                MessageBox.Show("Fila Vazia!");
                return (0);
            }
            else
            {
                return (start.getData());
            }
        }

        public int getMax()
        {
            if (isEmpty())
            {
                MessageBox.Show("Fila Vazia!");
                return(0);
            }
            else
            {
                NohFila aux = start;

                int max = inicio();

                while (aux != null)
                {
                    if(max < aux.getData())
                    {
                        max = aux.getData();
                    }

                    aux = aux.getAnterior();
                }

                return (max);
            }
        }

        public int getMin()
        {
            if (isEmpty())
            {
                MessageBox.Show("Fila Vazia!");
                return (0);
            }
            else
            {
                NohFila aux = start;

                int min = inicio();

                while (aux != null)
                {
                    if (min > aux.getData())
                    {
                        min = aux.getData();
                    }

                    aux = aux.getAnterior();
                }

                return (min);
            }
        }

    }
}

