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

        public void InserAnimal(Animal animal)
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
        public void AtualizarAnimal(Animal animal)
        {
            try
            {
                conexao.Open();

                string sql = "update animal set nome = @nome, genero = @genero, especie = @especie, raca = @raca, idTutorFk = @idTutorFk where id = @id";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", animal.Nome);
                comando.Parameters.AddWithValue("@genero", animal.Genero);
                comando.Parameters.AddWithValue("@especie", animal.Especie);
                comando.Parameters.AddWithValue("@raca", animal.Raca);
                comando.Parameters.AddWithValue("@idTutorFk", animal.IdTutorFk);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                    MessageBox.Show("Animal atualizado com sucesso!");
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
        public void DeletarAnimal(Animal animal)
        {
            try
            {
                conexao.Open();

                string sql = "exclude from animal where id = @id";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", animal.Id);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                    MessageBox.Show("Animal deletado com sucesso!");
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
        public List<Animal> ListarAnimals()
        {
            var ListaAnimais = new List<Animal>();

            try
            {
                conexao.Open();

                string sql = "select * from animal";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                MySqlDataReader dados = comando.ExecuteReader();

                while (dados.Read())
                {
                    Animal animal = new Animal();
                    animal.Id = Convert.ToInt32(dados["Id"]);
                    animal.Nome = dados["Nome"].ToString();
                    animal.Genero = dados["Genero"].ToString();
                    animal.Especie = dados["Especie"].ToString();
                    animal.Raca = dados["Raca"].ToString();
                    animal.IdTutorFk = Convert.ToInt32(dados["IdTutorFk"]);

                    ListaAnimais.Add(animal);
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

            return ListaAnimais;
        }
    }
}
