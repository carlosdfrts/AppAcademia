using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppAcademia
{
    public partial class FormNovoAluno : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = "";
        string destinoCompleto = Globais.caminhoFotos;
        private string idAlunoEditando = null;

        public FormNovoAluno()
        {
            InitializeComponent();
        }
        public FormNovoAluno(string idAluno, string nome, string telefone, string status, string turma, string foto)
        {
            InitializeComponent();
            tbNomeAluno.Text = nome;
            mtbTelefoneAluno.Text = telefone;
            cbStatusAluno.SelectedValue = status;
            tbSelecionarTurma.Tag = turma;
            pbFoto.ImageLocation = foto;
            destinoCompleto = foto;
            origemCompleto = foto;
            idAlunoEditando = idAluno;
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

        private void btnAdicionarFoto_Click(object sender, EventArgs e)
        {
            string fotoAntiga = destinoCompleto;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino = Path.Combine(Globais.caminhoFotos, foto);
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Já existe uma foto com este nome. Deseja substituir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            if (!Directory.Exists(Path.GetDirectoryName(destinoCompleto)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(destinoCompleto));
            }
            System.IO.File.Copy(origemCompleto, destinoCompleto, true);
            pbFoto.ImageLocation = destinoCompleto;

            // Exclui a foto antiga se for diferente da nova
            if (!string.IsNullOrEmpty(fotoAntiga) && fotoAntiga != destinoCompleto && File.Exists(fotoAntiga))
            {
                File.Delete(fotoAntiga);
            }
        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            if (idAlunoEditando != null)
            {
                string queryUpdateAluno = string.Format(@"
                    UPDATE tbAlunos
                    SET T_NOMEALUNO = '{0}', T_TELEFONE = '{1}', T_STATUS = '{2}', N_IDTURMA = {3}, T_FOTO = '{4}'
                    WHERE N_IDALUNO = {5}
                ", tbNomeAluno.Text, mtbTelefoneAluno.Text, cbStatusAluno.SelectedValue, tbSelecionarTurma.Tag.ToString(), destinoCompleto, idAlunoEditando);
                Banco.dml(queryUpdateAluno);
                MessageBox.Show("Cadastro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cadastro novo
                string queryInsertAluno = string.Format(@"
                    INSERT INTO tbAlunos
                    (T_NOMEALUNO, T_TELEFONE, T_STATUS, N_IDTURMA, T_FOTO)
                    VALUES
                    ('{0}', '{1}', '{2}', {3}, '{4}')
                ", tbNomeAluno.Text, mtbTelefoneAluno.Text, cbStatusAluno.SelectedValue, tbSelecionarTurma.Tag.ToString(), destinoCompleto);
                Banco.dml(queryInsertAluno);
                MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            pbFoto.ImageLocation = null;
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
