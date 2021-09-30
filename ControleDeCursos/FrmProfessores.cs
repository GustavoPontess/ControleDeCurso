using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeCursos
{
    public partial class FrmProfessores : Form
    {
        public FrmProfessores()
        {
            InitializeComponent();
            dgvProfessores.DataSource = objProfessores.ListarProfessor();
        }

        Professores objProfessores = new Professores();

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvProfessores.DataSource = objProfessores.ListarProfessor();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objProfessores.nome = txtNome.Text;
            objProfessores.telefone = txtTelefone.Text;
            objProfessores.horaAula = double.Parse(txtHora.Text);
            objProfessores.InserirProfessor();
            MessageBox.Show("Dados enviados com sucesso.");
            dgvProfessores.DataSource = objProfessores.ListarProfessor();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objProfessores.codigo = int.Parse(txtProfessor.Text);
            objProfessores.nome = txtNome.Text;
            objProfessores.telefone = txtTelefone.Text;
            objProfessores.horaAula = double.Parse(txtHora.Text);
            objProfessores.AlterarProfessor();
            MessageBox.Show("Dados alterados com sucesso.");
            dgvProfessores.DataSource = objProfessores.ListarProfessor();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objProfessores.codigo = int.Parse(txtProfessor.Text);
            objProfessores.ExcluirProfessor();
            MessageBox.Show("Professor excluído com sucesso.");
            dgvProfessores.DataSource = objProfessores.ListarProfessor();
        }

        private void dgvProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProfessor.Text = dgvProfessores.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvProfessores.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHora.Text = dgvProfessores.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefone.Text = dgvProfessores.Rows[e.RowIndex].Cells[3].Value.ToString();

        }
    }
}
