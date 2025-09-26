using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.LinkLabel;

namespace AppAcademia
{
    public partial class FormTurmas : Form
    {
        string idSelecionado;
        int modo = 1; // 1 = Update, 2 = Insert
        string vQueryDGV = @"
        SELECT 
            tbt.N_IDTURMA as 'ID', 
            tbt.T_DESCRICAOTURMA as 'Turma', 
            tbh.T_DESCRICAO as 'Horário' 
        FROM 
            tbTurmas as tbt 
        INNER JOIN 
            tbHorarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
    ";

        public FormTurmas()
        {
            InitializeComponent();
        }

        private void FormTurmas_Load(object sender, EventArgs e)
        {
            
            dgvTurmas.DataSource = Banco.dql(vQueryDGV);
            dgvTurmas.Columns[0].Width = 60;
            dgvTurmas.Columns[1].Width = 250;
            dgvTurmas.Columns[2].Width = 90;

            // Popular ComboBox de Professores
            string vQueryComboProfessores = @"
                                             SELECT 
                                                N_IDPROFESSOR as 'ID', 
                                                T_NOMEPROFESSOR as 'Professor' 
                                             FROM 
                                                tbProfessores
                                             ORDER BY
                                                N_IDPROFESSOR
                                            ";
            cbProfessor.Items.Clear();
            cbProfessor.DataSource = Banco.dql(vQueryComboProfessores);
            cbProfessor.DisplayMember = "Professor";
            cbProfessor.ValueMember = "ID";

            // Popular ComboBox de Status (Ativa = A, Paralisada = P, Cancelada = C)
            Dictionary<string, string> status = new Dictionary<string, string>
            {
                { "A", "Ativa" },
                { "P", "Paralisada" },
                { "C", "Cancelada" }
            };

            cbStatus.Items.Clear();
            cbStatus.DataSource = new BindingSource(status, null);
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";

            // Popular ComboBox de Horários
            string vQueryComboHorarios = @"
                                          SELECT 
                                            N_IDHORARIO as 'ID', 
                                            T_DESCRICAO as 'Horário' 
                                          FROM 
                                            tbHorarios
                                          ORDER BY
                                            N_IDHORARIO
                                          ";
            cbHorario.Items.Clear();
            cbHorario.DataSource = Banco.dql(vQueryComboHorarios);
            cbHorario.DisplayMember = "Horário";
            cbHorario.ValueMember = "ID";
        }

        private void dgvTurmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                modo = 1; // Modo Update          
                idSelecionado = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vQueryCampos = @"
                                       SELECT
                                            T_DESCRICAOTURMA,
                                            N_IDPROFESSOR,
                                            N_IDHORARIO,
                                            N_MAXIMOALUNOS,
                                            T_STATUS
                                        FROM 
                                            tbTurmas
                                        WHERE
                                            N_IDTURMA = " + idSelecionado;
                DataTable dtCampos = Banco.dql(vQueryCampos);
                tbDescricaoTurma.Text = dtCampos.Rows[0].Field<String>("T_DESCRICAOTURMA");
                cbProfessor.SelectedValue = dtCampos.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                nMaximoAlunos.Value = dtCampos.Rows[0].Field<Int64>("N_MAXIMOALUNOS");
                cbStatus.SelectedValue = dtCampos.Rows[0].Field<string>("T_STATUS");
                cbHorario.SelectedValue = dtCampos.Rows[0].Field<Int64>("N_IDHORARIO");

