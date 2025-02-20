using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AppFormsVeterinario.Models;

namespace AppFormsVeterinario.Contexto
{
    public class ConsultaVetContext
    {
        private MySqlConnection conexao = null;
        private string dados_conexao;

        public ConsultaVetContext()
        {
            dados_conexao = "server=localhost;port=3306;database=clinica_veterinaria;user=root;password=root;Persist Security Info=false;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }

        public void InserirConsulta(Consulta consulta)
        {
                string sql = "insert into consulta values (default, @tipo, @dataConsulta, @idVeterinarioFk, @IdAnimalFk)";
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@tipo", consulta.Tipo);
                comando.Parameters.AddWithValue("@dataConsulta", consulta.DataConsulta);
                comando.Parameters.AddWithValue("@idVeterinarioFk", consulta.IdVeterinarioFk);
                comando.Parameters.AddWithValue("@idAnimalFk", consulta.IdAnimalFk);

                comando.ExecuteNonQuery();

                MessageBox.Show("Consulta cadastrada com sucesso!");
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
        public void AtualizarConsulta(Consulta consulta)
        {
                string sql = "update consulta set tipo = @tipo, dataConsulta = @dataConsulta, idVeterinarioFk = @idVeterinarioFk, idAnimalFk = @idAnimalFk where id = @id";
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", consulta.Id);
                comando.Parameters.AddWithValue("@tipo", consulta.Tipo);
                comando.Parameters.AddWithValue("@dataConsulta", consulta.DataConsulta);
                comando.Parameters.AddWithValue("@idVeterinarioFk", consulta.IdVeterinarioFk);
                comando.Parameters.AddWithValue("@idAnimalFk", consulta.IdAnimalFk);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                    MessageBox.Show("Consulta atualizada com sucesso!");

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
        public void DeletarConsulta(Consulta consulta)
        {
                string sql = "delete from consulta where id = @id";
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", consulta.Id);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                    MessageBox.Show("Consulta deletada com sucesso!");

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
        public List<Consulta> ListarConsultas()
        {
            var ListaConsultas = new List<Consulta>();

                string sql = "select * from consulta";
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                MySqlDataReader dados = comando.ExecuteReader();

                while (dados.Read())
                {
                    Consulta consulta = new Consulta();
                    consulta.Id = Convert.ToInt32(dados["Id"]);
                    consulta.Tipo = dados["Tipo"].ToString();
                    consulta.DataConsulta = Convert.ToDateTime(dados["DataConsulta"]);
                    consulta.IdVeterinarioFk = Convert.ToInt32(dados["IdVeterinarioFk"]);
                    consulta.IdAnimalFk = Convert.ToInt32(dados["IdAnimalFk"]);

                    ListaConsultas.Add(consulta);
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

            return ListaConsultas;
        }
    }
}
