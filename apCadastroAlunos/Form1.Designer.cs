namespace apCadastroAlunos
{
    partial class FrmCadastro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLerArquivo1 = new System.Windows.Forms.Button();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lsbUm = new System.Windows.Forms.ListBox();
            this.lsbDois = new System.Windows.Forms.ListBox();
            this.lsbTres = new System.Windows.Forms.ListBox();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.btnExe1 = new System.Windows.Forms.Button();
            this.btnExe2 = new System.Windows.Forms.Button();
            this.btnLerArquivo2 = new System.Windows.Forms.Button();
            this.btnExe3 = new System.Windows.Forms.Button();
            this.btnExe4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "RA: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota: ";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(247, 32);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(96, 38);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(367, 32);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(96, 38);
            this.btnProcurar.TabIndex = 4;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(486, 32);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 38);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLerArquivo1
            // 
            this.btnLerArquivo1.Location = new System.Drawing.Point(247, 131);
            this.btnLerArquivo1.Name = "btnLerArquivo1";
            this.btnLerArquivo1.Size = new System.Drawing.Size(96, 38);
            this.btnLerArquivo1.TabIndex = 6;
            this.btnLerArquivo1.Text = "Arquivo 1";
            this.btnLerArquivo1.UseVisualStyleBackColor = true;
            this.btnLerArquivo1.Click += new System.EventHandler(this.btnLerArquivo1_Click);
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(111, 34);
            this.txtRA.MaxLength = 5;
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(100, 24);
            this.txtRA.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(111, 88);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(450, 24);
            this.txtNome.TabIndex = 8;
            // 
            // lsbUm
            // 
            this.lsbUm.FormattingEnabled = true;
            this.lsbUm.ItemHeight = 18;
            this.lsbUm.Location = new System.Drawing.Point(27, 213);
            this.lsbUm.Name = "lsbUm";
            this.lsbUm.Size = new System.Drawing.Size(502, 94);
            this.lsbUm.TabIndex = 10;
            // 
            // lsbDois
            // 
            this.lsbDois.FormattingEnabled = true;
            this.lsbDois.ItemHeight = 18;
            this.lsbDois.Location = new System.Drawing.Point(28, 337);
            this.lsbDois.Name = "lsbDois";
            this.lsbDois.Size = new System.Drawing.Size(501, 94);
            this.lsbDois.TabIndex = 11;
            // 
            // lsbTres
            // 
            this.lsbTres.FormattingEnabled = true;
            this.lsbTres.ItemHeight = 18;
            this.lsbTres.Location = new System.Drawing.Point(28, 465);
            this.lsbTres.Name = "lsbTres";
            this.lsbTres.Size = new System.Drawing.Size(501, 94);
            this.lsbTres.TabIndex = 12;
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.DefaultExt = "*.txt";
            this.dlgAbrir.InitialDirectory = "c:\\temp";
            this.dlgAbrir.Title = "Selecione o arquivo a ser aberto";
            // 
            // btnExe1
            // 
            this.btnExe1.Location = new System.Drawing.Point(566, 213);
            this.btnExe1.Name = "btnExe1";
            this.btnExe1.Size = new System.Drawing.Size(96, 38);
            this.btnExe1.TabIndex = 13;
            this.btnExe1.Text = "1. Contar";
            this.btnExe1.UseVisualStyleBackColor = true;
            this.btnExe1.Click += new System.EventHandler(this.btnExe1_Click);
            // 
            // btnExe2
            // 
            this.btnExe2.Location = new System.Drawing.Point(566, 311);
            this.btnExe2.Name = "btnExe2";
            this.btnExe2.Size = new System.Drawing.Size(96, 38);
            this.btnExe2.TabIndex = 14;
            this.btnExe2.Text = "2. Separar";
            this.btnExe2.UseVisualStyleBackColor = true;
            this.btnExe2.Click += new System.EventHandler(this.btnExe2_Click);
            // 
            // btnLerArquivo2
            // 
            this.btnLerArquivo2.Location = new System.Drawing.Point(566, 418);
            this.btnLerArquivo2.Name = "btnLerArquivo2";
            this.btnLerArquivo2.Size = new System.Drawing.Size(97, 44);
            this.btnLerArquivo2.TabIndex = 15;
            this.btnLerArquivo2.Text = "Ler Arquivo 2";
            this.btnLerArquivo2.UseVisualStyleBackColor = true;
            this.btnLerArquivo2.Click += new System.EventHandler(this.btnLerArquivo2_Click);
            // 
            // btnExe3
            // 
            this.btnExe3.Location = new System.Drawing.Point(704, 424);
            this.btnExe3.Name = "btnExe3";
            this.btnExe3.Size = new System.Drawing.Size(96, 38);
            this.btnExe3.TabIndex = 16;
            this.btnExe3.Text = "Juntar";
            this.btnExe3.UseVisualStyleBackColor = true;
            this.btnExe3.Click += new System.EventHandler(this.btnExe3_Click);
            // 
            // btnExe4
            // 
            this.btnExe4.Location = new System.Drawing.Point(567, 507);
            this.btnExe4.Name = "btnExe4";
            this.btnExe4.Size = new System.Drawing.Size(117, 40);
            this.btnExe4.TabIndex = 17;
            this.btnExe4.Text = "4. Inverter Lista";
            this.btnExe4.UseVisualStyleBackColor = true;
            this.btnExe4.Click += new System.EventHandler(this.btnExe4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Quantos Nós:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Exercício 3";
            // 
            // nudNota
            // 
            this.nudNota.Location = new System.Drawing.Point(111, 139);
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(81, 24);
            this.nudNota.TabIndex = 20;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(620, 88);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 38);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 584);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.nudNota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExe4);
            this.Controls.Add(this.btnExe3);
            this.Controls.Add(this.btnLerArquivo2);
            this.Controls.Add(this.btnExe2);
            this.Controls.Add(this.btnExe1);
            this.Controls.Add(this.lsbTres);
            this.Controls.Add(this.lsbDois);
            this.Controls.Add(this.lsbUm);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.btnLerArquivo1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadastro";
            this.Text = "Cadastro de Alunos com lista ligada";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLerArquivo1;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox lsbUm;
        private System.Windows.Forms.ListBox lsbDois;
        private System.Windows.Forms.ListBox lsbTres;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.Button btnExe1;
        private System.Windows.Forms.Button btnExe2;
        private System.Windows.Forms.Button btnLerArquivo2;
        private System.Windows.Forms.Button btnExe3;
        private System.Windows.Forms.Button btnExe4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.Button btnLimpar;
    }
}

