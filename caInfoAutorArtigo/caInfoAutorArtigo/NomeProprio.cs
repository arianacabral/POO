using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caInfoAutorArtigo
{
    internal class NomeProprio
    {
        // atributos
        private String _nome_completo;
        private String _nome_paper;

        // construtor padrão
        public NomeProprio()
        {
            _nome_completo = "";
            _nome_paper = "";
        }

        // construtor com apenas um atributos de entrada
        public NomeProprio(String nome_completo)
        {
            _nome_completo = nome_completo;
           setNomeCitacao();
        }

        // método para obter a quantidade de partes no nome
        public int getNumPartesNome(String nome_completo)
        {
            return nome_completo.Split(' ').Length;
        }

        // método para obter primeiro nome
        public String getPrimeiroNome(String nome_completo)
        {
            String _primeiro_nome = nome_completo.Split(' ').FirstOrDefault();

            return _primeiro_nome;
        }

        // método para obter o nome do meio
        public String getNomeMeio(String nome_completo)
        {

            var _partes = nome_completo.Split(' ');

            String _nomeMeio = "";

            for (int i = 1; i < _partes.Length - 1; i++)
            {
                if(_partes[i].Length == 2)
                {
                    if (!char.IsLetter(_partes[i][0]) || _partes[i][1] != '.')
                    {
                        _nomeMeio = _partes[i];
                    }
                }

                _nomeMeio += _partes[i].FirstOrDefault() + ". ";

            }

            _nomeMeio = _nomeMeio.Trim();

            return _nomeMeio;
        }

        // método para obter o sobrenome
        public String getSobrenome(String nome_completo)
        {
            String _sobrenome = nome_completo.Split(' ').LastOrDefault();

            return _sobrenome;
        }

        // método que define o nome de citação com base no nome completo
        public void setNomeCitacao() 
        {
            int numPartesNome = getNumPartesNome(_nome_completo);

            if (numPartesNome == 2) // Primeiro Nome + Sobrenome
            {
                _nome_paper = getSobrenome(_nome_completo) + ", " + getPrimeiroNome(_nome_completo);
            }
            else if (numPartesNome >= 3) // Primeiro Nome + Nome do Meio + Sobrenome
            {
                _nome_paper = getSobrenome(_nome_completo) + ", " + getPrimeiroNome(_nome_completo) + " " + getNomeMeio(_nome_completo);
            }
            else 
            {
                _nome_paper = _nome_completo;
            }
        }

        // set e get para o Nome Completo 
        public string Nome_completo 
        { 
            get => _nome_completo;
            set
            {
                _nome_completo = value;
                setNomeCitacao();
            } 
        }

        // get do Nome no Paper
        public string Nome_paper { get => _nome_paper; }

        // método que imprime as informações
        public void ImprimeNomePaper()
        {
            Console.WriteLine("Nome Completo: " + _nome_completo);
            Console.WriteLine("Nome em citações bibliográficas: " + _nome_paper);
            Console.WriteLine();
        }

    }
}
