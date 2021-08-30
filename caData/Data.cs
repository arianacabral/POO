using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caData
{
    class Data
    {
        // atributos
        private int m_dia;
        private int m_mes;
        private int m_ano;

        private String m_mesExt;
        private Data m_clone;

        // construtor padrão
        public Data()
        {
            m_dia = m_mes = m_ano = 0;
        }

        // construtor com argumentos
        public Data(int dia, int mes, int ano)
        {
            m_dia = dia;
            m_mes = mes;
            m_ano = ano;
        }

        // getters
        public int getDia()
        {
            return (m_dia);
        }

        public int getMes()
        {
            return (m_mes);
        }

        public String getMesExtenso()
        {
            switch (m_mes)
            {
                case 1:
                    m_mesExt = "Janeiro";
                    break;
                case 2:
                    m_mesExt = "Fevereiro";
                    break;
                case 3:
                    m_mesExt = "Março";
                    break;
                case 4:
                    m_mesExt = "Abril";
                    break;
                case 5:
                    m_mesExt = "Maio";
                    break;
                case 6:
                    m_mesExt = "Junho";
                    break;
                case 7:
                    m_mesExt = "Julho";
                    break;
                case 8:
                    m_mesExt = "Agosto";
                    break;
                case 9:
                    m_mesExt = "Setembro";
                    break;
                case 10:
                    m_mesExt = "Outubro";
                    break;
                case 11:
                    m_mesExt = "Novembro";
                    break;
                default:
                    m_mesExt = "Dezembro";
                    break;
            }

            return (m_mesExt);
        }

        public int getAno()
        {
            return (m_ano);
        }

        // setters
        public void setDia(int dia)
        {
            m_dia = dia;
        }

        public void setMes(int mes)
        {
            m_mes = mes;
        }

        public void setAno(int ano)
        {
            m_ano = ano;
        }

        // método para comparar
        public int compara(Data data)
        {
            if(m_ano == data.getAno())
            {
                if(m_mes == data.getMes())
                {
                    if(m_dia == data.getDia())
                    {
                        return (0);
                    }
                    else
                    {
                        if(m_dia > data.getDia())
                        {
                            return (1);
                        }
                        else
                        {
                            return (-1);
                        }
                    }
                }
                else
                {
                    if(m_mes > data.getMes())
                    {
                        return (1);
                    }
                    else
                    {
                        return (-1);
                    }
                }
            }
            else
            {
                if(m_ano > data.getAno())
                {
                    return (1);
                }
                else
                {
                    return (-1);
                }

            }

        }

        // método para verificar se o ano é bissexto
        public bool isBissexto()
        {
            if ((m_ano % 4 == 0 && m_ano % 100 != 0) || m_ano % 400 == 0)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        // método para clonar objeto
        public Data clone()
        {
            m_clone = new Data(this.m_dia, this.m_mes, this.m_ano);
            
            return (m_clone);
        }
    } // fim da classe
}
