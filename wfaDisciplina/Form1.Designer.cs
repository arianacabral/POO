namespace wfaDisciplina
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Aluno";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(187, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(895, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Período";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1º",
            "2º",
            "3º",
            "4º",
            "5º",
            "6º",
            "7º",
            "8º",
            "9º",
            "10º",
            "11º",
            "12º"});
            this.comboBox1.Location = new System.Drawing.Point(548, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "FAMAT39106 - Álgebra Matricial e Geometria Analítica",
            "FAMAT39107 - Funções de Variáveis Reais I",
            "FEELT31101 - Introdução à Tecnologia da Computação ",
            "FEELT31106 - Introdução à Engenharia Biomédica",
            "FEMEC39101 - Expressão Gráfica",
            "IQUFU39102 - Química Geral",
            "FAMAT39203 - Funções de Variáveis Reais II ",
            "FEELT31202 - Métodos e Técnicas de Programação ",
            "FEMEC39102 - Mecânica dos Sólidos",
            "ICBIM39204 - Anatomia Humana",
            "INFIS39201 - Física I",
            "INFIS39202 - Experimental de Física I",
            "INGEB39302 - Bioquímica",
            "FAMAT39301 - Métodos Matemáticos",
            "FEELT31301 - Circuitos Elétricos I",
            "FEELT31302 - Experimental de Circuitos Elétricos I",
            "FEELT31303 - Ciência e Tecnologia dos Materiais",
            "FEELT31304 - Experimental de Ciência e Tecnologia dos Materiais",
            "FEELT31305 - Engenharia de Software ",
            "INFIS39301 - Física II ",
            "INFIS39302 - Experimental de Física II",
            "FEELT31401 - Eletrônica Analógica I ",
            "FEELT31402 - Experimental de Eletrônica Analógica I ",
            "FEELT31405 - Eletromagnetismo ",
            "FEQUI39401 - Fenômenos de Transporte ",
            "ICBIM39403 - Biofísica ",
            "INFIS39401 - Física III",
            "FEELT31403 - Circuitos Elétricos II ",
            "FEELT31404 - Experimental de Circuitos Elétricos II",
            "FAMAT39503 - Bioestatística",
            "FEELT31501 - Eletrônica Analógica II",
            "FEELT31502 - Experimental de Eletrônica Analógica II",
            "FEELT31503 - Eletrônica Digital ",
            "FEELT31504 - Experimental de Eletrônica Digital",
            "FEELT31511 - Conversão de Energia e Máquinas Elétricas",
            "FEELT31512 - Experimental de Conversão de Energia e Máquinas Elétricas",
            "ICBIM39503 - Fisiologia",
            "FEELT31503 - Eletrônica Digital",
            "FEELT31504 - Experimental de Eletrônica Digital",
            "FEELT31603 - Instalações Elétricas",
            "FEELT31604 - Experimental de Instalações Elétricas",
            "FEELT31612 - Processamento de Sinais Biomédicos",
            "FEELT31619 - Biomateriais e Próteses ",
            "FEELT31620 - Interface Homem-Máquina em Saúde ",
            "FEELT31621 - Imagens Médicas I",
            "FEELT31622 - Metrologia em Saúde",
            "FEELT31610 - Sinais e Sistemas em Engenharia Biomédica ",
            "FEELT32604 - Biomecânica ",
            "FEELT32605 - Projeto Interdisciplinar em Engenharia Biomédica",
            "FEELT31826 - Engenharia Clínica I ",
            "FEELT31824 - Imagens Médicas II ",
            "FEELT31825 - Gestão de Resíduos Hospitalares",
            "FEELT31806 - Instrumentação Biomédica I ",
            "FEELT31823 - Telemedicina",
            "FAGEN39901 - Administração",
            "FADIR39901 - Ciências Sociais e Jurídicas ",
            "IEUFU39901 - Ciências Econômicas",
            "FEELT31903 - Instrumentação Biomédica II",
            "FEELT31907 - Avaliação de Tecnologias em Saúde",
            "FEELT31909 - Engenharia Clínica II",
            "FEELT39035 - Tópicos Especiais em Engenharia Biomédica VIII: Engenharia Biomédica" +
                " Forense",
            "FEELT31514 - Programação Orientada a Objetos",
            "FEELT31005 - Estágio Obrigatório em Engenharia Biomédica"});
            this.checkedListBox1.Location = new System.Drawing.Point(17, 193);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(1065, 323);
            this.checkedListBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Disciplinas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(601, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "GERAR MATRÍCULA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Matrícula";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(187, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 32);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(782, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(302, 32);
            this.textBox3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(706, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Curso";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(854, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "SALVAR ATESTADO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 609);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Solicitação de Matrícula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

