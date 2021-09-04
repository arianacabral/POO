using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaNumerosComplexos
{
    class NumeroComplexo
    {
        // atributos
        private double m_Re;
        private double m_Im;

        private NumeroComplexo m_soma;
        private NumeroComplexo m_subtracao;
        private NumeroComplexo m_multiplicacao;
        private NumeroComplexo m_conjugado;
        private NumeroComplexo m_divisao;

        // construtor padrão
        public NumeroComplexo()
        {
            m_Re = m_Im = 0.0;
        }

        // construtor com argumentos
        public NumeroComplexo(double Re, double Im)
        {
            m_Re = Re;
            m_Im = Im;
        }

        // getters
        public double getRe()
        {
            return (m_Re);
        }

        public double getIm()
        {
            return (m_Im);
        }

        // setters
        public void setRe(double Re)
        {
            m_Re = Re;
        }

        public void setIm(double Im)
        {
            m_Im = Im;
        }

        // método para a adição de dois números complexos
        public NumeroComplexo somar(NumeroComplexo z)
        {
            m_soma = new NumeroComplexo();

            m_soma.setRe(m_Re + z.getRe());

            m_soma.setIm(m_Im + z.getIm());

            return (m_soma);
        }

        // método para a subtração de dois números complexos
        public NumeroComplexo subtrair(NumeroComplexo z)
        {
            m_subtracao = new NumeroComplexo();

            m_subtracao.setRe(m_Re - z.getRe());

            m_subtracao.setIm(m_Im - z.getIm());

            return (m_subtracao);
        }

        // método para a multiplicação de dois números complexos
        public NumeroComplexo multiplicar(NumeroComplexo z)
        {
            m_multiplicacao = new NumeroComplexo();

            m_multiplicacao.setRe((m_Re * z.getRe()) - (m_Im * z.getIm()));

            m_multiplicacao.setIm((m_Re * z.getIm()) + (z.getRe() * m_Im));

            return (m_multiplicacao);
        }

        // método para calcular o conjugado de um número complexo
        public NumeroComplexo conjugado()
        {
            m_conjugado = new NumeroComplexo(m_Re, (-1) * m_Im);

            return (m_conjugado);
        }

        // método para a divisão de dois números complexos
        public NumeroComplexo dividir(NumeroComplexo z)
        {
            m_divisao = new NumeroComplexo();

            m_divisao.setRe(((m_Re * z.getRe())+(m_Im * z.getIm()))/(Math.Pow(z.getRe(), 2) + Math.Pow(z.getIm(), 2)));

            m_divisao.setIm((((-1)* (m_Re * z.getIm())) + (m_Im * z.getRe())) / (Math.Pow(z.getRe(), 2) + Math.Pow(z.getIm(), 2)));

            return (m_divisao);
        }

        // método para calcular o módulo de um número complexo
        public double modulo()
        {
           return (Math.Sqrt(Math.Pow(m_Re,2) + Math.Pow(m_Im, 2)));
        }

    }
}