                // Chamada para calcular o número de vagas disponíveis
                tbVagas.Text = calcularVagas();
            }
        }

        private string calcularVagas()
        {
            // Calcular o número de alunos já matriculados na turma
            string vQueryVagas = String.Format(@"
                SELECT
                    COUNT(N_IDALUNO) as contVagas
                FROM
                    tbAlunos
                WHERE
                    T_STATUS = 'A' AND N_IDTURMA = {0}", idSelecionado);

            DataTable dtCampos = Banco.dql(vQueryVagas);
            int vagas = Int32.Parse(Math.Round(nMaximoAlunos.Value, 0).ToString());
            int alunosMatriculados = 0;

            if (dtCampos.Rows.Count > 0 && dtCampos.Rows[0]["contVagas"] != DBNull.Value)
            {
                alunosMatriculados = Convert.ToInt32(dtCampos.Rows[0]["contVagas"]);
            }

            vagas -= alunosMatriculados;
            return vagas.ToString();
        }

        private void btnNovaTurma_Click(object sender, EventArgs e)
        {
            tbDescricaoTurma.Clear();
            cbProfessor.SelectedIndex = -1;
            cbHorario.SelectedIndex = -1;
            nMaximoAlunos.Value = 0;
            cbStatus.SelectedIndex = -1;
            tbDescricaoTurma.Focus();
            modo = 2; // Modo Insert
        }

        private void btnSalvarTurma_Click(object sender, EventArgs e)
        {
            string vQueryTurma = ""; 
            if (modo != 0)
            {
                if (modo == 1) // modo == 1 (Update)
                {
                    vQueryTurma = String.Format(@"
                                                                    UPDATE 
                                                                        tbTurmas
                                                                    SET 
                                                                        T_DESCRICAOTURMA = '{0}',
                                                                        N_IDPROFESSOR = {1},
                                                                        N_IDHORARIO = {2},
                                                                        N_MAXIMOALUNOS = {3},
                                                                        T_STATUS = '{4}'
                                                                    WHERE 
                                                                        N_IDTURMA = {5}
                                                                ",
                                                                    tbDescricaoTurma.Text,
                                                                    cbProfessor.SelectedValue,
                                                                    cbHorario.SelectedValue,
                                                                    Int32.Parse(Math.Round(nMaximoAlunos.Value, 0).ToString()),
                                                                    cbStatus.SelectedValue,
                                                                    idSelecionado
                                                                   );
                    MessageBox.Show("Turma atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // modo == 2 (Insert)
                {
                    vQueryTurma = String.Format(@"
                                                                    INSERT INTO 
                                                                        tbTurmas (T_DESCRICAOTURMA, N_IDPROFESSOR, N_IDHORARIO, N_MAXIMOALUNOS, T_STATUS)
                                                                    VALUES 
                                                                        ('{0}', {1}, {2}, {3}, '{4}')
                                                                ",
                                                                    tbDescricaoTurma.Text,
                                                                    cbProfessor.SelectedValue,
                                                                    cbHorario.SelectedValue,
                                                                    Int32.Parse(Math.Round(nMaximoAlunos.Value, 0).ToString()),
                                                                    cbStatus.SelectedValue
                                                                   );

                }
                int linha = dgvTurmas.SelectedRows[0].Index;
                Banco.dml(vQueryTurma);

                // Recarrega o DataGridView com os dados atualizados
                string vQueryDGV = @"
                                    SELECT 
                                        tbt.N_IDTURMA as 'ID', 
                                        tbt.T_DESCRICAOTURMA as 'Turma', 
                                        tbh.T_DESCRICAO as 'Horário' 
                                    FROM 
                                        tbTurmas as tbt 
                                    INNER JOIN 
                                        tbHorarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
                                    ";
                dgvTurmas.DataSource = Banco.dql(vQueryDGV);
            }
        }

        private void btnExcluirTurma_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente excluir esta turma?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                string vQueryExcluirTurma = String.Format("DELETE FROM tbTurmas WHERE N_IDTURMA = {0}", idSelecionado);
                Banco.dml(vQueryExcluirTurma);
                MessageBox.Show("Turma excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTurmas.Rows.RemoveAt(dgvTurmas.SelectedRows[0].Index);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbDescricaoTurma_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnImprimirTurma_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turmas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logo.png");
            logo.ScaleToFit(140f, 120f);
            logo.Alignment = Element.ALIGN_LEFT;
            // logo.SetAbsolutePosition(100f, 700f); // x e -y

            string dados = "";
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Relatório de Turmas\n\n");

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("Aplicativo de Academia em C# .NET");

            PdfPTable tabela = new PdfPTable(3); // 3 colunas
            tabela.DefaultCell.FixedHeight = 20f;

            PdfPCell celula1 = new PdfPCell();
            celula1.Colspan = 3; // Mesclar 3 colunas
            tabela.AddCell(celula1);

            tabela.AddCell("ID Turma");
            tabela.AddCell("Turmas");
            tabela.AddCell("Horário");

            DataTable dtTurmas = Banco.dql(vQueryDGV);
            for (int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("ID").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<String>("Turma"));
                tabela.AddCell(dtTurmas.Rows[i].Field<String>("Horário"));
            }

            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();

            DialogResult resultado = MessageBox.Show("Deseja abrir o arquivo PDF?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
            }
        }
    }
}
