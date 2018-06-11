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


        public void abrirFormularioHijo(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        public void cerrarFormularioHijo()
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }
        }


        private void cursoActualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cerrarFormularioHijo();
            Preinscripciones frm = new Preinscripciones();
            abrirFormularioHijo(frm);
            



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cargaBajaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
