using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPokemon
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
        bool isEmpty()
        {
            if (start == null)
            {
                return(true);
            }
            else
            {
                return (false);
            }

        }

        public void insere(String Pokemon)
        {
            NohFila novonoh = new NohFila(Pokemon); 

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

        public void imprime()
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
                    Console.Write(aux.getPokemon() + " ");
                    aux = aux.getAnterior();
                }
            }
        }

        public String retirar()
        {
            if (isEmpty())
            {
                Console.WriteLine("Fila Vazia");
                return("");
            }

            else
            {
                String aux = start.getPokemon();
                start = start.getAnterior();
                return (aux);

            }
        }

    }
}
