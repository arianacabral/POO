using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construtor padrão
            Estacionamento carro1 = new Estacionamento();

            Console.WriteLine("Construtor padrão");
            Console.WriteLine("Chapa do carro: " + carro1.getChapa() + "\n" +
                "Marca: " + carro1.getMarca());
            Console.Write("Horário de Entrada: ");
            carro1.getEntrada().imprimeTempo();
            Console.Write("Horário de Saída: ");
            carro1.getSaida().imprimeTempo();

            // Construtor com argumentos

            Estacionamento carro2 = new Estacionamento("XXXX","XXXX",
                new Tempo(13, 34, 23),
                new Tempo(13, 34, 43));

            Console.WriteLine("\nConstrutor com argumentos");
            Console.WriteLine("Chapa do carro: " + carro2.getChapa() + "\n"+
                "Marca: "+ carro2.getMarca());
            Console.Write("Horário de Entrada: ");
            carro2.getEntrada().imprimeTempo();
            Console.Write("Horário de Saída: ");
            carro2.getSaida().imprimeTempo();

            // Lendo dados do console

            Console.WriteLine("\n\n\t...Cadastrando carro...\n");

            Estacionamento carro3 = new Estacionamento();

            carro3.cadastrarCarro();

            Console.WriteLine("\n\n\t...Dados do carro cadastrado...\n");

            carro3.dadosCarro();

            /*
            // Intervalo de tempo entre dois horários
            
            Tempo ti = new Tempo();
            Tempo tf = new Tempo();

            Console.Write("\nHorário inicial");
            ti.registarHorario();

            Console.Write("\nHorário final");
            tf.registarHorario();

            Console.Write("\nHorário inicial: ");
            ti.imprimeTempo();
            Console.Write("Horário final: ");
            tf.imprimeTempo();
            Console.Write("Intervalo de tempo: ");
            tf.subtrai(ti).imprimeTempo();
            */

            // Preço pelo Estacionamento
            Console.Write("\nTempo de estacionamento: ");
            carro3.tempoEstacionamento();
            Console.WriteLine("\nPreço do Estacionamento: R$ " + Math.Round(carro3.precoEstacionamento(),3).ToString());
            
            Console.ReadLine();
        }
    }
}
