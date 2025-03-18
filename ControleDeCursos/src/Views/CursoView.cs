using System;
using System.Windows.Forms;
using ControleDeCursos.src.Controllers;

namespace ControleDeCursos
{
    public partial class CursoView : Form
    {
        CursoController objCursoController = new CursoController();

        public CursoView()
        {
            InitializeComponent();
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            dtgCursos.DataSource = objCursoController.ListarCursos();
        }

        private void dtgCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgCursos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeCurso.Text = dtgCursos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtConteudo.Text = dtgCursos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCargaHoraria.Text = dtgCursos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtValorMensalidade.Text = dtgCursos.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objCursoController.CadastrarCurso(
                txtNomeCurso.Text,
                txtConteudo.Text,
                int.Parse(txtCargaHoraria.Text),
                double.Parse(txtValorMensalidade.Text)
            );

            MessageBox.Show("Curso cadastrado com sucesso!");
            LimparCampos();
            dtgCursos.DataSource = objCursoController.ListarCursos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Verifica se o campo de código está preenchido corretamente
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um curso antes de alterar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCodigo.Text, out int id))
            {
                MessageBox.Show("Código inválido! Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCargaHoraria.Text, out int cargaHoraria))
            {
                MessageBox.Show("Carga horária inválida! Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtValorMensalidade.Text, out double valorMensalidade))
            {
                MessageBox.Show("Valor da mensalidade inválido! Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objCursoController.AlterarCurso(
                id,
                txtNomeCurso.Text,
                txtConteudo.Text,
                cargaHoraria,
                valorMensalidade
            );

            MessageBox.Show("Registro alterado com sucesso!");
            LimparCampos();
            dtgCursos.DataSource = objCursoController.ListarCursos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objCursoController.ExcluirCurso(int.Parse(txtCodigo.Text));

            MessageBox.Show("Registro excluído com sucesso!");
            dtgCursos.DataSource = objCursoController.ListarCursos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNomeCurso.Clear();
            txtConteudo.Clear();
            txtValorMensalidade.Clear();
            txtCargaHoraria.Clear();
        }
    }
}
