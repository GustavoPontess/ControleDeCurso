using ControleDeCursos.src.Models;
using System.Data;

namespace ControleDeCursos.src.Controllers
{
    internal class ProfessorController
    {
        ProfessorModel objProfessor = new ProfessorModel();

        public void CadastrarProfessor(string nome, double horaAula, string telefone)
        {
            objProfessor.Nome = nome;
            objProfessor.HoraAula = horaAula;
            objProfessor.Telefone = telefone;
            objProfessor.Cadastrar();
        }

        public DataTable ListarProfessores()
        {
            return objProfessor.Listar();
        }

        public void AlterarProfessor(int id, string nome, double horaAula, string telefone)
        {
            objProfessor.Id = id;
            objProfessor.Nome = nome;
            objProfessor.HoraAula = horaAula;
            objProfessor.Telefone = telefone;
            objProfessor.Alterar();
        }

        public void ExcluirProfessor(int id)
        {
            objProfessor.Excluir(id);
        }
    }
}
