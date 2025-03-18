using System;
using System.Windows.Forms;
using ControleDeCursos.src.Controllers;

namespace ControleDeCursos
{
    public partial class TurmaView : Form
    {
        TurmaController objTurmaController = new TurmaController();

        public TurmaView()
        {
            InitializeComponent();
            CarregarCombos();
            dgvTurma.DataSource = objTurmaController.ListarTurmas();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Verificar se os ComboBoxes estão preenchidos corretamente
            if (cbCurso.SelectedValue == null || cbProfessor.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um curso e um professor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Garantir que os valores selecionados são numéricos
            if (!int.TryParse(cbCurso.SelectedValue.ToString(), out int idCurso))
            {
                MessageBox.Show("Curso inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cbProfessor.SelectedValue.ToString(), out int idProfessor))
            {
                MessageBox.Show("Professor inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se os campos de data e hora não estão vazios
            if (string.IsNullOrWhiteSpace(txtHoraInicio.Text) || string.IsNullOrWhiteSpace(txtHoraTermino.Text) ||
                string.IsNullOrWhiteSpace(dtInicio.Text) || string.IsNullOrWhiteSpace(dtTermino.Text))
            {
                MessageBox.Show("Preencha todos os campos de data e hora.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chamar o Controller para cadastrar a turma
            objTurmaController.CadastrarTurma(idCurso, idProfessor, dtInicio.Text, dtTermino.Text, txtHoraInicio.Text, txtHoraTermino.Text);

            MessageBox.Show("Turma cadastrada com sucesso!");
            LimparCampos();
            dgvTurma.DataSource = objTurmaController.ListarTurmas();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objTurmaController.AlterarTurma(
                int.Parse(txtTurma.Text),
                (int)cbCurso.SelectedValue,
                (int)cbProfessor.SelectedValue,
                dtInicio.Text,
                dtTermino.Text,
                txtHoraInicio.Text,
                txtHoraTermino.Text
            );

            MessageBox.Show("Turma alterada com sucesso!");
            LimparCampos();
            dgvTurma.DataSource = objTurmaController.ListarTurmas();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objTurmaController.ExcluirTurma(int.Parse(txtTurma.Text));

            MessageBox.Show("Turma excluída com sucesso!");
            dgvTurma.DataSource = objTurmaController.ListarTurmas();
        }

        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTurma.Text = dgvTurma.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbCurso.SelectedValue = dgvTurma.Rows[e.RowIndex].Cells[1].Value;
            dtInicio.Text = dgvTurma.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtTermino.Text = dgvTurma.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtHoraInicio.Text = dgvTurma.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtHoraTermino.Text = dgvTurma.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbProfessor.SelectedValue = dgvTurma.Rows[e.RowIndex].Cells[6].Value;
        }

        private void CarregarCombos()
        {
            cbCurso.DataSource = objTurmaController.ListarCursos();
            cbCurso.ValueMember = "id";
            cbCurso.DisplayMember = "nome_curso";

            cbProfessor.DataSource = objTurmaController.ListarProfessores();
            cbProfessor.ValueMember = "id";
            cbProfessor.DisplayMember = "nome";
        }

        private void LimparCampos()
        {
            txtTurma.Clear();
            txtHoraInicio.Clear();
            txtHoraTermino.Clear();
        }
    }
}
