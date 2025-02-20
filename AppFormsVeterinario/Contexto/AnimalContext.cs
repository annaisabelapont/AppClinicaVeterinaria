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
            dados_conexao = "server=localhost;port=3306;database=clinica_veterinaria;user=root;password=root;Persist Security Info=false;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }

        public void InserirAnimal(Animal animal)
        {
                string sql = "insert into animal values (default, @nome, @genero, @especie, @raca, @idTutorFk)";
            try
            {
                conexao.Open();

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
                string sql = "update animal set nome = @nome, genero = @genero, especie = @especie, raca = @raca where id = @id";
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", animal.Id);
                comando.Parameters.AddWithValue("@nome", animal.Nome);
                comando.Parameters.AddWithValue("@genero", animal.Genero);
                comando.Parameters.AddWithValue("@especie", animal.Especie);
                comando.Parameters.AddWithValue("@raca", animal.Raca);

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
                string sql = "delete from animal where id = @id";
            try
            {
                conexao.Open();

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
        public List<Animal> ListarAnimais()
        {
            var ListaAnimais = new List<Animal>();

                string sql = "select * from animal";
            try
            {
                conexao.Open();

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
