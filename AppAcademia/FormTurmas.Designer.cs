namespace AppAcademia
{
    partial class FormTurmas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvarTurma = new System.Windows.Forms.Button();
            this.btnNovaTurma = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnImprimirTurma = new System.Windows.Forms.Button();
            this.btnExcluirTurma = new System.Windows.Forms.Button();
            this.cbProfessor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nMaximoAlunos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDescricaoTurma = new System.Windows.Forms.TextBox();
            this.tbVagas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaximoAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.AllowUserToAddRows = false;
            this.dgvTurmas.AllowUserToDeleteRows = false;
            this.dgvTurmas.AllowUserToResizeColumns = false;
            this.dgvTurmas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurmas.EnableHeadersVisualStyles = false;
            this.dgvTurmas.Location = new System.Drawing.Point(12, 12);
            this.dgvTurmas.MultiSelect = false;
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurmas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTurmas.RowHeadersVisible = false;
            this.dgvTurmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurmas.Size = new System.Drawing.Size(414, 292);
            this.dgvTurmas.TabIndex = 32;
            this.dgvTurmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurmas_CellContentClick);
            this.dgvTurmas.SelectionChanged += new System.EventHandler(this.dgvTurmas_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalvarTurma);
            this.panel1.Controls.Add(this.btnNovaTurma);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnImprimirTurma);
            this.panel1.Controls.Add(this.btnExcluirTurma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 30);
            this.panel1.TabIndex = 31;
            // 
            // btnSalvarTurma
            // 
            this.btnSalvarTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarTurma.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTurma.Location = new System.Drawing.Point(132, 4);
            this.btnSalvarTurma.Name = "btnSalvarTurma";
            this.btnSalvarTurma.Size = new System.Drawing.Size(114, 23);
            this.btnSalvarTurma.TabIndex = 7;
            this.btnSalvarTurma.Text = "Salvar Alterações";
            this.btnSalvarTurma.UseVisualStyleBackColor = true;
            this.btnSalvarTurma.Click += new System.EventHandler(this.btnSalvarTurma_Click);
            // 
            // btnNovaTurma
            // 
            this.btnNovaTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaTurma.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaTurma.Location = new System.Drawing.Point(12, 4);
            this.btnNovaTurma.Name = "btnNovaTurma";
            this.btnNovaTurma.Size = new System.Drawing.Size(114, 23);
            this.btnNovaTurma.TabIndex = 6;
            this.btnNovaTurma.Text = "Nova Turma";
            this.btnNovaTurma.UseVisualStyleBackColor = true;
            this.btnNovaTurma.Click += new System.EventHandler(this.btnNovaTurma_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(492, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(114, 23);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnImprimirTurma
            // 
            this.btnImprimirTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirTurma.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirTurma.Location = new System.Drawing.Point(372, 4);
            this.btnImprimirTurma.Name = "btnImprimirTurma";
            this.btnImprimirTurma.Size = new System.Drawing.Size(114, 23);
            this.btnImprimirTurma.TabIndex = 4;
            this.btnImprimirTurma.Text = "Imprimir Turma";
            this.btnImprimirTurma.UseVisualStyleBackColor = true;
            this.btnImprimirTurma.Click += new System.EventHandler(this.btnImprimirTurma_Click);
            // 
            // btnExcluirTurma
            // 
            this.btnExcluirTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirTurma.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTurma.Location = new System.Drawing.Point(252, 4);
            this.btnExcluirTurma.Name = "btnExcluirTurma";
            this.btnExcluirTurma.Size = new System.Drawing.Size(114, 23);
            this.btnExcluirTurma.TabIndex = 2;
            this.btnExcluirTurma.Text = "Excluir Turma";
            this.btnExcluirTurma.UseVisualStyleBackColor = true;
            this.btnExcluirTurma.Click += new System.EventHandler(this.btnExcluirTurma_Click);
            // 
            // cbProfessor
            // 
            this.cbProfessor.FormattingEnabled = true;
            this.cbProfessor.Location = new System.Drawing.Point(433, 73);
            this.cbProfessor.Name = "cbProfessor";
            this.cbProfessor.Size = new System.Drawing.Size(176, 21);
            this.cbProfessor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Máximo Alunos";
            // 
            // nMaximoAlunos
            // 
            this.nMaximoAlunos.Location = new System.Drawing.Point(433, 119);
            this.nMaximoAlunos.Name = "nMaximoAlunos";
            this.nMaximoAlunos.Size = new System.Drawing.Size(176, 20);
            this.nMaximoAlunos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(433, 163);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(176, 21);
            this.cbStatus.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Horário";
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(433, 211);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(176, 21);
            this.cbHorario.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Nova Turma";
            // 
            // tbDescricaoTurma
            // 
            this.tbDescricaoTurma.Location = new System.Drawing.Point(433, 30);
            this.tbDescricaoTurma.Name = "tbDescricaoTurma";
            this.tbDescricaoTurma.Size = new System.Drawing.Size(176, 20);
            this.tbDescricaoTurma.TabIndex = 45;
            this.tbDescricaoTurma.TextChanged += new System.EventHandler(this.tbDescricaoTurma_TextChanged);
            // 
            // tbVagas
            // 
            this.tbVagas.Cursor = System.Windows.Forms.Cursors.No;
            this.tbVagas.Location = new System.Drawing.Point(433, 259);
            this.tbVagas.Name = "tbVagas";
            this.tbVagas.ReadOnly = true;
            this.tbVagas.Size = new System.Drawing.Size(176, 20);
            this.tbVagas.TabIndex = 47;
            this.tbVagas.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Vagas";
            // 
            // FormTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 340);
            this.Controls.Add(this.tbVagas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDescricaoTurma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.nMaximoAlunos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProfessor);
            this.Controls.Add(this.dgvTurmas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Turmas";
            this.Load += new System.EventHandler(this.FormTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nMaximoAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurmas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluirTurma;
        private System.Windows.Forms.Button btnSalvarTurma;
        private System.Windows.Forms.Button btnNovaTurma;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnImprimirTurma;
        private System.Windows.Forms.ComboBox cbProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nMaximoAlunos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescricaoTurma;
        private System.Windows.Forms.TextBox tbVagas;
        private System.Windows.Forms.Label label7;
    }
}