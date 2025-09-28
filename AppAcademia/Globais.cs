using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAcademia
{
    internal class Globais
    {
        public static string versao = "1.0";
        public static bool logado = false;
        public static int nivel = 0; // 0 = visitante, 1 = usuário/aluno, 2 = gerente, 3 = administrador
        // public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "bancoAcademia.db";
        public static string caminhoFotos = caminho + @"\fotos\";
        public static string caminhoBanco = Path.Combine(caminho, nomeBanco);

        // Informações do banco de dados
        /*
        tbUsuarios
        N_IDUSUARIO: Int64
        T_NOMEUSUARIO: string
        T_USERNAME: string
        T_SENHAUSUARIO: string
        T_STATUSUSUARIO: string
        N_NIVELUSUARIO: Int64
        */

        /*
        select 
            tbt.N_IDTURMA as 'ID Turma',
            tbt.T_DESCRICAOTURMA as 'Descrição Turma',
            tbt.N_MAXIMOALUNOS as 'Maximo Alunos',
            tbh.T_DESCRICAO as 'Horário',
            tbp.T_NOMEPROFESSOR as 'Professor',
        CASE
            WHEN tbt.T_STATUS = 'A' THEN 'Ativa'
            WHEN tbt.T_STATUS = 'P' THEN 'Paralisada'
            WHEN tbt.T_STATUS = 'C' THEN 'Cancelada'
        END as 'Status'
    
        from tbTurmas as tbt

        inner join 
            tbHorarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO,
            tbProfessores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR 
        */
    }
}
