using System;
using System.Windows.Forms;
using ControleDeCursos.src.Controllers;

namespace ControleDeCursos
{
    public partial class ProfessorView : Form
    {
        ProfessorController objProfessorController = new ProfessorController();

        public ProfessorView()
        {
            InitializeComponent();
            dgvProfessores.DataSource = objProfessorController.ListarProfessores();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objProfessorController.CadastrarProfessor(
                txtNome.Text,
                double.Parse(txtHora.Text),
                txtTelefone.Text
            );

            MessageBox.Show("Professor cadastrado com sucesso!");
            LimparCampos();
            dgvProfessores.DataSource = objProfessorController.ListarProfessores();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objProfessorController.AlterarProfessor(
                int.Parse(txtProfessor.Text),
                txtNome.Text,
                double.Parse(txtHora.Text),
                txtTelefone.Text
            );

            MessageBox.Show("Dados alterados com sucesso!");
            LimparCampos();
            dgvProfessores.DataSource = objProfessorController.ListarProfessores();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objProfessorController.ExcluirProfessor(int.Parse(txtProfessor.Text));

            MessageBox.Show("Professor excluído com sucesso!");
            dgvProfessores.DataSource = objProfessorController.ListarProfessores();
        }

        private void dgvProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProfessor.Text = dgvProfessores.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvProfessores.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelefone.Text = dgvProfessores.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHora.Text = dgvProfessores.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void LimparCampos()
        {
            txtProfessor.Clear();
            txtNome.Clear();
            txtHora.Clear();
            txtTelefone.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
