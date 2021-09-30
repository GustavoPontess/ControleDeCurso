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
    public partial class FrmTurmas : Form
    {
        public FrmTurmas()
        {
            InitializeComponent();
        }
        Turmas objTurma = new Turmas();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objTurma.idProfessor = (int)cbProfessor.SelectedValue;
            objTurma.idCurso = (int)cbCurso.SelectedValue;
            objTurma.horaInicio = txtHoraInicio.Text;
            objTurma.horaTermino = txtHoraTermino.Text;
            objTurma.dataInicio = dtInicio.Text;
            objTurma.dataTermino = dtTermino.Text;
            objTurma.InserirTurma();
            MessageBox.Show("Dados enviados com sucesso.");
            dgvTurma.DataSource = objTurma.ListarTurma();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objTurma.codigo = int.Parse(txtTurma.Text);
            objTurma.idProfessor = (int)cbProfessor.SelectedValue;
            objTurma.idCurso = (int)cbCurso.SelectedValue;
            objTurma.horaInicio = txtHoraInicio.Text;
            objTurma.horaTermino = txtHoraTermino.Text;
            objTurma.dataInicio = dtInicio.Text;
            objTurma.dataTermino = dtTermino.Text;
            objTurma.AlterarTurma();
            MessageBox.Show("Dados alterados com sucesso.");
            ExibirDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objTurma.codigo = int.Parse(txtTurma.Text);
            objTurma.ExcluirTurma();
            MessageBox.Show("Turma excluída com sucesso.");
            ExibirDados();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvTurma.DataSource = objTurma.ListarTurma();
        }

        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTurma.Text = dgvTurma.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbCurso.Text = dgvTurma.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtInicio.Text = dgvTurma.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtTermino.Text = dgvTurma.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtHoraInicio.Text = dgvTurma.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtHoraTermino.Text = dgvTurma.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbProfessor.Text = dgvTurma.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        private void ExibirDados()
        {
            dgvTurma.DataSource = objTurma.ListarTurma();
            cbCurso.DataSource = objTurma.cbCurso();
            cbCurso.ValueMember = "codigo";
            cbCurso.DisplayMember = "nomeCurso";
            cbProfessor.DataSource = objTurma.cbProfessor();
            cbProfessor.ValueMember = "codigo";
            cbProfessor.DisplayMember = "nome";
        }
        private void FrmCursos_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void FrmTurmas_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }

    }
}
