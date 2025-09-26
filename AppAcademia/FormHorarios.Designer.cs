namespace AppAcademia
{
    partial class FormHorarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdHorario = new System.Windows.Forms.TextBox();
            this.mtbHorario = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluirHorario = new System.Windows.Forms.Button();
            this.btnSalvarHorário = new System.Windows.Forms.Button();
            this.btnNovoHorario = new System.Windows.Forms.Button();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horário";
            // 
            // tbIdHorario
            // 
            this.tbIdHorario.Location = new System.Drawing.Point(12, 25);
            this.tbIdHorario.Name = "tbIdHorario";
            this.tbIdHorario.ReadOnly = true;
            this.tbIdHorario.Size = new System.Drawing.Size(57, 20);
            this.tbIdHorario.TabIndex = 1;
            this.tbIdHorario.TabStop = false;
            // 
            // mtbHorario
            // 
            this.mtbHorario.Location = new System.Drawing.Point(97, 25);
            this.mtbHorario.Mask = "99:99 - 99:99";
            this.mtbHorario.Name = "mtbHorario";
            this.mtbHorario.Size = new System.Drawing.Size(123, 20);
            this.mtbHorario.TabIndex = 3;
            this.mtbHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbHorario.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnExcluirHorario);
            this.panel1.Controls.Add(this.btnSalvarHorário);
            this.panel1.Controls.Add(this.btnNovoHorario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 30);
            this.panel1.TabIndex = 5;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(309, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(96, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluirHorario
            // 
            this.btnExcluirHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirHorario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirHorario.Location = new System.Drawing.Point(207, 3);
            this.btnExcluirHorario.Name = "btnExcluirHorario";
            this.btnExcluirHorario.Size = new System.Drawing.Size(96, 23);
            this.btnExcluirHorario.TabIndex = 2;
            this.btnExcluirHorario.Text = "Excluir Horário";
            this.btnExcluirHorario.UseVisualStyleBackColor = true;
            this.btnExcluirHorario.Click += new System.EventHandler(this.btnExcluirHorario_Click);
            // 
            // btnSalvarHorário
            // 
            this.btnSalvarHorário.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarHorário.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarHorário.Location = new System.Drawing.Point(105, 3);
            this.btnSalvarHorário.Name = "btnSalvarHorário";
            this.btnSalvarHorário.Size = new System.Drawing.Size(96, 23);
            this.btnSalvarHorário.TabIndex = 1;
            this.btnSalvarHorário.Text = "Salvar Horário";
            this.btnSalvarHorário.UseVisualStyleBackColor = true;
            this.btnSalvarHorário.Click += new System.EventHandler(this.btnSalvarHorário_Click);
            // 
            // btnNovoHorario
            // 
            this.btnNovoHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoHorario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoHorario.Location = new System.Drawing.Point(3, 3);
            this.btnNovoHorario.Name = "btnNovoHorario";
            this.btnNovoHorario.Size = new System.Drawing.Size(96, 23);
            this.btnNovoHorario.TabIndex = 0;
            this.btnNovoHorario.Text = "Novo Horário";
            this.btnNovoHorario.UseVisualStyleBackColor = true;
            this.btnNovoHorario.Click += new System.EventHandler(this.btnNovoHorario_Click);
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.AllowUserToResizeColumns = false;
            this.dgvHorarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.EnableHeadersVisualStyles = false;
            this.dgvHorarios.Location = new System.Drawing.Point(12, 51);
            this.dgvHorarios.MultiSelect = false;
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.RowHeadersVisible = false;
            this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarios.Size = new System.Drawing.Size(393, 399);
            this.dgvHorarios.TabIndex = 24;
            this.dgvHorarios.SelectionChanged += new System.EventHandler(this.dgvHorarios_SelectionChanged);
            // 
            // FormHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 486);
            this.Controls.Add(this.dgvHorarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mtbHorario);
            this.Controls.Add(this.tbIdHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHorarios";
            this.Load += new System.EventHandler(this.FormHorarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdHorario;
        private System.Windows.Forms.MaskedTextBox mtbHorario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluirHorario;
        private System.Windows.Forms.Button btnSalvarHorário;
        private System.Windows.Forms.Button btnNovoHorario;
        private System.Windows.Forms.DataGridView dgvHorarios;
    }
}