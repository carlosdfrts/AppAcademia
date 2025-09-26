using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AppAcademia
{
    internal class Banco
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection conexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = " + Globais.caminhoBanco);
            conexao.Open();
            return conexao;
        }

        //Funções Genéricas

        public static DataTable dql(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var vcon = conexaoBanco()) // cria a conexão
                {
                    using (var cmd = new SQLiteCommand(sql, vcon))
                    {
                        using (var da = new SQLiteDataAdapter(cmd))
                        {
                            da.Fill(dt); // preenche o DataTable
                        }
                    }
                }

                return dt;
            }
            catch (Exception)
            {
                // só throw mantém a stack trace original
                throw;
            }
        }


        public static void dml(string q, string msgOK = null, string msgErro = null) // Data Manipulation Language (insert, update, delete)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if (msgErro != null)
                {
                    MessageBox.Show(msgErro + ": " + ex.Message);
                }
                throw ex;
            }
        }

        public static DataTable obterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tbUsuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                da.Fill(dt);
                vcon.Close();
                return dt;       
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Funções do FORM formGestaoUsuarios

        public static DataTable obterUsuariosIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_IDUSUARIO as 'ID Usuário', T_NOMEUSUARIO as 'Nome Usuário' FROM tbUsuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void atualizarDadosUsuario(Usuario usuario)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tbUsuarios SET T_NOMEUSUARIO = '"+usuario.nome+"', T_USERNAME = '"+usuario.username+"', T_SENHAUSUARIO = '"+usuario.senha+"', T_STATUSUSUARIO = '"+usuario.status+"', N_NIVELUSUARIO = '"+usuario.nivel+"' WHERE N_IDUSUARIO ="+ usuario.id;
                da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void deletarUsuario(string  id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tbUsuarios WHERE N_IDUSUARIO = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obterDadosUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tbUsuarios WHERE N_IDUSUARIO=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText,  conexaoBanco());
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Funções do FORM FormNovoUsuario
        // Cadastra um novo usuário no banco de dados
        public static void novoUsuario(Usuario usuario)
        {
            if (usuarioExistente(usuario))
            {
                MessageBox.Show("Usuário já cadastrado.");
                return;
            }
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tbUsuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, N_NIVELUSUARIO, T_STATUSUSUARIO) VALUES (@nome, @username, @senha, @nivel, @status)";
                cmd.Parameters.AddWithValue("@nome", usuario.nome);
                cmd.Parameters.AddWithValue("@username", usuario.username);
                cmd.Parameters.AddWithValue("@senha", usuario.senha);
                cmd.Parameters.AddWithValue("@nivel", usuario.nivel);
                cmd.Parameters.AddWithValue("@status", usuario.status);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso!");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
            }
        }

        // Verifica se o usuário já existe no banco de dados
        public static bool usuarioExistente(Usuario usuario)
        {
            bool resultado;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = conexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tbUSUARIOS WHERE T_USERNAME = '"+ usuario.username +"'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            resultado = dt.Rows.Count > 0 ? true : false;
            vcon.Close();
            return resultado;
        }

    }
}
