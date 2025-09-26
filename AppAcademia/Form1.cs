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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormLogin formLogin = new FormLogin(this);
            formLogin.ShowDialog();
        }

        private void abreForm (int nivel, Form form)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Você não tem permissão.");
                }
            }
            else
            {
                MessageBox.Show("Você precisa estar logado para acessar.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbAcesso.Text = "0";
            lbUsuario.Text = "-";
            pbLedLogado.Image = Properties.Resources.ledVermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(this);
            formLogin.ShowDialog();
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
          FormNovoUsuario formNovoUsuario = new FormNovoUsuario();
          abreForm(2, formNovoUsuario);
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                
            }
            else
            {
                MessageBox.Show("Você precisa estar logado para acessar.");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestaoUsuarios formGestaoUsuarios = new FormGestaoUsuarios();
            abreForm(2, formGestaoUsuarios);
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHorarios formHorarios = new FormHorarios();
            abreForm(3, formHorarios);
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfessores formProfessores = new FormProfessores();
            abreForm(2, formProfessores);
        }

        private void gestãoDeTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTurmas formGestaoTurmas = new FormTurmas();
            abreForm(2, formGestaoTurmas);
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoAluno formNovoAluno = new FormNovoAluno();
            abreForm(1, formNovoAluno);
        }
    }
}
