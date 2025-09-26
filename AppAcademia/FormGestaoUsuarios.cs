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
    public partial class FormGestaoUsuarios : Form
    {
        public FormGestaoUsuarios()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormGestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = Banco.obterUsuariosIdNome();
            dgvUsuarios.Columns[0].Width = 90;
            dgvUsuarios.Columns[1].Width = 300;
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView) sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.obterDadosUsuario(vId);
                tbId.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                tbNome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO").ToString();
                tbUsername.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                tbSenha.Text = dt.Rows[0].Field<string>("T_SENHAUSUARIO").ToString();
                cbStatus.Text = dt.Rows[0].Field<string>("T_STATUSUSUARIO").ToString();
                nNivel.Text = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString();
            }
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            FormNovoUsuario formNovoUsuario = new FormNovoUsuario();
            formNovoUsuario.ShowDialog();
            dgvUsuarios.DataSource = Banco.obterUsuariosIdNome();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int linha = dgvUsuarios.SelectedRows[0].Index;
            Usuario usuario = new Usuario();
            usuario.id = Convert.ToInt32(tbId.Text);
            usuario.nome = tbNome.Text;
            usuario.username = tbUsername.Text;
            usuario.senha = tbSenha.Text;
            usuario.status = cbStatus.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(nNivel.Value, 0));
            Banco.atualizarDadosUsuario(usuario);
            dgvUsuarios[0, linha].Value = tbId.Text;
            dgvUsuarios[1, linha].Value = tbNome.Text;
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir o usuário?", "Excluir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Banco.deletarUsuario(tbId.Text);
                dgvUsuarios.Rows.Remove(dgvUsuarios.CurrentRow);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
