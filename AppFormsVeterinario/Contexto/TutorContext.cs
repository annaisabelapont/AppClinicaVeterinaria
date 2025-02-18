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

        public void CadastrarTutor(Tutor tutor)
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

        public void EditarTutor(Tutor tutor)
        {

        }

        public void ExcluirTutor(Tutor tutor)
        {

        }

        public List<Tutor> ListarTutores()
        {
            return new List<Tutor>();
        }
    }
}
