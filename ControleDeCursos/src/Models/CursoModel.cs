using System.Data;
using MySql.Data.MySqlClient;

namespace ControleDeCursos.src.Models
{
    public class CursoModel
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }
        public string Conteudo { get; set; }
        public int CargaHoraria { get; set; }
        public double ValorMensalidade { get; set; }

        ConnectionHelper objBD = new ConnectionHelper();

        public void Cadastrar()
        {
            string query = $"INSERT INTO cursos (nome_curso, conteudo, carga_horaria, valor_mensalidade) VALUES ('{NomeCurso}', '{Conteudo}', {CargaHoraria}, {ValorMensalidade});";
            objBD.ExecutarComando(query);
        }

        public DataTable Listar()
        {
            return objBD.ExecutarConsulta("SELECT * FROM cursos ORDER BY id;");
        }

        public void AlterarCurso()
        {
            string query = $"UPDATE cursos SET nome_curso = '{NomeCurso}', conteudo = '{Conteudo}', carga_horaria = {CargaHoraria}, valor_mensalidade = {ValorMensalidade} WHERE id = {Id};";
            objBD.ExecutarComando(query);
        }

        public void ExcluirCurso(int id)
        {
            string query = $"DELETE FROM cursos WHERE id = {id};";
            objBD.ExecutarComando(query);
        }
    }
}
