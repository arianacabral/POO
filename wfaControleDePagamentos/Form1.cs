using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaControleDePagamentos
{
    public partial class Form1 : Form
    {
        private List<Saude> listaPagamentosSaude;
        private List<Alimentacao> listaPagamentosAlimentacao;

        private Saude m_pagtosSaude;
        private Alimentacao m_pagtosAlimento;

        public Form1()
        {
            InitializeComponent();

            listaPagamentosSaude = new List<Saude>();
            listaPagamentosAlimentacao = new List<Alimentacao>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "")
            {
                int index = -1;

                foreach (Saude pagtosSaude in listaPagamentosSaude)
                {
                    if (pagtosSaude.getCPF() == long.Parse(textBox1.Text) & pagtosSaude.getCod() == int.Parse(textBox3.Text))
                    {
                        index = listaPagamentosSaude.IndexOf(pagtosSaude);
                    }
                }


                m_pagtosSaude = new Saude();

                m_pagtosSaude.setCPF(long.Parse(textBox1.Text));
                m_pagtosSaude.setValor(double.Parse(textBox2.Text));
                m_pagtosSaude.setCod(int.Parse(textBox3.Text));
                m_pagtosSaude.setEstabelecimento(textBox4.Text);

                if (index < 0)
                {
                    listaPagamentosSaude.Add(m_pagtosSaude);

                    MessageBox.Show("Dados do pagamento salvos!");

                }
                else
                {

                    listaPagamentosSaude[index] = m_pagtosSaude;

                    MessageBox.Show("Dados do pagamento atualizados!");

                }

                LimparCamposSaude();

                ListarPagtosSaude();

            }
            else
            {
                MessageBox.Show("Inserir dados!");

                if (textBox1.Text == "")
                {
                    textBox1.Focus();
                }
                else if (textBox2.Text == "")
                {
                    textBox2.Focus();
                }
                else if (textBox3.Text == "")
                {
                    textBox3.Focus();
                }
                else
                {
                    textBox4.Focus();
                }

            }
        }

        private void ListarPagtosSaude()
        {
            listBox1.Items.Clear();

            foreach (Saude pagtosSaude in listaPagamentosSaude)
            {
                listBox1.Items.Add(pagtosSaude.getCPF().ToString() + " - " + pagtosSaude.getCod().ToString());
            }
        }

        private void LimparCamposSaude()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & textBox8.Text != "")
            {
                int index = -1;

                foreach (Alimentacao pagtosAlimentacao in listaPagamentosAlimentacao)
                {
                    if (pagtosAlimentacao.getCPF() == long.Parse(textBox8.Text) & pagtosAlimentacao.getCod() == int.Parse(textBox6.Text))
                    {
                        index = listaPagamentosAlimentacao.IndexOf(pagtosAlimentacao);
                    }
                }


                m_pagtosAlimento = new Alimentacao();

                m_pagtosAlimento.setCPF(long.Parse(textBox8.Text));
                m_pagtosAlimento.setValor(double.Parse(textBox7.Text));
                m_pagtosAlimento.setCod(int.Parse(textBox6.Text));
                m_pagtosAlimento.setDescricao(textBox5.Text);

                if (index < 0)
                {
                    listaPagamentosAlimentacao.Add(m_pagtosAlimento);

                    MessageBox.Show("Dados do pagamento salvos!");

                }
                else
                {

                    listaPagamentosAlimentacao[index] = m_pagtosAlimento;

                    MessageBox.Show("Dados do pagamento atualizados!");

                }

                LimparCamposAlimentacao();

                ListarPagtosAlimentacao();

            }
            else
            {
                MessageBox.Show("Inserir dados!");

                if (textBox1.Text == "")
                {
                    textBox1.Focus();
                }
                else if (textBox2.Text == "")
                {
                    textBox2.Focus();
                }
                else if (textBox3.Text == "")
                {
                    textBox3.Focus();
                }
                else
                {
                    textBox4.Focus();
                }

            }

        }

        private void LimparCamposAlimentacao()
        {
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox8.Focus();
        }

        private void ListarPagtosAlimentacao()
        {
            listBox2.Items.Clear();

            foreach (Alimentacao pagtosAlimento in listaPagamentosAlimentacao)
            {
                listBox2.Items.Add(pagtosAlimento.getCPF().ToString() + " - " + pagtosAlimento.getCod().ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Alimentacao pagtosAlimento in listaPagamentosAlimentacao)
            {
                listBox3.Items.Add("CPF: " + pagtosAlimento.getCPF().ToString() + " \n " +
                    " Código: " + pagtosAlimento.getCod().ToString() + "\n" + 
                    "Valor: " + pagtosAlimento.getValor().ToString() + "\n" +
                    "Estabelecimento: " + pagtosAlimento.getDescricao().ToString() + "\n");
            }
        }
    }
}
