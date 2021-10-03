using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caBaralho
{
    class Carta
    {
        // atributos da classe
        private String m_face;
        private String m_naipe;
        private Random m_rnd;
        private int m_num;
        private Carta m_carta;

        // construtor padrão
        public Carta()
        {
            m_face = "";
            m_naipe = "";

        }

        // construtor com argumentos
        public Carta(String face, String naipe)
        {
            m_face = face;
            m_naipe = naipe;

        }

        // getters
        public String getFace()
        {
            return (m_face);
        }

        public String getNaipe()
        {
            return (m_naipe);
        }

        // setters
        public void setFace(String face)
        {
            m_face = face;
        }

        public void setNaipe(String naipe)
        {
            m_naipe = naipe;
        }

        // método para gerar a Face da carta
        public String gerarFace()
        {
            m_rnd = new Random();

            m_num = m_rnd.Next(1, 14);


            if (m_num >= 2 & m_num <= 10)
            {
                m_face = m_num.ToString();
            }
            else
            {
                switch (m_num)
                {
                    case 1:
                        m_face = "A";
                        break;
                    case 11:
                        m_face = "J";
                        break;
                    case 12:
                        m_face = "Q";
                        break;
                    case 13:
                        m_face = "K";
                        break;
                }
            }

            return (m_face);

        }

        // método para gerar Naipe da carta
        public String gerarNaipe()
        {
            m_rnd = new Random();

            m_num = m_rnd.Next(1, 5);
            switch (m_num)
            {
                case 1:
                    m_naipe = "PAUS"; 
                    break;
                case 2:
                    m_naipe = "COPAS";
                    break;
                case 3:
                    m_naipe = "ESPADAS";
                    break;
                default:
                    m_naipe = "OURO";
                    break;
            }

            return (m_naipe);

        }

        public Carta gerarCarta()
        {
            m_carta = new Carta();

            m_carta.setFace(gerarFace());
            m_carta.setNaipe(gerarNaipe());

            return (m_carta);
        }
    }
}
