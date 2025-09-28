namespace AppAcademia
{
    partial class FormNovoAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNomeAluno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbTelefoneAluno = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatusAluno = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvarAluno = new System.Windows.Forms.Button();
            this.btnNovoAluno = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSelecionarTurma = new System.Windows.Forms.TextBox();
            this.btnSelecionarTurma = new System.Windows.Forms.Button();
            this.tbSelecionarPlano = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelecionarPlano = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnAdicionarFoto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNomeAluno
            // 
            this.tbNomeAluno.Enabled = false;
            this.tbNomeAluno.Location = new System.Drawing.Point(12, 23);
            this.tbNomeAluno.Name = "tbNomeAluno";
            this.tbNomeAluno.Size = new System.Drawing.Size(427, 20);
            this.tbNomeAluno.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nome";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Telefone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mtbTelefoneAluno
            // 
            this.mtbTelefoneAluno.Enabled = false;
            this.mtbTelefoneAluno.Location = new System.Drawing.Point(12, 68);
            this.mtbTelefoneAluno.Mask = "(99) 00000-0000";
            this.mtbTelefoneAluno.Name = "mtbTelefoneAluno";
            this.mtbTelefoneAluno.Size = new System.Drawing.Size(427, 20);
            this.mtbTelefoneAluno.TabIndex = 50;
            this.mtbTelefoneAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbStatusAluno
            // 
            this.cbStatusAluno.Enabled = false;
            this.cbStatusAluno.FormattingEnabled = true;
            this.cbStatusAluno.Location = new System.Drawing.Point(12, 118);
            this.cbStatusAluno.Name = "cbStatusAluno";
            this.cbStatusAluno.Size = new System.Drawing.Size(208, 21);
            this.cbStatusAluno.TabIndex = 52;
            this.cbStatusAluno.SelectedIndexChanged += new System.EventHandler(this.cbStatusAluno_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalvarAluno);
            this.panel1.Controls.Add(this.btnNovoAluno);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 30);
            this.panel1.TabIndex = 53;
            // 
            // btnSalvarAluno
            // 
            this.btnSalvarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarAluno.Enabled = false;
            this.btnSalvarAluno.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAluno.Location = new System.Drawing.Point(119, 3);
            this.btnSalvarAluno.Name = "btnSalvarAluno";
            this.btnSalvarAluno.Size = new System.Drawing.Size(101, 23);
            this.btnSalvarAluno.TabIndex = 7;
            this.btnSalvarAluno.Text = "Salvar";
            this.btnSalvarAluno.UseVisualStyleBackColor = true;
            this.btnSalvarAluno.Click += new System.EventHandler(this.btnSalvarAluno_Click);
            // 
            // btnNovoAluno
            // 
            this.btnNovoAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoAluno.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAluno.Location = new System.Drawing.Point(3, 3);
            this.btnNovoAluno.Name = "btnNovoAluno";
            this.btnNovoAluno.Size = new System.Drawing.Size(110, 23);
            this.btnNovoAluno.TabIndex = 6;
            this.btnNovoAluno.Text = "Novo";
            this.btnNovoAluno.UseVisualStyleBackColor = true;
            this.btnNovoAluno.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(337, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 23);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(226, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "Turma";
            // 
            // tbSelecionarTurma
            // 
            this.tbSelecionarTurma.Location = new System.Drawing.Point(226, 118);
            this.tbSelecionarTurma.Name = "tbSelecionarTurma";
            this.tbSelecionarTurma.ReadOnly = true;
            this.tbSelecionarTurma.Size = new System.Drawing.Size(213, 20);
            this.tbSelecionarTurma.TabIndex = 55;
            this.tbSelecionarTurma.Tag = "1";
            // 
            // btnSelecionarTurma
            // 
            this.btnSelecionarTurma.Location = new System.Drawing.Point(409, 116);
            this.btnSelecionarTurma.Name = "btnSelecionarTurma";
            this.btnSelecionarTurma.Size = new System.Drawing.Size(30, 23);
            this.btnSelecionarTurma.TabIndex = 56;
            this.btnSelecionarTurma.Text = "...";
            this.btnSelecionarTurma.UseVisualStyleBackColor = true;
            this.btnSelecionarTurma.Click += new System.EventHandler(this.btnSelecionarTurma_Click);
            // 
            // tbSelecionarPlano
            // 
            this.tbSelecionarPlano.Location = new System.Drawing.Point(12, 163);
            this.tbSelecionarPlano.Name = "tbSelecionarPlano";
            this.tbSelecionarPlano.ReadOnly = true;
            this.tbSelecionarPlano.Size = new System.Drawing.Size(427, 20);
            this.tbSelecionarPlano.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 57;
            this.label5.Text = "Plano";
            // 
            // btnSelecionarPlano
            // 
            this.btnSelecionarPlano.Location = new System.Drawing.Point(409, 160);
            this.btnSelecionarPlano.Name = "btnSelecionarPlano";
            this.btnSelecionarPlano.Size = new System.Drawing.Size(30, 23);
            this.btnSelecionarPlano.TabIndex = 59;
            this.btnSelecionarPlano.Text = "...";
            this.btnSelecionarPlano.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(15, 206);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(110, 145);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 61;
            this.pbFoto.TabStop = false;
            // 
            // btnAdicionarFoto
            // 
            this.btnAdicionarFoto.Location = new System.Drawing.Point(156, 328);
            this.btnAdicionarFoto.Name = "btnAdicionarFoto";
            this.btnAdicionarFoto.Size = new System.Drawing.Size(261, 23);
            this.btnAdicionarFoto.TabIndex = 62;
            this.btnAdicionarFoto.Text = "Adicionar Foto";
            this.btnAdicionarFoto.UseVisualStyleBackColor = true;
            this.btnAdicionarFoto.Click += new System.EventHandler(this.btnAdicionarFoto_Click);
            // 
            // FormNovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 406);
            this.Controls.Add(this.btnAdicionarFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnSelecionarPlano);
            this.Controls.Add(this.tbSelecionarPlano);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSelecionarTurma);
            this.Controls.Add(this.tbSelecionarTurma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbStatusAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbTelefoneAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomeAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNovoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Aluno";
            this.Load += new System.EventHandler(this.FormNovoAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomeAluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStatusAluno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvarAluno;
        private System.Windows.Forms.Button btnNovoAluno;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelecionarTurma;
        private System.Windows.Forms.TextBox tbSelecionarPlano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelecionarPlano;
        public System.Windows.Forms.TextBox tbSelecionarTurma;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnAdicionarFoto;
    }
}