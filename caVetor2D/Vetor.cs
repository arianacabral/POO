using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor2D
{
    class Vetor
    {
        // membros da classe
        private double m_x;
        private double m_y;
        private double m_modulo;
        private double m_ang;
        private Vetor m_proj;

        // construtor da classe
        public Vetor()
        {
            m_x = 0.0;
            m_y = 0.0; 
        }

        public Vetor(double x, double y)
        {
            m_x = x;
            m_y = y; 
        }

        // getters
        public double getX()
        {
            return(m_x);
        }
        public double getY()
        {
            return (m_y);
        }

        // setters
        public void setX(double x)
        {
            m_x = x; 
        }
        public void setY(double y)
        {
            m_y = y;
        }

        // Função para cálculo do Módulo de um vetor 2D

        public double modulo()
        {
            m_modulo = Math.Sqrt(Math.Pow(m_x,2) + Math.Pow(m_y,2));
            return (m_modulo);
        }

        // Função para cálculo do Produto Escalar entre dois vetores 2D
        public double prodctEscalarCom(Vetor v)
        {
            double prodct_esc = (m_x * v.getX()) + (m_y * v.getY());
            return (prodct_esc);
        }
  

        // Função para cálculo do angulo entre dois vetores 2D
        public double anguloCom(Vetor v)
        {
            m_ang = Math.Acos (prodctEscalarCom(v)/ (Math.Sqrt(Math.Pow(m_x, 2) + Math.Pow(m_y, 2))*v.modulo()));
            m_ang = m_ang * (180 / Math.PI);
            return (m_ang);
        }

        // Função para cálculo da projeção de um vetor em outro vetor
        public Vetor projecaoEm(Vetor v)
        {
            m_proj = new Vetor();

            m_proj.setX((prodctEscalarCom(v) / (Math.Pow(v.modulo(), 2))) * v.getX());
            m_proj.setY((prodctEscalarCom(v) / (Math.Pow(v.modulo(), 2))) * v.getY());
      
            return (m_proj);
        }

    }//fim da classe
}
