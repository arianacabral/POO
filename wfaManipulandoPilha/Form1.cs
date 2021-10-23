using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaManipulandoPilha
{
    public partial class Form1 : Form
    {
        Pilha pilha = new Pilha();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) // botão de máximo
        {
            textBox3.Text = pilha.max().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = pilha.min().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limparCampos();
            textBox6.Text = pilha.print();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                try
                { 
                    pilha.push(int.Parse(textBox1.Text));
                    limparCampos();
                    textBox6.Clear();
                    textBox6.Text = pilha.print();
                }
                catch(Exception ex)
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

        public void limparCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
