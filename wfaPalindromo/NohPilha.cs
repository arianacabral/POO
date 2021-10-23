using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPalindromo
{
    class NohPilha
    {
        // atributos
        private string str;
        private NohPilha nextNoh; // autoreferencia

        // métodos 
        public NohPilha()
        {
            str = "";
            nextNoh = null;
        }

        public NohPilha(string letra)
        {
            str = letra;
            nextNoh = null;
        }

        public NohPilha(string letra, NohPilha noh)
        {
            str = letra;
            nextNoh = noh;
        }

        public string getData()
        {
            return (str);
        }

        public void setData(string letra)
        {
            str = letra;
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
