using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFilaDinamica
{
    class NohFila
    {
        // atributos
        private int data;
        private NohFila anterior;

        // construtores
        public NohFila()
        {
            data = 0;
            anterior = null;
        }

        public NohFila(int valor)
        {
            data = valor;
            anterior = null;
        }

        public NohFila(int valor, NohFila prior)
        {
            data = valor;
            anterior = prior;
        }

        //getters

        public int getData()
        {
            return (data);
        }

        public NohFila getAnterior()
        {
            return (anterior);
        }

        // setters
        public void setData(int valor)
        {
            data = valor;
        }

        public void setAnterior(NohFila prior)
        {
            anterior = prior;
        }
    }
}
