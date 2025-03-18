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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursoView formCursos = new CursoView();
            formCursos.ShowDialog();
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurmaView formTurmas = new TurmaView();
            formTurmas.ShowDialog();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfessorView formProfessores = new ProfessorView();
            formProfessores.ShowDialog();
        }
    }
}
