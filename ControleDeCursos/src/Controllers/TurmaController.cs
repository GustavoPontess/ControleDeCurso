using ControleDeCursos.src.Models;
using System.Data;

namespace ControleDeCursos.src.Controllers
{
    internal class TurmaController
    {
        TurmaModel objTurma = new TurmaModel();

        public void CadastrarTurma(int idCurso, int idProfessor, string dataInicio, string dataTermino, string horaInicio, string horaTermino)
        {
            objTurma.IdCurso = idCurso;
            objTurma.IdProfessor = idProfessor;
            objTurma.DataInicio = dataInicio;
            objTurma.DataTermino = dataTermino;
            objTurma.HoraInicio = horaInicio;
            objTurma.HoraTermino = horaTermino;
            objTurma.Cadastrar();
        }

        public DataTable ListarTurmas()
        {
            return objTurma.Listar();
        }

        public void AlterarTurma(int id, int idCurso, int idProfessor, string dataInicio, string dataTermino, string horaInicio, string horaTermino)
        {
            objTurma.Id = id;
            objTurma.IdCurso = idCurso;
            objTurma.IdProfessor = idProfessor;
            objTurma.DataInicio = dataInicio;
            objTurma.DataTermino = dataTermino;
            objTurma.HoraInicio = horaInicio;
            objTurma.HoraTermino = horaTermino;
            objTurma.Alterar();
        }

        public void ExcluirTurma(int id)
        {
            objTurma.Excluir(id);
        }

        public DataTable ListarCursos()
        {
            return objTurma.ListarCursos();
        }

        public DataTable ListarProfessores()
        {
            return objTurma.ListarProfessores();
        }
    }
}
