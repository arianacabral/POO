using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaFilaDinamica
{
    public partial class Form1 : Form
    {
        Fila fila = new Fila();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox5.Text != "")
            {
                try
                {
                    fila.insere(int.Parse(textBox5.Text));
                    textBox1.Clear();
                    limparCampos();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Informar valor!");
                textBox5.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = fila.retirar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = fila.imprime();
            limparCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = fila.getMax().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = fila.getMin().ToString();
        }

        private void limparCampos()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            limparCampos();
            textBox1.Clear();
        }
    }
}
