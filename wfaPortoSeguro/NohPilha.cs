using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPortoSeguro
{
    class NohPilha
    {
        // atributos
        private int data;
        private NohPilha nextNoh;

        // construtor padrão
        public NohPilha()
        {
            data = 0;
            nextNoh = null;
        }

        // construtor com argumentos - aridade 1
        public NohPilha(int valor)
        {
            data = valor;
            nextNoh = null;
        }

        // construtor com argumentos - aridade 2
        public NohPilha(int valor, NohPilha noh)
        {
            data = valor;
            nextNoh = noh;
        }

        public int getData()
        {
            return (data);
        }

        public void setData(int valor)
        {
            data = valor;
        }

        public NohPilha getNext()
        {
            return (nextNoh);
        }

        public void setNext(NohPilha newNoh)
        {
            nextNoh = newNoh;
        }
    }
}
