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
using System.Drawing.Printing;

namespace AppAcademia
{
    public partial class FormGestaoAluno : Form
    {

        string vqueryDGV = "";
        string turmaAtual = "";
        string idSelecionado = "";
        string turma = "";
        int linha = 0;
        private PrintDocument printDocument = new PrintDocument();
        private string nomeAlunoImprimir = "";
        private string telefoneAlunoImprimir = "";
        private string statusAlunoImprimir = "";
        private string turmaAlunoImprimir = "";
        private string fotoAlunoImprimir = "";

        public FormGestaoAluno()
        {
            InitializeComponent();
        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do aluno?", "Excluir Aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (File.Exists(pbFoto.ImageLocation))
                {
                    File.Delete(pbFoto.ImageLocation);
                }

                string vqueryExcluirAluno = string.Format(@"
                    DELETE FROM
                        tbAlunos
                    WHERE
                        N_IDALUNO = {0}
                ", idSelecionado);
                Banco.dml(vqueryExcluirAluno);
                dgvAlunos.Rows.Remove(dgvAlunos.CurrentRow);
            }
        }

        private void FormGestaoAluno_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"
                SELECT
                    N_IDALUNO as 'ID',
                    T_NOMEALUNO as 'Aluno'
                FROM
                    tbAlunos
            ";
            dgvAlunos.DataSource = Banco.dql(vqueryDGV);
            dgvAlunos.Columns[0].Width = 50;
            dgvAlunos.Columns[1].Width = 200;

            if (dgvAlunos.Rows.Count > 0)
            {
                dgvAlunos.Rows[0].Selected = true;
                tbNomeAluno.Text = dgvAlunos.Rows[0].Cells[1].Value.ToString();
                idSelecionado = dgvAlunos.Rows[0].Cells[0].Value.ToString();
            }       

            // popular combobox turmas
            string vqueryTurmas = @"
                SELECT 
                    N_IDTURMA,
                    ('Vagas: ' || (
                                    (N_MAXIMOALUNOS) - (
                                                         SELECT 
                                                             COUNT(N_IDALUNO)
                                                         FROM
                                                             tbAlunos as tba
                                                         WHERE
                                                             tba.T_STATUS = 'A' and tba.N_IDTURMA = N_IDTURMA
                                                        )
                                   ) || ' /  Turma:  ' || T_DESCRICAOTURMA) as 'Turma'
                FROM
                    tbTurmas
                ORDER BY
                    N_IDTURMA
            ";
            cbTurmas.Items.Clear();
            cbTurmas.DataSource = Banco.dql(vqueryTurmas);
            cbTurmas.DisplayMember = "Turma";
            cbTurmas.ValueMember = "N_IDTURMA";

            // popular combobox status (A = ativo, B = Bloqueado, C = cancelado)
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");
            cbStatus.DataSource = new BindingSource(status, null);
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";

            turma = cbTurmas.Text;
            turmaAtual = cbTurmas.Text;
            idSelecionado = dgvAlunos.Rows[0].Cells[0].Value.ToString();    
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            turma = cbTurmas.Text;
            if (turma != turmaAtual)
            {
                string[] t = turma.Split(' ');
                int vagas = int.Parse(t[1]);
                if (vagas < 1)
                {
                    MessageBox.Show("Não há vagas disponíveis para essa turma.");
                    cbTurmas.Focus();
                    return;
                }
                linha = dgvAlunos.SelectedRows[0].Index;
                string queryAtualizarAluno = string.Format(@"
                    UPDATE
                        tbAlunos
                    SET
                        T_NOMEALUNO = '{0}',
                        T_TELEFONE = '{1}',
                        T_STATUS = '{2}',
                        N_IDTURMA = {3},
                    WHERE
                        N_IDALUNO = {4}
                ", tbNomeAluno.Text, mtbTelefone.Text, cbStatus.SelectedValue, cbTurmas.SelectedValue, idSelecionado);
                Banco.dml(queryAtualizarAluno);
                dgvAlunos[1, linha].Value = tbNomeAluno.Text;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvAlunos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                tbNomeAluno.Text = dgvAlunos.Rows[dgvAlunos.SelectedRows[0].Index].Cells[1].Value.ToString();
                idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = string.Format(@"
                    SELECT
                        N_IDALUNO,
                        T_NOMEALUNO,
                        T_TELEFONE,
                        T_STATUS,
                        N_IDTURMA,
                        T_FOTO
                    FROM
                        tbAlunos
                    WHERE
                        N_IDALUNO = {0}
                ", idSelecionado);
                DataTable dt = Banco.dql(vqueryCampos);
                tbNomeAluno.Text = dt.Rows[0].Field<string>("T_NOMEALUNO");
                mtbTelefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                cbStatus.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cbTurmas.SelectedValue = dt.Rows[0].Field<Int64>("N_IDTURMA");
                turmaAtual = cbTurmas.Text;
                pbFoto.ImageLocation = dt.Rows[0].Field<string>("T_FOTO");
            }
        }

        private void pbFoto_DoubleClick(object sender, EventArgs e)
        {
            // Obtenha os dados do aluno selecionado
            DataTable dt = Banco.dql($@"
                SELECT N_IDALUNO, T_NOMEALUNO, T_TELEFONE, T_STATUS, N_IDTURMA, T_FOTO
                FROM tbAlunos
                WHERE N_IDALUNO = {idSelecionado}
            ");
            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                FormNovoAluno formNovoAluno = new FormNovoAluno(
                    row["N_IDALUNO"].ToString(),
                    row["T_NOMEALUNO"].ToString(),
                    row["T_TELEFONE"].ToString(),
                    row["T_STATUS"].ToString(),
                    row["N_IDTURMA"].ToString(),
                    row["T_FOTO"].ToString()
                );
                formNovoAluno.ShowDialog();
                // Após editar, atualize a grid
                dgvAlunos.DataSource = Banco.dql(vqueryDGV);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Captura os dados do aluno selecionado
            nomeAlunoImprimir = tbNomeAluno.Text;
            telefoneAlunoImprimir = mtbTelefone.Text;
            statusAlunoImprimir = cbStatus.Text;
            turmaAlunoImprimir = cbTurmas.Text;
            fotoAlunoImprimir = pbFoto.ImageLocation;

            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
            printDocument.PrintPage -= PrintDocument_PrintPage;
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 50, y = 50;
            Font fontTitulo = new Font("Arial", 16, FontStyle.Bold);
            Font fontDados = new Font("Arial", 12);

            // Título
            e.Graphics.DrawString("Ficha do Aluno", fontTitulo, Brushes.Black, x, y);
            y += 40;

            // Foto
            if (!string.IsNullOrEmpty(fotoAlunoImprimir) && File.Exists(fotoAlunoImprimir))
            {
                Image foto = Image.FromFile(fotoAlunoImprimir);
                e.Graphics.DrawImage(foto, x, y, 120, 120);
                foto.Dispose();
            }
            y += 130;

            // Dados
            e.Graphics.DrawString($"Nome: {nomeAlunoImprimir}", fontDados, Brushes.Black, x, y); y += 30;
            e.Graphics.DrawString($"Telefone: {telefoneAlunoImprimir}", fontDados, Brushes.Black, x, y); y += 30;
            e.Graphics.DrawString($"Status: {statusAlunoImprimir}", fontDados, Brushes.Black, x, y); y += 30;
            e.Graphics.DrawString($"Turma: {turmaAlunoImprimir}", fontDados, Brushes.Black, x, y); y += 30;
        }
    }
}
