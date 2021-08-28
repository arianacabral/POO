using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace wfaSolicitacaoDeMatricula
{
    public partial class Form1 : Form
    {
        // membros
        private List<Aluno> listaAlunos;
        private List<Disciplina> listaDisciplinas;

        private Aluno m_aluno;
        private Disciplina m_disciplina;

        private bool m_status = false;
        private bool m_relatorio = false;

        // relatório
        private String r_nome;
        private String r_matricula;
        private String r_periodo;
        private String r_curso;
        private String r_disciplinas;

        private String strPath;
        private FolderBrowserDialog objFBD;
        private Document doc;
        private string dados;
        private Paragraph cabecalho;
        private Paragraph paragrafo_aluno;
        private Paragraph paragrafo_disciplinas;

        public Form1()
        {
            InitializeComponent();

            listaAlunos = new List<Aluno>();
            listaDisciplinas = new List<Disciplina>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" & textBox2.Text != "" & comboBox1.Items.Count != 0 & comboBox2.Items.Count != 0)
            {
                int index = -1;

                foreach(Aluno aluno in listaAlunos)
                {
                    if(aluno.getNome() == textBox1.Text & aluno.getMatricula() == textBox2.Text)
                    {
                        index = listaAlunos.IndexOf(aluno);
                    }
                }


                m_aluno = new Aluno();

                m_aluno.setNome(textBox1.Text);
                m_aluno.setMatricula(textBox2.Text);
                m_aluno.setPeriodo(int.Parse(comboBox2.Text));
                m_aluno.setCurso(comboBox1.SelectedItem.ToString());

                if(index < 0)
                {
                    listaAlunos.Add(m_aluno);

                    MessageBox.Show("Dados do aluno salvo!");

                }
                else
                {

                    listaAlunos[index] = m_aluno;

                    MessageBox.Show("Dados do aluno atualizados!");

                }

                LimparCamposAluno();

                ListarAlunos();

                comboBox3.Items.Add(m_aluno.getNome() + " - " + m_aluno.getMatricula());

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
                else if (comboBox1.Items.Count == 0)
                {
                    comboBox1.Focus();
                }
                else
                {
                    comboBox2.Focus();
                }

            }
        }


        private void ListarAlunos()
        {
            listBox1.Items.Clear();

            foreach (Aluno m_aluno in listaAlunos)
            {
                listBox1.Items.Add(m_aluno.getNome() + " - " + m_aluno.getMatricula());
            }
        }

        private void LimparCamposAluno()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" & textBox4.Text != "")
            {
                int index = -1;

                foreach (Disciplina disciplina in listaDisciplinas)
                {
                    if (disciplina.getCodigo() == textBox3.Text & disciplina.getDisciplina() == textBox4.Text)
                    {
                        index = listaDisciplinas.IndexOf(disciplina);
                    }
                }


                m_disciplina = new Disciplina();

                m_disciplina.setCodigo(textBox3.Text);
                m_disciplina.setDisciplina(textBox4.Text);

                if (index < 0)
                {
                    listaDisciplinas.Add(m_disciplina);

                    MessageBox.Show("Dados da disciplina salvo!");

                }
                else
                {

                    listaDisciplinas[index] = m_disciplina;

                    MessageBox.Show("Dados do disciplinas atualizados!");

                }

                LimparCamposDisciplina();

                ListarDisciplinas();


                checkedListBox1.Items.Add(m_disciplina.getCodigo() + " - " + m_disciplina.getDisciplina());

            }
            else
            {
                MessageBox.Show("Inserir dados!");

                if (textBox3.Text == "")
                {
                    textBox3.Focus();
                }
                else 
                {
                    textBox4.Focus();
                }

            }
        }

        private void LimparCamposDisciplina()
        {
            textBox3.Text = "";
            textBox4.Text = "";

            textBox3.Focus();
        }

        private void ListarDisciplinas()
        {
            listBox2.Items.Clear();

            foreach (Disciplina m_disciplina in listaDisciplinas)
            {
                listBox2.Items.Add(m_disciplina.getCodigo() + " - " + m_disciplina.getDisciplina());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (m_status == true)
            {
                int index = -1;

                foreach (Aluno aluno in listaAlunos)
                {
                    if (aluno.getNome() == comboBox3.Text.Substring(0, comboBox3.Text.IndexOf(" - ", StringComparison.Ordinal)) & aluno.getMatricula() == comboBox3.Text.Substring(comboBox3.Text.IndexOf(" - ", StringComparison.Ordinal) + " - ".Length))
                    {
                        index = listaAlunos.IndexOf(aluno);
                    }
                }

                foreach (string txt in checkedListBox1.CheckedItems)
                {
                    listaAlunos[index].solicitarDisciplina(new Disciplina(txt.Substring(txt.IndexOf(" - ", StringComparison.Ordinal) + " - ".Length), txt.Substring(0, txt.IndexOf(" - ", StringComparison.Ordinal))));  
                }

                r_nome = "Nome: " + listaAlunos[index].getNome();
                r_matricula = "\nMatrícula: " + listaAlunos[index].getMatricula();
                r_periodo = "\nPeríodo: " + listaAlunos[index].getPeriodo() + "º";
                r_curso = "\nCurso: " + listaAlunos[index].getCurso();
                r_disciplinas = listaAlunos[index].listarDisciplinas();

                MessageBox.Show("\tSolicitação de Matrícula \n\n" + 
                    r_nome + 
                    r_matricula +
                    r_periodo +
                    r_curso +
                    "\n\nDisciplinas Solicitadas: \n" + 
                    r_disciplinas);

                m_relatorio = true;
            }
            else
            {
                MessageBox.Show("Solicitação não realizada!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text != "" & checkedListBox1.CheckedItems.Count != 0)
            {
                m_status = true;
                MessageBox.Show("Solicitação de matrícula realizada com sucesso!");
            }
            else
            {
                if(comboBox3.Text == "")
                {
                    MessageBox.Show("Selecione o Aluno!");
                    comboBox3.Focus();
                }
                else
                {
                    MessageBox.Show("Selecione as disciplinas!");
                    checkedListBox1.Focus();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (m_relatorio)
            {
                // Gerando atestado de solicitação de matrícula

                objFBD = new FolderBrowserDialog();

                objFBD.ShowDialog();

                strPath = objFBD.SelectedPath + @"\Atestado_de_matricula.pdf"; // caminho onde será salvo o arquivo 

                doc = new Document(PageSize.A4);//criando e estipulando o tipo da folha usada
                doc.SetMargins(40, 40, 40, 80);//estibulando o espaçamento das margens que queremos
                doc.AddCreationDate();//adicionando as configuracoes

                //criando o arquivo pdf em branco, passando como parâmetro a variável doc criada acima e a variavel caminho
                //tambem criada acima.
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(strPath, FileMode.Create));

                doc.Open();

                dados = "";

                //criando o cabeçalho
                cabecalho = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, (int)System.Drawing.FontStyle.Bold));
                //etipulando o alinhamneto
                cabecalho.Alignment = Element.ALIGN_CENTER; // alinhamento centralizado
                                                            //adicioando texto
                cabecalho.Add("Solicitação de Matrícula \n\n");

                //criando o paragráfo com os dados do aluno
                paragrafo_aluno = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold));
                //etipulando o alinhamneto
                paragrafo_aluno.Alignment = Element.ALIGN_JUSTIFIED;
                //adicioando texto
                paragrafo_aluno.Add("Identificação\n");
                // modificando a fonte 
                paragrafo_aluno.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);
                //adicioando texto
                paragrafo_aluno.Add(r_nome + "\n" + r_matricula +
                    "\n" + r_periodo + "\n" + r_curso + "\n\n");


                //criando o paragráfo com os dados das disciplinas
                paragrafo_disciplinas = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold));
                //etipulando o alinhamneto
                paragrafo_disciplinas.Alignment = Element.ALIGN_JUSTIFIED;
                //adicioando texto
                paragrafo_disciplinas.Add("Disciplinas Solicitadas\n");
                // modificando a fonte 
                paragrafo_disciplinas.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);
                //adicioando texto
                paragrafo_disciplinas.Add(r_disciplinas +
                    "\n\n\n\n" + String.Format("Solicitação de matrícula realizada em {0}.", DateTime.Now));

                //acidionado paragrafo ao documento
                doc.Add(cabecalho);
                doc.Add(paragrafo_aluno);
                doc.Add(paragrafo_disciplinas);

                //fechando documento para que as alterações sejam salvas
                doc.Close();

                MessageBox.Show("Soliticação de matrícula salva com sucesso!!!");

                // limpando os campos

                comboBox3.SelectedIndex = -1;

            }

            else
            {
                MessageBox.Show("Relatório não foi gerado!!!");
            }

        }

    }

}
