using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTempo
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

            if(segs < 60)
            {
                if(min < 60)
                {
                    if(hora <= 24)
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

        // Método que registra o horário

        public void registraHorario()
        {
            Console.Write("\nInforme as horas: ");
            hora = int.Parse(Console.ReadLine());
            Console.Write("Informe os minutos: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Informe os segundos: ");
            segs = int.Parse(Console.ReadLine());
        }

        // Método que soma dos horários
        public Tempo soma(Tempo t)
        {
            hora = hora + t.getHora();
            min = min + t.getMinuto();
            segs = segs + t.getSegundo();

            if(segs >= 60)
            {
                min = min + (segs/60); // soma dos mins com o quociente da divisão dos segs por 60

                segs = segs % 60; // resto da divisão dos segs por 60
                
                if(min >= 60)
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

            Tempo t_soma = new Tempo(hora,min,segs);

            return (t_soma);
        }

    }// fim da classe
}
