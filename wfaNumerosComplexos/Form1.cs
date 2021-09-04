using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaNumerosComplexos
{
    public partial class Form1 : Form
    {
        NumeroComplexo z1;
        NumeroComplexo z2;
        NumeroComplexo zr;

        String operacaoComplexa;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            LimparCampos();

            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            comboBox1.Enabled = false;
            comboBox1.Visible = false;

            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            textBox3.Enabled = false;
            textBox3.Visible = false;
            textBox4.Enabled = false;
            textBox4.Visible = false;

            textBox5.Enabled = true;
            textBox5.Visible = true;

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            LimparCampos();

            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            comboBox1.Enabled = false;
            comboBox1.Visible = false;

            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            textBox3.Enabled = false;
            textBox3.Visible = false;
            textBox4.Enabled = false;
            textBox4.Visible = false;

            textBox5.Enabled = true;
            textBox5.Visible = true;

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            LimparCampos();

            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            comboBox1.Enabled = true;
            comboBox1.Visible = true;

            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            textBox3.Enabled = true;
            textBox3.Visible = true;
            textBox4.Enabled = true;
            textBox4.Visible = true;

            textBox5.Enabled = true;
            textBox5.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            z1 = new NumeroComplexo();
            z2 = new NumeroComplexo();
            zr = new NumeroComplexo();

            selecaoOperacao();

            if (operacaoComplexa == "modulo")
            {
                if (textBox1.Text != "" & textBox2.Text != "")
                {
                    z1.setRe(double.Parse(textBox1.Text));
                    z1.setIm(double.Parse(textBox2.Text));

                    textBox5.Text = z1.modulo().ToString();

                }
                else
                {
                    MessageBox.Show("Inserir dados!");

                    if (textBox1.Text == "")
                    {
                        textBox1.Focus();
                    }
                    else
                    {
                        textBox2.Focus();
                    }

                }
            }
            else if (operacaoComplexa == "conjugado")
            {
                if (textBox1.Text != "" & textBox2.Text != "")
                {
                    z1.setRe(double.Parse(textBox1.Text));
                    z1.setIm(double.Parse(textBox2.Text));

                    textBox5.Text = z1.conjugado().getRe().ToString() + " " + 
                        z1.conjugado().getIm().ToString() + " i";

                }
                else
                {
                    MessageBox.Show("Inserir dados!");

                    if (textBox1.Text == "")
                    {
                        textBox1.Focus();
                    }
                    else
                    {
                        textBox2.Focus();
                    }

                }
            }
            else if (operacaoComplexa == "operacoes")
            {
                if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & comboBox1.Text != "")
                {
                    z1.setRe(double.Parse(textBox1.Text));
                    z1.setIm(double.Parse(textBox2.Text));

                    z2.setRe(double.Parse(textBox4.Text));
                    z2.setIm(double.Parse(textBox3.Text));

                    switch (comboBox1.Text)
                    {
                        case "+":
                            zr = z1.somar(z2);
                            break;
                            
                        case "-":
                            zr = z1.subtrair(z2);                 
                            break;
                            
                        case "x":
                            zr = z1.multiplicar(z2);
                            break;
                            
                        case "/":
                            zr = z1.dividir(z2);
                            break;
                            
                        default:
                            MessageBox.Show("Inserir operação!");
                            break;
                    }

                    textBox5.Text = zr.getRe().ToString() + " + " + zr.getIm().ToString() + " i";

                }
                else
                {
                    MessageBox.Show("Inserir dados!");

                    if (textBox1.Text == "")
                    {
                        textBox1.Focus();
                    }
                    else if(textBox2.Text == "")
                    {
                        textBox2.Focus();
                    }
                    else if (textBox3.Text == "")
                    {
                        textBox3.Focus();
                    }
                    else if(textBox4.Text == "")
                    {
                        textBox4.Focus();
                    }
                    else
                    {
                        comboBox1.Focus();
                    }

                }

            }

        }

        private String selecaoOperacao()
        {
            if (radioButton1.Checked)
            {
                operacaoComplexa = "modulo";
            }
            else if (radioButton2.Checked)
            {
                operacaoComplexa = "conjugado";
            }
            else if (radioButton3.Checked)
            {
                operacaoComplexa = "operacoes";
            }
            else
            {
                MessageBox.Show("Nenhuma opção selecionada!");
            }

            return (operacaoComplexa);
        }
    }
}
