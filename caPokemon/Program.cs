using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila listaPokemons = new Fila();

            listaPokemons.insere("Cubone");
            listaPokemons.insere("Psyduck");
            listaPokemons.insere("Squirtle");
            listaPokemons.insere("Pikachu");
            listaPokemons.insere("Charmander");
            listaPokemons.insere("Vulpix");
            listaPokemons.insere("Togepi");
            listaPokemons.insere("Turtwig");
            listaPokemons.insere("Chimchar");
            listaPokemons.insere("Piplup");

            Console.WriteLine("\tFila de Pokémons\n");

            listaPokemons.imprime();

            Console.WriteLine("\n\n\tTirando o primeiro Pokémon da Fila\n");

            listaPokemons.retirar();

            listaPokemons.imprime();

            Console.ReadLine();

        }
    }
}
