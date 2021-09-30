using System;
using MySql.Data.MySqlClient;
using System.Data;          //Para utilizar objetos DataTable

namespace ControleDeCursos
{
class Conexao
{
        //define qual e o banco de dados
        MySqlConnection conexao;

        //método para conectar no banco de dados
        public void Conectar()
        {
            //informações da minha conexão
            try
            {
                string conn = "Persist Security Info = false; " +
                              "server = localhost; " +
                              "database = cursos_bd; " +
                              "uid = root; pwd=";
                //recebe as informaçoes da conexao e verifica se esta correto 
                conexao = new MySqlConnection(conn);
                //abre a conexão MySql
                conexao.Open();
            }
            catch (MySqlException ex)
            {
                //se nao conseguir conectar exibe a mensagem de erro.
                throw new Exception("Não foi possível conectar ao banco de dados.\n" + ex.Message);
            }
        }

        //método para executar consultas sql - select
        public DataTable ExecutarConsulta(string sql)       //sql é uma string que deve conter uma instrução Select
        {
            try
            {
                //Passo 1: conectar
                Conectar();         
                //Passo 2: recebe e executa a consulta sql
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                //Passo 3: informar onde esses dados do banco serao guardados
                DataTable dt = new DataTable();
                //Passo 4: guardar as informaçoes da consulta no DataTable
                dados.Fill(dt);    //Preenchimento do objeto DataTable(dt) com os dados obtidos da execução do select
                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível executar a CONSULTA solicitada.\n" + ex.Message);
            }
            finally
            {
                //Passo 5: fecha conexão
                conexao.Close();
            }
        }
        //método executar insert, update e delete
        public void ExecutarComando(string sql)     //sql: instrução sql de INSERT, UPDATE ou DELETE
        {
            //Passo 1: conectar no banco
            Conectar();
            //Passo 2: recebe o comando sql e as informaçoes da conexao
            //e verifica se esta tudo correto
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                //Passo 3: executar o comando sql
                comando.ExecuteNonQuery();      //Método responsável por executar a instrução sql
            }
            catch (MySqlException ex)
{
                throw new Exception("A instrução não foi realizada.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();        //Importante para que o banco não fique vulnerável.
            }
        }
    }
}