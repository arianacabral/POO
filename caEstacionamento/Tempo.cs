using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
    class Tempo
    {
        //atributos da classe
        private int hora;
        private int min;
        private int segs;
        
        // construtor padrão
        public Tempo()
        {
            hora = 0;
            min = 0;
            segs = 0;
        }

        // construtor com argumentos 
        public Tempo(int hora_, int min_, int segs_)
        {
            hora = hora_;
            min = min_;
            segs = segs_;
        }

        //getters
        public int getHora()
        {
            return (hora);
        }

        public int getMinuto()
        {
            return (min);
        }

        public int getSegundo()
        {
            return (segs);
        }

        // setters
        public void setHora(int hora_)
        {
            hora = hora_;
        }

        public void setMinuto(int min_)
        {
            min = min_;
        }

        public void setSegundo(int segs_)
        {
            segs = segs_;
        }

        public void imprimeTempo()
        {
            if (segs < 60)
            {
                if (min < 60)
                {
                    if (hora <= 24)
                    {
                        Console.WriteLine(hora.ToString() + ":" + min.ToString() + ":" + segs.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Formato hora inválido!");
                    }
                }
                else
                {
                    Console.WriteLine("Formato minuto inválido!");
                }
            }
            else
            {
                Console.WriteLine("Fomato segundo inválido!");
            }
        }

        // Método que soma dos horários
        public Tempo soma(Tempo t)
        {
            hora = hora + t.getHora();
            min = min + t.getMinuto();
            segs = segs + t.getSegundo();

            if (segs >= 60)
            {
                min = min + (segs / 60); // soma dos mins com o quociente da divisão dos segs por 60

                segs = segs % 60; // resto da divisão dos segs por 60

                if (min >= 60)
                {
                    hora = hora + (min / 60);

                    min = min % 60;
                }
            }
            else
            {
                if (min >= 60)
                {
                    hora = hora + (min / 60);

                    min = min % 60;
                }
            }

            Tempo t_soma = new Tempo(hora, min, segs);

            return (t_soma);
        }

        // Método que subtrai dos horários
        public Tempo subtrai(Tempo t)
        {
            if(hora > t.getHora())
            {
                if(min >= t.getMinuto() & segs >= t.getSegundo())
                {
                    hora = hora - t.getHora();
                    min = min - t.getMinuto();
                    segs = segs - t.getSegundo();
                }
                else if(min > t.getMinuto() & segs < t.getSegundo())
                {
                    hora = hora - t.getHora();
                    min = (min - 1) - t.getMinuto();
                    segs = (60 + segs) - t.getSegundo();                    
                }
                else if (min < t.getMinuto())
                {
                    if (segs < t.getSegundo())
                    {
                        hora = (hora - 1) - t.getHora();
                        min = (min + 59) - t.getMinuto();
                        segs = (segs + 60) - t.getSegundo();
                    }

                    else
                    {
                        hora = (hora - 1) - t.getHora();
                        min = (min + 60) - t.getMinuto();
                        segs = segs - t.getSegundo();
                    }
                }

            }

            Tempo duracao = new Tempo(hora, min, segs);

            return (duracao);
        }

        public void registarHorario()
        {
            Console.Write("\nInforme as horas: ");
            hora = int.Parse(Console.ReadLine());
            Console.Write("Informe os minutos: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Informe os segundos: ");
            segs = int.Parse(Console.ReadLine());

        }

    } // fim da classe
}
