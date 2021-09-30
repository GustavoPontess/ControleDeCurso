using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    class Turmas
    {
        public int idCurso, idProfessor, codigo;
        public string horaInicio, horaTermino;
        public string dataInicio, dataTermino;
        Conexao objBD = new Conexao();
        string tabela = "tbl_turma";

        public void InserirTurma()
        {
            string inserir = $"INSERT INTO {tabela} VALUES (null, '{idCurso}', '{dataInicio}', '{dataTermino}', '{horaInicio}', '{horaTermino}', '{idProfessor}');";
            objBD.ExecutarComando(inserir);
        }

        public void AlterarTurma()
        {
            string alterar = $@"UPDATE {tabela} SET     idCurso        = '{idCurso}', 
                                                        dataInicio         = '{dataInicio}', 
                                                        dataTermino = '{dataTermino}', 
                                                        horaInicio     = '{horaInicio}' ,
                                                        horaTermino     = '{horaTermino}', 
                                                        idProfessor    = '{idProfessor}' 
                                                WHERE   codigo           = '{codigo}';";
            objBD.ExecutarComando(alterar);
        }

        public void ExcluirTurma()
        {
            string excluir = $"DELETE FROM {tabela} WHERE codigo = '{codigo}';";
            objBD.ExecutarComando(excluir);
        }

        public DataTable ListarTurma()
        {
            string query = $"SELECT * FROM {tabela} ORDER BY codigo;";
            return objBD.ExecutarConsulta(query);
        }
        public DataTable cbCurso()
        {
            string query = $"select * from tbl_curso";
            return objBD.ExecutarConsulta(query);
        }
        public DataTable cbProfessor()
        {
            string query = $"select * from tbl_professor";
            return objBD.ExecutarConsulta(query);
        }
    }
}
