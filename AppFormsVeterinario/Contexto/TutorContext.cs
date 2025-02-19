using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using AppFormsVeterinario.Models;

namespace AppFormsVeterinario.Contexto
{
    public class TutorContext
    {
        private MySqlConnection conexao;
        private string dados_conexao;

        public TutorContext()
        {
            dados_conexao = "server=localhost;port=3306;database=aula_po2;user=root;password=34241610@Gi;Persist Security Info=false;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }

        public void InserirTutor(Tutor tutor)
        {
            try
            {
                conexao.Open();

                string sql = "insert into tutor values (default, @nome, @telefone, @cpf, @cep)";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", tutor.Nome);
                comando.Parameters.AddWithValue("@telefone", tutor.Telefone);
                comando.Parameters.AddWithValue("@cpf", tutor.Cpf);
                comando.Parameters.AddWithValue("@cep", tutor.Cep);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void AtualizarTutor(Tutor tutor)
        {
            try
            {
                conexao.Open();

                string sql = "update tutor set nome = @nome, telefone = @telefone, cpf = @cpf, cep = @cep where id = @id";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", tutor.Nome);
                comando.Parameters.AddWithValue("@telefone", tutor.Telefone);
                comando.Parameters.AddWithValue("@cpf", tutor.Cpf);
                comando.Parameters.AddWithValue("@cep", tutor.Cep);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                    MessageBox.Show("Tutor atualizado com sucesso!");
                else
                    MessageBox.Show("Nenhum registro foi atualizado. Verifique o ID informado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void DeletarTutor(Tutor tutor)
        {
            try
            {
                conexao.Open();

                string sql = "exclude from tutor where id = @id";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", tutor.Id);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                    MessageBox.Show("Tutor deletado com sucesso!");
                else
                    MessageBox.Show("Nenhum registro foi deletado. Verifique o ID informado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public List<Tutor> ListarTutores()
        {
            var ListaTutores = new List<Tutor>();

            try
            {
                conexao.Open();

                string sql = "select * from tutor";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                MySqlDataReader dados = comando.ExecuteReader();

                while (dados.Read())
                {
                    Tutor tutor = new Tutor();
                    tutor.Id = Convert.ToInt32(dados["Id"]);
                    tutor.Nome = dados["Nome"].ToString();
                    tutor.Telefone = dados["Telefone"].ToString();
                    tutor.Cpf = dados["Cpf"].ToString();
                    tutor.Cep = dados["Cep"].ToString();

                    ListaTutores.Add(tutor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return ListaTutores;
        }
    }
}
