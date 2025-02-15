using AppFormsVeterinario.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;//acesso ao messagebox
using MySql.Data.MySqlClient;//trabalhar com as classes de conexão com o banco de dados MySql
using System.Reflection;//acesso as classes dentro da pasta Models


namespace AppFormsVeterinario.Contexto
{
    public class VeterinarioContext
    {
        private MySqlConnection conexao = null;
        private string dados_conexao;

        //método construtor para carregar as inforamções dentro do objeto "conexão" para conectar com o banco Mysql
        public VeterinarioContext()
        {
            dados_conexao = "server=localhost;port=3306;database=aula_po2;user=root;password=34241610@Gi;Persist Security Info=false;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);//conexão preparada => objeto criado e pornto para conectar ao banco
        }//fim do método construtor

        public List<Veterinario> ListarVeterinarios()
        {
            List<Veterinario> listaVetParaExportar = new List<Veterinario>();// para retornar (return) o resutaldo e ser utilizado na aplicação
            string sql = "SELECT * FROM VETERINARIO"; //consulta SQL para trazer todas as pessoas
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);//objeto "comando" responsável por ir até o banco e realizar ações
                conexao.Open();//abrir a porta do banco para realizar a consulta
                MySqlDataReader dados = comando.ExecuteReader(); //"comando" vai realizar a consulta e enviar tudo para dentro do objeto "dados"

                //laço responsável por percorrer todos os registros que estão dentro do objeto "dados"
                while (dados.Read())
                {
                    Veterinario veterinario = new Veterinario();
                    veterinario.Id = Convert.ToInt32(dados["Id"]);
                    veterinario.Nome = dados["Nome"].ToString();
                    veterinario.Cpf = dados["Cpf"].ToString();
                    veterinario.CRMV = dados["CRMV"].ToString();
                    veterinario.Especializacao = dados["Especializacao"].ToString();
                    listaVetParaExportar.Add(veterinario);
                }
                conexao.Close(); // Fechar a porta do banco após resultado da consulta         
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            return listaVetParaExportar; //retornar o resultado (exportar para aplicação)

        }//fim do método para consultar e listar Pessoas (ListarPessoas)

        public void InserirVeterinario(Veterinario veterinario)
        {
            string sql = "INSERT INTO VETERINARIO (Nome, Cpf, CRMV, Especializacao) VALUES (@Nome, @Cpf, @CRMV, @Especializacao)"; //para inserir uma pessoa no banco

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Adicionando parâmetros para evitar SQL Injection
                comando.Parameters.AddWithValue("@Nome", veterinario.Nome);
                comando.Parameters.AddWithValue("@Cpf", veterinario.Cpf);
                comando.Parameters.AddWithValue("@CRMV", veterinario.CRMV);
                comando.Parameters.AddWithValue("@Especializacao", veterinario.Especializacao);

                conexao.Open(); // Abrir as portas do banco
                int LinhasAfestadas = comando.ExecuteNonQuery(); //executa o comando e mostrar quantas linhas foran afetadas
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir veterinário: " + ex.Message);
            }

            finally
            {
                conexao.Close(); // Fecha as portas do banco, mesmo que ocorra erro
            }
        } // fim do metodo para Inserir pessoas

        public void AtualizarVeterinario(Veterinario veterinario)
        {            // Comando SQL para atualizar os dados da pessoa
            string sql = "UPDATE VETERINARIO SET Nome = @Nome, Cpf = @Cpf, CRMV = @CRMV, Especializacao = @Especializacao WHERE Id = @Id";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Adicionando parâmetros para evitar SQL Injection
                comando.Parameters.AddWithValue("@Nome", veterinario.Nome);
                comando.Parameters.AddWithValue("@Cpf", veterinario.Cpf);
                comando.Parameters.AddWithValue("@CRMV", veterinario.CRMV);
                comando.Parameters.AddWithValue("@Especializacao", veterinario.Especializacao);
                comando.Parameters.AddWithValue("@Id", veterinario.Id);

                conexao.Open(); // Abrir as portas do banco
                int LinhasAfestadas = comando.ExecuteNonQuery(); // Executa o comando e retorna quantas linhas foran afetadas

                if (LinhasAfestadas > 0)
                {
                    MessageBox.Show("Veterinário atualizada com sucesso!");
                }

                else
                {
                    MessageBox.Show("Nenhum registro foi atualizado. Verifique o ID informado.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar veterinário: " + ex.Message);
            }

            finally
            {
                conexao.Close(); // Fecha a conexao com o banco
            }
        } // fim do Atualizar pessoa

        public void DeletarVeterinario(Veterinario veterinario)
        {
            // Comando SQL para atualizar os dados da pessoa
            string sql = "DELETE FROM VETERINARIO WHERE Id = @Id";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Adicionando parâmetros para evitar SQL Injection
                comando.Parameters.AddWithValue("@Nome", veterinario.Nome);
                comando.Parameters.AddWithValue("@Cpf", veterinario.Cpf);
                comando.Parameters.AddWithValue("@CRMV", veterinario.CRMV);
                comando.Parameters.AddWithValue("@Especializacao", veterinario.Especializacao);
                comando.Parameters.AddWithValue("@Id", veterinario.Id);

                conexao.Open(); // Abrir conexão com o banco
                int linhasAfetadas = comando.ExecuteNonQuery(); // Executa o comando e retorna quantas linhas foram alteradas

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Veterinário deletada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi deletado. Verifique o ID informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar pessoa: " + ex.Message);
            }
            finally
            {
                conexao.Close(); // Fecha a conexão com o banco
            }
        } //fim do Atualizar Pessoa
    }
}
