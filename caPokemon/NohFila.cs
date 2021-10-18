using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPokemon
{
    class NohFila
    {
        // atributos
        private String pokemon;
        private NohFila anterior;

        // construtores
        public NohFila()
        {
            pokemon = "";
            anterior = null;
        }

        public NohFila(String Pokemon)
        {
            pokemon = Pokemon;
            anterior = null;
        }

        public NohFila(String Pokemon, NohFila prior)
        {
            pokemon = Pokemon;
            anterior = prior;
        }

        //getters

        public String getPokemon()
        {
            return(pokemon);
        }

        public NohFila getAnterior()
        {
            return(anterior);
        }

        // setters
        public void setPokemon(String Pokemon)
        {
            pokemon = Pokemon;
        }

        public void setAnterior(NohFila prior)
        {
            anterior = prior;
        }


    }
}
