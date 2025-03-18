using System.Data;
using MySql.Data.MySqlClient;

namespace ControleDeCursos.src.Models
{
    public class TurmaModel
    {
        public int Id { get; set; }
        public int IdCurso { get; set; }
        public int IdProfessor { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }
        public string DataInicio { get; set; }
        public string DataTermino { get; set; }

        ConnectionHelper objBD = new ConnectionHelper();

        public DataTable Listar()
        {
            return objBD.ExecutarConsulta("SELECT * FROM turmas ORDER BY id;");
        }

        public void Cadastrar()
        {
            string query = $"INSERT INTO turmas (id_curso, id_professor, data_inicio, data_termino, hora_inicio, hora_termino) " +
                           $"VALUES ({IdCurso}, {IdProfessor}, '{DataInicio}', '{DataTermino}', '{HoraInicio}', '{HoraTermino}');";
            objBD.ExecutarComando(query);
        }

        public void Alterar()
        {
            string query = $"UPDATE turmas SET id_curso = {IdCurso}, id_professor = {IdProfessor}, " +
                           $"data_inicio = '{DataInicio}', data_termino = '{DataTermino}', " +
                           $"hora_inicio = '{HoraInicio}', hora_termino = '{HoraTermino}' WHERE id = {Id};";
            objBD.ExecutarComando(query);
        }

        public void Excluir(int id)
        {
            string query = $"DELETE FROM turmas WHERE id = {id};";
            objBD.ExecutarComando(query);
        }

        public DataTable ListarCursos()
        {
            return objBD.ExecutarConsulta("SELECT id, nome_curso FROM cursos ORDER BY nome_curso;");
        }

        public DataTable ListarProfessores()
        {
            return objBD.ExecutarConsulta("SELECT id, nome FROM professores ORDER BY nome;");
        }
    }
}
