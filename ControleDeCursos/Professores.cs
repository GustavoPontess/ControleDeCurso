using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    class Professores
    {
        public int codigo;
        public string nome, telefone;
        public double horaAula;
        Conexao objBD = new Conexao();
        string tabela = "Tbl_Professor";

        public void InserirProfessor()
        {
            string inserir = $"INSERT INTO {tabela} VALUES (null, '{nome}', '{horaAula}', '{telefone}');";
            objBD.ExecutarComando(inserir);
        }

        public void AlterarProfessor()
        {
            string alterar = $@"UPDATE {tabela} SET     nome                  = '{nome}', 
                                                        valorHoraAula         = '{horaAula}', 
                                                        telefone              = '{telefone}'
                                                WHERE   codigo           = '{codigo}';";
            objBD.ExecutarComando(alterar);
        }

        public void ExcluirProfessor()
        {
            string excluir = $"DELETE FROM {tabela} WHERE codigo = '{codigo}';";
            objBD.ExecutarComando(excluir);
        }

        public DataTable ListarProfessor()
        {
            string query = $"SELECT * FROM {tabela} ORDER BY codigo;";
            return objBD.ExecutarConsulta(query);
        }
    }
}
