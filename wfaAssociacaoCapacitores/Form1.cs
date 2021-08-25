using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaAssociacaoCapacitores
{
    public partial class Form1 : Form
    {

        Capacitor capacitor1;
        Capacitor capacitor2;

        double c1;
        double c2;

        double multiplicador;
        String grandeza;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            capacitor1 = new Capacitor();
            capacitor2 = new Capacitor();

            if (textBox1.Text != "" & textBox1.Text != "" & comboBox1.Items.Count != 0 & comboBox2.Items.Count != 0)
            {
                capacitor1.setCapacitancia(double.Parse(textBox1.Text) * Multiplicador(comboBox1));
                capacitor2.setCapacitancia(double.Parse(textBox2.Text) * Multiplicador(comboBox2));

                textBox3.Text = OrdemGrandeza(capacitor1.associacaoSerieCom(capacitor2)).ToString();
                textBox4.Text = OrdemGrandeza(capacitor1.associacaoParaleloCom(capacitor2)).ToString();

            }
            else
            {
                MessageBox.Show("Informar os valores de capacitância dos capacitores!");

                if (textBox1.Text == "")
                {
                    textBox1.Focus();
                }
                else if(textBox2.Text == "")
                {
                    textBox2.Focus();
                }
                else if(comboBox1.Text == "")
                {
                    comboBox1.Focus();
                }
                else
                {
                    comboBox2.Focus();
                }
            }


        }


        private double Multiplicador(ComboBox cbx)
        {
            switch (cbx.Text)
            { 
                case "mF":
                    multiplicador = 1E-03;
                    break;
                case "µF":
                    multiplicador = 1E-06;
                    break;
                case "nF":
                    multiplicador = 1E-09;
                    break;
                case "pF":
                    multiplicador = 1E-12;
                    break;
                default:
                    multiplicador = 1;
                    break;
            }

            return (multiplicador);
        }


        private String OrdemGrandeza(double c)
        {
            if (c >= 1 & c < 1000)
            {
                grandeza = (c).ToString() + " F";
            }
            else if (c >= 1E-03 & c < 1)
            {
                grandeza = Math.Round(c * 1E+03,3).ToString() + " mF";
            }
            else if (c >= 1E-06 & c < 1E-03)
            {
                grandeza = Math.Round(c * 1E+06, 3).ToString() + " µF";
            }
            else if (c >= 1E-09 & c < 1E-06)
            {
                grandeza = Math.Round(c * 1E+09, 3).ToString() + " nF";
            }
            else if (c >= 1E-12 & c < 1E-09)
            {
                grandeza = Math.Round(c * 1E+12, 3).ToString() + " pF";
            }
            else
            {
                grandeza = 0.ToString() + " F";
            }

            return (grandeza);
        }

    }
}
