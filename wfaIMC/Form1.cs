using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaIMC
{
    public partial class Form1 : Form
    {
        // atributos
        private double m_peso;
        private double m_altura;
        private double m_imc;
        private String m_label = "CLASSIFICAÇÃO: "; // https://abeso.org.br/

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == "")
            {
                MessageBox.Show("Peso não informado!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Altura não informada!");
            }
            else
            {
                if(double.Parse(textBox1.Text) >=0 & double.Parse(textBox2.Text) >= 0)
                {
                    m_peso = double.Parse(textBox1.Text);
                    m_altura = double.Parse(textBox2.Text);

                    m_imc = m_peso / Math.Pow(m_altura, 2);

                    label3.Enabled = true;
                    label4.Enabled = true;
                    label5.Enabled = true;

                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;

                    label4.Text = (Math.Round(m_imc, 2)).ToString();

                    if (m_imc < 18.5)
                    {
                        label5.Text = m_label+"MAGREZA";
                    }
                    else if (m_imc >= 18.5 & m_imc <= 24.9)
                    {
                        label5.Text = m_label + "SAUDÁVEL";
                    }
                    else if (m_imc >= 25 & m_imc <= 29.9)
                    {
                        label5.Text = m_label + "SOBREPESO";
                    }
                    else if (m_imc >= 30 & m_imc <= 34.9)
                    {
                        label5.Text = m_label + "OBESIDADE GRAU I";
                    }
                    else if (m_imc >= 35 & m_imc <= 39.9)
                    {
                        label5.Text = m_label + "OBESIDADE SEVERA GRAU II";
                    }
                    else
                    {
                        label5.Text = m_label + "OBESIDADE MÓRBIDA GRAU III";
                    }
                }
                else
                {
                    MessageBox.Show("Valor inválido!");
                }

            }
        }
    }
}
