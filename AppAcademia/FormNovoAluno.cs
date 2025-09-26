using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAcademia
{
    public partial class FormNovoAluno : Form
    {
        public FormNovoAluno()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbStatusAluno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormNovoAluno_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("I", "Inativo");
            status.Add("C", "Cancelado");

            cbStatusAluno.DataSource = new BindingSource(status, null);
            cbStatusAluno.DisplayMember = "Value";
            cbStatusAluno.ValueMember = "Key";

            cbStatusAluno.SelectedIndex = -1;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbNomeAluno.Enabled = false;
            mtbTelefoneAluno.Enabled = false;
            cbStatusAluno.Enabled = false;

            tbNomeAluno.Clear();
            mtbTelefoneAluno.Clear();
            tbSelecionarTurma.Clear();

            cbStatusAluno.SelectedIndex = -1;
            tbNomeAluno.Focus();
            btnSalvarAluno.Enabled = false;
            btnNovoAluno.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            tbNomeAluno.Enabled = true;
            mtbTelefoneAluno.Enabled = true;
            cbStatusAluno.Enabled = true;

            tbNomeAluno.Clear();
            mtbTelefoneAluno.Clear();

            cbStatusAluno.SelectedIndex = -1;
            tbNomeAluno.Focus();
            btnSalvarAluno.Enabled = true;
            btnNovoAluno.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            string queryInsertAlubo = string.Format(@"
                                                    INSERT INTO tbAlunos
                                                    (T_NOMEALUNO, T_TELEFONE, T_STATUS, N_IDTURMA)
                                                    VALUES
                                                    ('{0}', '{1}', '{2}', {3})
                                                    ", tbNomeAluno.Text, mtbTelefoneAluno.Text, cbStatusAluno.SelectedValue, tbSelecionarTurma.Tag.ToString());
            Banco.dml(queryInsertAlubo);
            MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tbNomeAluno.Enabled = false;
            mtbTelefoneAluno.Enabled = false;
            cbStatusAluno.Enabled = false;

            tbNomeAluno.Clear();
            mtbTelefoneAluno.Clear();
            tbSelecionarTurma.Clear();

            cbStatusAluno.SelectedIndex = -1;
            tbNomeAluno.Focus();
            btnSalvarAluno.Enabled = false;
            btnNovoAluno.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnSelecionarTurma_Click(object sender, EventArgs e)
        {
            FormSelecionarTurma formSelecionarTurma = new FormSelecionarTurma(this);
            formSelecionarTurma.ShowDialog();
        }
    }
}
