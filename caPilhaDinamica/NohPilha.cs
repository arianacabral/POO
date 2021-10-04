using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    class NohPilha
    {
        // atributos
        private int data;
        private NohPilha nextNoh; // autoreferencia

        // métodos 
        public NohPilha()
        {
            data = 0;
            nextNoh = null;
        }

        public NohPilha(int valor)
        {
            data = valor;
            nextNoh = null;
        }

        public NohPilha(int valor, NohPilha noh)
        {
            data = valor;
            nextNoh = noh;
        }

        public int getData()
        {
            return(data);
        }

        public void setData(int valor)
        {
            data = valor;
        }

        public NohPilha getNext()
        {
            return(nextNoh);
        }

        public void setNext(NohPilha newNoh)
        {
            nextNoh = newNoh;
        }
    }
}
