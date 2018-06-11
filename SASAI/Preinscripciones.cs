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
    public partial class Preinscripciones : Form
    {
        public Preinscripciones()
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            Preinscripciones_Carga frm2 = new Preinscripciones_Carga();
            abrirFormularioHijo(frm2);
            
        }

        private void Preinscripciones_Load(object sender, EventArgs e)
        {

        }
    }
}
