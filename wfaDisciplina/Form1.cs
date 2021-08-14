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

namespace wfaDisciplina
{
    public partial class Form1 : Form
    {
        // atributos 
        private String m_nome;
        private String m_matricula;
        private String m_curso;
        private String m_periodo;
        private String m_disciplinas;
        private bool m_status = false;

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & checkedListBox1.CheckedItems.Count != 0 & comboBox1.Items.Count != 0)
            {

                m_nome = textBox1.Text;
                m_matricula = textBox2.Text;
                m_curso = textBox3.Text;

                m_periodo = comboBox1.Text;


                foreach (string txt in checkedListBox1.CheckedItems)
                {
                    m_disciplinas += txt + "\n";
                }

                m_status = true;

                MessageBox.Show("\t\tDisciplinas solicitadas: \n\n" + m_disciplinas);
            }
            else
            {
                MessageBox.Show("Inserir dados!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (m_status)
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
                paragrafo_aluno.Add("Nome: " + m_nome + "\n" + "Matrícula: " + m_matricula +
                    "\n" + "Período: " + m_periodo + "\n" + "Curso: " + m_curso + "\n\n");


                //criando o paragráfo com os dados das disciplinas
                paragrafo_disciplinas = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold));
                //etipulando o alinhamneto
                paragrafo_disciplinas.Alignment = Element.ALIGN_JUSTIFIED;
                //adicioando texto
                paragrafo_disciplinas.Add("Disciplinas Solicitadas\n");
                // modificando a fonte 
                paragrafo_disciplinas.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);
                //adicioando texto
                paragrafo_disciplinas.Add(m_disciplinas +
                    "\n\n\n\n" + String.Format("Solicitação de matrícula realizada em {0}.", DateTime.Now));

                //acidionado paragrafo ao documento
                doc.Add(cabecalho);
                doc.Add(paragrafo_aluno);
                doc.Add(paragrafo_disciplinas);

                //fechando documento para que as alterações sejam salvas
                doc.Close();

                MessageBox.Show("Arquivo criado com sucesso!!!");

                // limpando os campos

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;

                foreach (int i in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }

            }

            else
            {
                MessageBox.Show("Matrícula não solicitada!!!");
            }

            
        }
    }
}
