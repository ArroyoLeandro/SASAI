using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SASAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       


        private void cursoActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursoActual Ce = new CursoActual();
            Ce.MdiParent = Formularios.DIOS;
            Ce.Show();

        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {

           



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursoT cursos = new CursoT();
            cursos.MdiParent = Formularios.DIOS;
            cursos.Show();
        }

        private void buscarXDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void todosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void interesadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void interesadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Interesados inte = new Interesados();
            inte.MdiParent = Formularios.DIOS;
            inte.Show();

        }

        private void todosLosAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnosTodos alumnos = new AlumnosTodos();

            alumnos.MdiParent = Formularios.DIOS;
            alumnos.Show();
        }
    }
}
