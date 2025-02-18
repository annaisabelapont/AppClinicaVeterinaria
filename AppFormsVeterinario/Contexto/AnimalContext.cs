using AppFormsVeterinario.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormsVeterinario.Contexto
{
    class AnimalContext
    {
        private MySqlConnection conexao = null;
        private string dados_conexao;

        public AnimalContext()
        {
            dados_conexao = "server=localhost;port=3306;database=aula_po2;user=root;password=34241610@Gi;Persist Security Info=false;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }

        public void CadastrarAnimal(Animal animal)
        {
            try
            {
                conexao.Open();

                string sql = "insert into animal values (default, @nome, @genero, @especie, @raca, @idTutorFk)";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", animal.Nome);
                comando.Parameters.AddWithValue("@genero", animal.Genero);
                comando.Parameters.AddWithValue("@especie", animal.Especie);
                comando.Parameters.AddWithValue("@raca", animal.Raca);
                comando.Parameters.AddWithValue("@idTutorFk", animal.IdTutorFk);

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
    }
}
