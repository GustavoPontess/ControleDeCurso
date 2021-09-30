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
    public partial class FrmCursos : Form
    {
        public FrmCursos()
        {
            InitializeComponent();
        }
        Curso objCurso = new Curso();
        private void button1_Click(object sender, EventArgs e)
        {
            //CADASTRAR
            objCurso.nomeCurso = txtNomeCurso.Text;
            objCurso.conteudo = txtConteudo.Text;
            objCurso.valorMensalidade = Double.Parse(txtValorMensalidade.Text);
            objCurso.cargaHoraria = txtCargaHoraria.Text;
            objCurso.Cadastrar();
            MessageBox.Show("Registro cadastrado com sucesso!");
            //Limpando os campos
            txtNomeCurso.Clear();
            txtConteudo.Clear();
            txtValorMensalidade.Clear();
            txtCargaHoraria.Clear();
            dtgCursos.DataSource = objCurso.Listar();
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            dtgCursos.DataSource = objCurso.Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //excluir 
            objCurso.codigo = int.Parse(txtCodigo.Text);
            objCurso.ExcluirCurso();
            MessageBox.Show("Registro Excluido com sucesso!!");
            dtgCursos.DataSource = objCurso.Listar();
        }

        private void dtgCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //carregar nos txt o valor selecionado no grid
            txtCodigo.Text = dtgCursos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeCurso.Text = dtgCursos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtConteudo.Text = dtgCursos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtValorMensalidade.Text = dtgCursos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCargaHoraria.Text = dtgCursos.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //alterar
            objCurso.nomeCurso = txtNomeCurso.Text;
            objCurso.codigo = int.Parse(txtCodigo.Text);
            objCurso.conteudo = txtConteudo.Text;
            objCurso.valorMensalidade = Double.Parse(txtValorMensalidade.Text);
            objCurso.cargaHoraria = txtCargaHoraria.Text;
            objCurso.AlterarCurso();
            MessageBox.Show("Registro alterado com sucesso!");
            //Limpando os campos
            txtNomeCurso.Clear();
            txtConteudo.Clear();
            txtValorMensalidade.Clear();
            txtCargaHoraria.Clear();
            dtgCursos.DataSource = objCurso.Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //LIMPAR
            txtNomeCurso.Clear();
            txtConteudo.Clear();
            txtValorMensalidade.Clear();
            txtCargaHoraria.Clear();
        }

        private void dtgCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
