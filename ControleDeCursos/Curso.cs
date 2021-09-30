using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    class Curso
    {
        public int codigo;
        public string nomeCurso, conteudo, cargaHoraria;
        public double valorMensalidade;
        string tabela = "tbl_curso";
        Conexao objConexao = new Conexao();


        public void Cadastrar()
        {
            //TESTE DE CONEXAO COM O BANCO;
            //Conexao objConexao = new Conexao();
            //objConexao.Conectar();
            //MessageBox.Show("Conectou");

            //Passo: comando sql - insert into 
            string inserir = $"insert into {tabela} values " +
                $"(null,'{nomeCurso}','{conteudo}', '{cargaHoraria}'," +
                $"'{valorMensalidade}' )";
            //Passo2: executar o comando sql 
            objConexao.ExecutarComando(inserir);
        }

        public DataTable Listar()
        {
            //Passo 1- comando sql
            string listar = $"select * from {tabela} order by codigo";
            return objConexao.ExecutarConsulta(listar);
        }
        public void AlterarCurso()
        {
            string alterar = $@"update {tabela} set 
                nomeCurso= '{nomeCurso}',
                conteudo='{conteudo}', 
                valorMensalidade='{valorMensalidade}',
                cargaHoraria='{cargaHoraria}' where codigo='{codigo}';";
                objConexao.ExecutarComando(alterar);
        }
        public void ExcluirCurso()
        {
            string excluir = $"delete from {tabela} where codigo='{codigo}';";
            objConexao.ExecutarComando(excluir);
        }
    }
}
