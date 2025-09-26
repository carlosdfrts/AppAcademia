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
    public partial class FormHorarios : Form
    {
        public FormHorarios()
        {
            InitializeComponent();
        }

        private void FormHorarios_Load(object sender, EventArgs e)
        {
            string vQuery = "SELECT N_IDHORARIO AS 'ID', T_DESCRICAO AS 'Horário' FROM tbHorarios ORDER BY T_DESCRICAO";
            dgvHorarios.DataSource = Banco.dql(vQuery);
            dgvHorarios.Columns[0].Width = 60;
            dgvHorarios.Columns[1].Width = 300;
        }

        private void dgvHorarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vQuery = "SELECT * FROM tbHorarios WHERE N_IDHORARIO = " + vId;
                dt = Banco.dql(vQuery);
                tbIdHorario.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                mtbHorario.Text = dt.Rows[0].Field<string>("T_DESCRICAO");
            }
        }

        private void btnNovoHorario_Click(object sender, EventArgs e)
        {
            tbIdHorario.Clear();
            mtbHorario.Clear();
            mtbHorario.Focus();
        }

        private void btnSalvarHorário_Click(object sender, EventArgs e)
        {
            string vQuery = "";
            if (tbIdHorario.Text == "")
            {
                // Insert se é um novo horário
                vQuery = "INSERT INTO tbHorarios (T_DESCRICAO) VALUES ('" + mtbHorario.Text + "')";
            }
            else
            {
                // Update se é um horário existente
                vQuery = "UPDATE tbHorarios SET T_DESCRICAO = '" + mtbHorario.Text + "' WHERE N_IDHORARIO = " + tbIdHorario.Text;
            }
            Banco.dml(vQuery);
            vQuery = "SELECT N_IDHORARIO AS 'ID', T_DESCRICAO AS 'Horário' FROM tbHorarios ORDER BY T_DESCRICAO";
            dgvHorarios.DataSource = Banco.dql(vQuery);
        }

        private void btnExcluirHorario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir o horário selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string vQuery = "DELETE FROM tbHorarios WHERE N_IDHORARIO = " + tbIdHorario.Text;
                Banco.dml(vQuery);
                dgvHorarios.Rows.Remove(dgvHorarios.CurrentRow);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
