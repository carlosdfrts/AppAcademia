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
    public partial class FormLogin : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public FormLogin(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string username = tbUsuario.Text;
            string senha = tbSenha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                tbUsuario.Focus();
                return;
            }
            string sql = "SELECT * FROM tbUsuarios WHERE T_USERNAME='" + username + "'AND T_SENHAUSUARIO ='" + senha + "'";
            dt = Banco.dql(sql);
            if (dt.Rows.Count == 1)
            {
                form1.lbAcesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lbUsuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                form1.pbLedLogado.Image = Properties.Resources.ledVerde;
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
                tbUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
