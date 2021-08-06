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
        double m_modulo;
        double m_ang;
        double[] m_proj = new double[2];

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
            double prodct_esc = (m_x * v.m_x) + (m_y * v.m_y);
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
        public double[] projecaoEm(Vetor v)
        {
            double prodct_esc = (m_x * v.m_x) + (m_y * v.m_y);
            double proj_X = (prodct_esc/Math.Pow(v.modulo(), 2))*v.getX();
            double proj_Y = (prodct_esc / Math.Pow(v.modulo(), 2)) * v.getY();
            m_proj[0] = (prodct_esc / (Math.Pow(v.modulo(), 2))) * v.getX();
            m_proj[1] = (prodct_esc / (Math.Pow(v.modulo(), 2))) * v.getY();
      
            return (m_proj);
        }

    }//fim da classe
}
