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
    public partial class FormNovoUsuario : Form
    {
        public FormNovoUsuario()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limparCampos();
            tbNome.Focus();
        }

        private void FormNovoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome = tbNome.Text;
            usuario.username = tbUsername.Text;
            usuario.senha = tbSenha.Text;
            usuario.status = cbStatus.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(nNivel.Value, 0));
            Banco.novoUsuario(usuario);
            limparCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limparCampos()
        {
            tbNome.Clear();
            tbUsername.Clear();
            tbSenha.Clear();
            cbStatus.Text = "";
            nNivel.Value = 0;
        }
    }
}
