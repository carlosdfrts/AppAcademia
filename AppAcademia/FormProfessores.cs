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
    public partial class FormProfessores : Form
    {
        public FormProfessores()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormProfessores_Load(object sender, EventArgs e)
        {
            string vQuery = "SELECT N_IDPROFESSOR AS 'ID', T_NOMEPROFESSOR AS 'Professor', T_TELEFONE AS 'Telefone' FROM tbProfessores ORDER BY T_NOMEPROFESSOR";
            dgvProfessores.DataSource = Banco.dql(vQuery);
            dgvProfessores.Columns[0].Width = 60;
            dgvProfessores.Columns[1].Width = 200;
            dgvProfessores.Columns[2].Width = 130;
        }

        private void dgvProfessores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vQuery = "SELECT * FROM tbProfessores WHERE N_IDPROFESSOR = " + vId;
                dt = Banco.dql(vQuery);
                tbIdProfessor.Text = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                tbNomeProfessor.Text = dt.Rows[0].Field<string>("T_NOMEPROFESSOR");
                mtbTelefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
            }
        }

        private void btnNovoProfessor_Click(object sender, EventArgs e)
        {
            tbIdProfessor.Clear();
            tbNomeProfessor.Clear();
            mtbTelefone.Clear();
            tbNomeProfessor.Focus();
        }

        private void btnSalvarProfessor_Click(object sender, EventArgs e)
        {
            string vQuery = "";
            if (string.IsNullOrEmpty(tbIdProfessor.Text))
            {
                // Insert if it's a new professor
                vQuery = "INSERT INTO tbProfessores (T_NOMEPROFESSOR, T_TELEFONE) VALUES ('" + tbNomeProfessor.Text + "', '" + mtbTelefone.Text + "')";
            }
            else
            {
                // Update if it's an existing professor
                vQuery = "UPDATE tbProfessores SET T_NOMEPROFESSOR = '" + tbNomeProfessor.Text + "', T_TELEFONE = '" + mtbTelefone.Text + "' WHERE N_IDPROFESSOR = " + tbIdProfessor.Text;
            }
            Banco.dml(vQuery);
            vQuery = "SELECT N_IDPROFESSOR AS 'ID', T_NOMEPROFESSOR AS 'Professor', T_TELEFONE AS 'Telefone' FROM tbProfessores ORDER BY T_NOMEPROFESSOR";
            dgvProfessores.DataSource = Banco.dql(vQuery);
        }

        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir o professor selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string vQuery = "DELETE FROM tbProfessores WHERE N_IDPROFESSOR = " + tbIdProfessor.Text;
                Banco.dml(vQuery);
                dgvProfessores.Rows.Remove(dgvProfessores.CurrentRow);
            }

        }
    }
}
