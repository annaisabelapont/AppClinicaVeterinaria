using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AppFormsVeterinario.Models;

namespace AppFormsVeterinario.Contexto
{
    public class VeterinarioContext
    {
        private MySqlConnection conexao = null;
        private string dados_conexao;

        public VeterinarioContext()
        {
            dados_conexao = "server=localhost;port=3306;database=aula_po2;user=root;password=34241610@Gi;Persist Security Info=false;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }

        public void InserirVeterinario(Veterinario veterinario)
        {

            string sql = "INSERT INTO VETERINARIO (Nome, Cpf, CRMV, Especializacao) VALUES (@Nome, @Cpf, @CRMV, @Especializacao)";
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@Nome", veterinario.Nome);
                comando.Parameters.AddWithValue("@Cpf", veterinario.Cpf);
                comando.Parameters.AddWithValue("@CRMV", veterinario.CRMV);
                comando.Parameters.AddWithValue("@Especializacao", veterinario.Especializacao);

                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir veterinário: " + ex.Message);
            }

            finally
            {
                conexao.Close();
            }
        }
        public void AtualizarVeterinario(Veterinario veterinario)
        {
            string sql = "UPDATE VETERINARIO SET Nome = @Nome, Cpf = @Cpf, CRMV = @CRMV, Especializacao = @Especializacao WHERE Id = @Id";

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@Nome", veterinario.Nome);
                comando.Parameters.AddWithValue("@Cpf", veterinario.Cpf);
                comando.Parameters.AddWithValue("@CRMV", veterinario.CRMV);
                comando.Parameters.AddWithValue("@Especializacao", veterinario.Especializacao);
                comando.Parameters.AddWithValue("@Id", veterinario.Id);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                    MessageBox.Show("Veterinário atualizada com sucesso!");
                else
                    MessageBox.Show("Nenhum registro foi atualizado. Verifique o ID informado.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar veterinário: " + ex.Message);
            }

            finally
            {
                conexao.Close();
            }
        }
        public void DeletarVeterinario(Veterinario veterinario)
        {
            string sql = "DELETE FROM VETERINARIO WHERE Id = @Id";

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@Nome", veterinario.Nome);
                comando.Parameters.AddWithValue("@Cpf", veterinario.Cpf);
                comando.Parameters.AddWithValue("@CRMV", veterinario.CRMV);
                comando.Parameters.AddWithValue("@Especializacao", veterinario.Especializacao);
                comando.Parameters.AddWithValue("@Id", veterinario.Id);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                    MessageBox.Show("Veterinário deletada com sucesso!");
                else
                    MessageBox.Show("Nenhum registro foi deletado. Verifique o ID informado.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar pessoa: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public List<Veterinario> ListarVeterinarios()
        {
            List<Veterinario> ListaVeterinarios = new List<Veterinario>();

            try
            {
                conexao.Open();

                string sql = "SELECT * FROM VETERINARIO";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                MySqlDataReader dados = comando.ExecuteReader();

                while (dados.Read())
                {
                    Veterinario veterinario = new Veterinario();
                    veterinario.Id = Convert.ToInt32(dados["Id"]);
                    veterinario.Nome = dados["Nome"].ToString();
                    veterinario.Cpf = dados["Cpf"].ToString();
                    veterinario.CRMV = dados["CRMV"].ToString();
                    veterinario.Especializacao = dados["Especializacao"].ToString();
                    ListaVeterinarios.Add(veterinario);
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

            return ListaVeterinarios;
        }
    }
}
