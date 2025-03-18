using ControleDeCursos.src.Models;
using System.Data;

namespace ControleDeCursos.src.Controllers
{
    internal class CursoController
    {
        CursoModel objCurso = new CursoModel();

        public void CadastrarCurso(string nome, string conteudo, int cargaHoraria, double valor)
        {
            objCurso.NomeCurso = nome;
            objCurso.Conteudo = conteudo;
            objCurso.CargaHoraria = cargaHoraria;
            objCurso.ValorMensalidade = valor;
            objCurso.Cadastrar();
        }

        public DataTable ListarCursos()
        {
            return objCurso.Listar();
        }

        public void AlterarCurso(int id, string nome, string conteudo, int cargaHoraria, double valor)
        {
            objCurso.Id = id;
            objCurso.NomeCurso = nome;
            objCurso.Conteudo = conteudo;
            objCurso.CargaHoraria = cargaHoraria;
            objCurso.ValorMensalidade = valor;
            objCurso.AlterarCurso();
        }

        public void ExcluirCurso(int id)
        {
            objCurso.ExcluirCurso(id);
        }
    }
}
