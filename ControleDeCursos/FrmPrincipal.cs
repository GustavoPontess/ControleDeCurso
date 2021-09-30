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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCursos formCursos = new FrmCursos();
            formCursos.ShowDialog();
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTurmas formTurmas = new FrmTurmas();
            formTurmas.ShowDialog();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfessores formProfessores = new FrmProfessores();
            formProfessores.ShowDialog();
        }
    }
}
