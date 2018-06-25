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
           
            Formularios.AbrirFormularioPadre(new CursoActual());
            
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportarExcel imp = new ImportarExcel();

            Formularios.AbrirFormularioPadre(imp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.AbrirFormularioPadre(new CursoT());

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
            Formularios.AbrirFormularioPadre(new Interesados());


        }

        private void todosLosAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.AbrirFormularioPadre(new AlumnosTodos());

        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.AbrirFormularioPadre(new Materias());


        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.AbrirFormularioPadre(new UsuariosModificacion());

        }
    }
}
