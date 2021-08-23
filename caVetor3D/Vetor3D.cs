using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    class Vetor3D:Vetor2D
    {
        // atributos 
        private double m_z;
        private Vetor3D prodVetorial;

        // construtor padrão 
        public Vetor3D(): base()
        {
            m_z = 0.0;
        }

        // construtor com argumentos 
        public Vetor3D(double x, double y, double z):base(x, y)
        {
            m_z = z;
        }

        // getter
        public double getZ()
        {
            return (m_z);
        }

        // setter
        public void setZ(double z)
        {
            m_z = z;
        }

        // método para cálculo do módulo de um vetor 3D
        public override double modulo()
        {
            m_modulo = Math.Sqrt(Math.Pow(m_x, 2) + Math.Pow(m_y, 2) + Math.Pow(m_z, 2));
            return (m_modulo);
        }

        // método para cálculo do produto vetorial entre dois vetores 3D
        public Vetor3D prodctVetorialCom(Vetor3D v)
        {
            prodVetorial = new Vetor3D();

            prodVetorial.setX(v.getZ() * m_y - m_z * v.getY());

            prodVetorial.setY(m_z * v.getX() - m_x * v.getZ());

            prodVetorial.setZ(m_x * v.getY() - m_y * v.getX());

            return (prodVetorial);
        }

    }
}
