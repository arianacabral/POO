using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaAssociacaoDeResistores
{
    public partial class Form1 : Form
    {
        // membros

        Resistor resistor1;
        Resistor resistor2;

        int multiplicador;
        String grandeza;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resistor1 = new Resistor();
            resistor2 = new Resistor();

            if(textBox1.Text != "" & textBox2.Text != "")
            {
                resistor1.setResistencia(double.Parse(textBox1.Text)*Multiplicador(comboBox1));
                resistor2.setResistencia(double.Parse(textBox2.Text) * Multiplicador(comboBox2));

                textBox3.Text = OrdemGrandeza(Math.Round(resistor1.associacaoSerieCom(resistor2),2)).ToString();
                textBox4.Text = OrdemGrandeza(Math.Round(resistor1.associacaoParaleloCom(resistor2),2)).ToString();

            }
            else
            {
                MessageBox.Show("Inserir os valores das resistências!");

                if(textBox1.Text == "")
                {
                    textBox1.Focus();
                }
                else
                {
                    textBox2.Focus();
                }

            }
        }


        private int Multiplicador(ComboBox cbx)
        {
            switch (cbx.Text)
            {
                case "kΩ":
                    multiplicador = 1000;
                    break;
                case "MΩ":
                    multiplicador = 1000000;
                    break;
                default:
                    multiplicador = 1;
                    break;
            }

            return (multiplicador);
        }


        private String OrdemGrandeza(double r)
        {
            if (r < 1000)
            {
                grandeza = (r).ToString() + " Ω";
            }
            else if(r >= 1000 & r < 1000000)
            {
                grandeza = (r/1000).ToString() + " kΩ";
            }
            else if(r >= 1000000 & r < 1000000000)
            {
                grandeza = (r / 1000000).ToString() + " MΩ";
            }
            else if (r >= 1000000000 & r < 1000000000)
            {
                grandeza = (r / 1000000000).ToString() + " GΩ";
            }
            else
            {
                grandeza = "∞";
            }

            return (grandeza);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            textBox1.Focus();

        }
    }
}
