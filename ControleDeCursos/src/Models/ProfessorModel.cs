using System.Data;
using MySql.Data.MySqlClient;

namespace ControleDeCursos.src.Models
{
    public class ProfessorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public double HoraAula { get; set; }

        ConnectionHelper objBD = new ConnectionHelper();

        public DataTable Listar()
        {
            return objBD.ExecutarConsulta("SELECT * FROM professores ORDER BY id;");
        }

        public void Cadastrar()
        {
            string query = $"INSERT INTO professores (nome, hora_aula, telefone) VALUES ('{Nome}', {HoraAula}, '{Telefone}');";
            objBD.ExecutarComando(query);
        }

        public void Alterar()
        {
            string query = $"UPDATE professores SET nome = '{Nome}', telefone = '{Telefone}', hora_aula = {HoraAula} WHERE id = {Id};";
            objBD.ExecutarComando(query);
        }

        public void Excluir(int id)
        {
            string query = $"DELETE FROM professores WHERE id = {id};";
            objBD.ExecutarComando(query);
        }
    }
}
