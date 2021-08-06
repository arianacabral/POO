using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
    class Estacionamento
    {
        // atributos da classe
        private String m_chapa;
        private String m_marca;
        private Tempo m_entrada;
        private Tempo m_saida;
        private double m_valor = 7.0;
        private Tempo m_int;
        private double m_preco;

        // construtor padrão
        public Estacionamento()
        {
            m_chapa = "";
            m_marca = "";
            m_entrada = new Tempo();
            m_saida = new Tempo();
        }

        // construtor com argumentos
        public Estacionamento(String chapa, String marca, Tempo entrada, Tempo saida)
        {
            m_chapa = chapa;
            m_marca = marca;
            m_entrada = entrada;
            m_saida = saida;
        }

        // getters
        public String getChapa()
        {
            return (m_chapa);
        }

        public String getMarca()
        {
            return (m_marca);
        }

        public Tempo getEntrada()
        {
            return (m_entrada);
        }

        public Tempo getSaida()
        {
            return (m_saida);
        }
        // setters
        public void setChapa(String chapa)
        {
            m_chapa = chapa;
        }

        public void setMarca(String marca)
        {
            m_marca = marca;
        }

        // método para cadastrar carro
        public void cadastrarCarro()
        {
            Console.Write("Informe o número de chapa do carro: ");
            m_chapa = Console.ReadLine();

            Console.Write("Informe a marca do carro: ");
            m_marca = Console.ReadLine();

            Console.Write("\nInforme o horário de entrada no estacionamento");

            Console.Write("\nInforme as horas: ");
            m_entrada.setHora(int.Parse(Console.ReadLine()));
            Console.Write("Informe os minutos: ");
            m_entrada.setMinuto(int.Parse(Console.ReadLine()));
            Console.Write("Informe os segundos: ");
            m_entrada.setSegundo(int.Parse(Console.ReadLine()));

            Console.Write("\nInforme o horário de saída do estacionamento");

            Console.Write("\nInforme as horas: ");
            m_saida.setHora(int.Parse(Console.ReadLine()));
            Console.Write("Informe os minutos: ");
            m_saida.setMinuto(int.Parse(Console.ReadLine()));
            Console.Write("Informe os segundos: ");
            m_saida.setSegundo(int.Parse(Console.ReadLine()));

        }

        public void dadosCarro()
        {
            Console.WriteLine("Chapa do carro: " + m_chapa + "\n" +
                "Marca: " + m_marca);
            Console.Write("Horário de entrada: ");
            m_entrada.imprimeTempo();
            Console.Write("Horário de saida: ");
            m_saida.imprimeTempo();
        }

        public void tempoEstacionamento()
        {
            m_int = m_saida.subtrai(m_entrada);
            m_int.imprimeTempo();
        }

        public double precoEstacionamento()
        {
            m_int = m_saida.subtrai(m_entrada);
            m_preco = m_valor*(m_int.getHora() + (m_int.getMinuto()/60.0) + (m_int.getSegundo()/3600.0));
            return (m_preco);
        }


    }// fim da classe
}
