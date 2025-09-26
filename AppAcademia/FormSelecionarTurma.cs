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
    public partial class FormSelecionarTurma : Form
    {
        FormNovoAluno formNovoAluno;
        public FormSelecionarTurma(FormNovoAluno f)
        {
            InitializeComponent();
            formNovoAluno = f;
        }

        private void FormSelecionarTurma_Load(object sender, EventArgs e)
        {
            string queryTurma = String.Format(@"
                SELECT 
                    tbt.N_IDTURMA as 'ID',
                    tbt.T_DESCRICAOTURMA as 'Turma',
                    tbh.T_DESCRICAO as 'Horário',
                    tbp.T_NOMEPROFESSOR as 'Professor',
                    tbt.N_MAXIMOALUNOS as 'Max. Alunos',
                    (
                        SELECT 
                            COUNT(N_IDALUNO)
                        FROM
                            tbAlunos as tba
                        WHERE
                            tba.N_IDTURMA = tbt.N_IDTURMA and tba.T_STATUS = 'A'
                    ) as 'Qntd. Alunos'
                FROM
                    tbTurmas as tbt
                INNER JOIN
                    tbHorarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
                INNER JOIN
                    tbProfessores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR
            ");
            dgvTurmas.DataSource = Banco.dql(queryTurma);
        }

        private void dgvTurmas_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int maxAlunos = 0;
            int qntdAlunos = 0;
            maxAlunos = Convert.ToInt32(dgv.SelectedRows[0].Cells["Max. Alunos"].Value);
            qntdAlunos = Convert.ToInt32(dgv.SelectedRows[0].Cells["Qntd. Alunos"].Value);
            if (qntdAlunos >= maxAlunos)
            {
                MessageBox.Show("Número máximo de alunos atingido para esta turma.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                formNovoAluno.tbSelecionarTurma.Text = dgv.SelectedRows[0].Cells["Turma"].Value.ToString();
                formNovoAluno.tbSelecionarTurma.Tag = dgv.SelectedRows[0].Cells["ID"].Value.ToString();

                Close();
            }
            
        }
    }
}
