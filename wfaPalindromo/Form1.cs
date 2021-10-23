using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaPalindromo
{
    public partial class Form1 : Form
    {
        Pilha pilha = new Pilha();

        public Form1()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "---";
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    pilha.push(textBox1.Text.ToUpper());
                    limparCampos();
                    textBox6.Clear();
                    textBox6.Text = pilha.print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Inserir valor!");
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = pilha.pop().ToString();
                textBox6.Clear();
                textBox6.Text = pilha.print();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limparCampos();
            textBox6.Text = pilha.print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (pilha.isEmpty())
                {
                    MessageBox.Show("Pilha Vazia!");
                }
                else
                {
                    if (pilha.isPalindromo())
                    {
                        label1.Text = "SIM";
                        label1.BackColor = Color.Green;
                        textBox6.Text = pilha.print();
                    }
                    else
                    {
                        label1.Text = "NÃO";
                        label1.BackColor = Color.Red;
                        textBox6.Text = pilha.print();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            limparCampos();
            textBox6.Text = pilha.invert();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            limparCampos();
        }
    }
}
