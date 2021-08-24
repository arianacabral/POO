using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaFormasGeometricas
{
    public partial class Form1 : Form
    {
        FormasGeometricas formasGeometricas;

        Triangulo triangulo;
        Retangulo retangulo;
        Quadrado quadrado;
        Circulo circulo;
        Trapezio trapezio;

        String forma;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            LimparCampos();

            label1.Enabled = true;
            label1.Visible = true;
            label1.Text = "Base";
            textBox1.Enabled = true;
            textBox1.Visible = true;

            label2.Enabled = true;
            label2.Visible = true;
            label2.Text = "Altura";
            textBox2.Enabled = true;
            textBox2.Visible = true;

            label3.Enabled = false;
            label3.Visible = false;
            textBox3.Enabled = false;
            textBox3.Visible = false;


        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            LimparCampos();

            label1.Enabled = true;
            label1.Visible = true;
            label1.Text = "Base";
            textBox1.Enabled = true;
            textBox1.Visible = true;

            label2.Enabled = true;
            label2.Visible = true;
            label2.Text = "Altura";
            textBox2.Enabled = true;
            textBox2.Visible = true;

            label3.Enabled = false;
            label3.Visible = false;
            textBox3.Enabled = false;
            textBox3.Visible = false;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            LimparCampos();

            label1.Enabled = true;
            label1.Visible = true;
            label1.Text = "Lado";
            textBox1.Enabled = true;
            textBox1.Visible = true;

            label2.Enabled = false;
            label2.Visible = false;
            textBox2.Enabled = false;
            textBox2.Visible = false;

            label3.Enabled = false;
            label3.Visible = false;
            textBox3.Enabled = false;
            textBox3.Visible = false;
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            LimparCampos();

            label1.Enabled = true;
            label1.Visible = true;
            label1.Text = "Raio";
            textBox1.Enabled = true;
            textBox1.Visible = true;

            label2.Enabled = false;
            label2.Visible = false;
            textBox2.Enabled = false;
            textBox2.Visible = false;

            label3.Enabled = false;
            label3.Visible = false;
            textBox3.Enabled = false;
            textBox3.Visible = false;

        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            LimparCampos();

            label1.Enabled = true;
            label1.Visible = true;
            label1.Text = "Base Maior";
            textBox1.Enabled = true;
            textBox1.Visible = true;

            label2.Enabled = true;
            label2.Visible = true;
            label2.Text = "Base Menor";
            textBox2.Enabled = true;
            textBox2.Visible = true;

            label3.Enabled = true;
            label3.Visible = true;
            label3.Text = "Altura";
            textBox3.Enabled = true;
            textBox3.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            formasGeometricas = new FormasGeometricas();

            selecaoForma();

            if (forma == "triângulo")
            {

                if(textBox1.Text != "" & textBox2.Text != "")
                {
                    triangulo = new Triangulo();

                    triangulo.setBase(double.Parse(textBox1.Text));
                    triangulo.setAltura(double.Parse(textBox2.Text));

                    formasGeometricas = triangulo;
                    formasGeometricas.setForma(forma);
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
            else if (forma == "retângulo")
            {
                if (textBox1.Text != "" & textBox2.Text != "")
                {
                    retangulo = new Retangulo();

                    retangulo.setBase(double.Parse(textBox1.Text));
                    retangulo.setAltura(double.Parse(textBox2.Text));

                    formasGeometricas = retangulo;
                    formasGeometricas.setForma(forma);
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
            else if (forma == "quadrado")
            {
                if (textBox1.Text != "")
                {
                    quadrado = new Quadrado();

                    quadrado.setLado(double.Parse(textBox1.Text));

                    formasGeometricas = quadrado;
                    formasGeometricas.setForma(forma);
                }
                else
                {
                    MessageBox.Show("Inserir dados!");

                    textBox1.Focus();
                }

            }
            else if (forma == "trapézio")
            {
                if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "")
                {
                    trapezio = new Trapezio();

                    trapezio.setBaseMaior(double.Parse(textBox1.Text));
                    trapezio.setBaseMenor(double.Parse(textBox2.Text));
                    trapezio.setAltura(double.Parse(textBox3.Text));

                    formasGeometricas = trapezio;
                    formasGeometricas.setForma(forma);

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
                    else
                    {
                        textBox3.Focus();
                    }

                }

            }
            else if (forma == "círculo")
            {
                if (textBox1.Text != "")
                {
                    circulo = new Circulo();

                    circulo.setRaio(double.Parse(textBox1.Text));

                    formasGeometricas = circulo;
                    formasGeometricas.setForma(forma);
                }
                else
                {
                    MessageBox.Show("Inserir dados!");

                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Informar forma geométrica!");
            }

            //label4.Text = "Área \n" + formasGeometricas.getForma();

            textBox4.Text = Math.Round(formasGeometricas.calcularArea(),2).ToString();

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
        }

        private String selecaoForma()
        {
            if (radioButton1.Checked)
            {
                forma = "triângulo";
            }
            else if (radioButton2.Checked)
            {
                forma = "retângulo";
            }
            else if (radioButton3.Checked)
            {
                forma = "quadrado";
            }
            else if (radioButton4.Checked)
            {
                forma = "trapézio";
            }
            else if (radioButton5.Checked)
            {
                forma = "círculo";
            }
            else
            {
                MessageBox.Show("Nenhuma forma geométrica selecionada!");                 
            }

            return (forma);
        }
    }
}
