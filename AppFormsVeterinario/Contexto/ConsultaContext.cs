using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AppFormsVeterinario.Models;

namespace AppFormsVeterinario.Contexto
{
    public class ConsultaContext
    {
        private MySqlConnection conexao = null;
        private string dados_conexao;

        public ConsultaContext()
        {
            dados_conexao = "server=localhost;port=3306;database=aula_po2;user=root;password=34241610@Gi;Persist Security Info=false;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }

        public void CadastrarConsulta(Consulta consulta)
        {
            try
            {
                conexao.Open();

                string sql = "insert into consulta values (default, @tipo, @dataConsulta, @idVeterinarioFk, @IdAnimalFk)";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@tipo", consulta.Tipo);
                comando.Parameters.AddWithValue("@dataConsulta", consulta.DataConsulta);
                comando.Parameters.AddWithValue("@idVeterinarioFk", consulta.IdVeterinarioFk);
                comando.Parameters.AddWithValue("@idAnimalFk", consulta.IdAnimalFk);

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
        public void EditarConsulta()
        {

        }
        public void ExcluirConsulta()
        {

        }
        public List<Consulta> ListarConsultas()
        {
            return new List<Consulta>();
        }
    }
}
