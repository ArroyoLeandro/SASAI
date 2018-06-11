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
    public partial class AlumnosTodos : Form
    {
        public AlumnosTodos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlumnosF buscar = new AlumnosF();

            buscar.MdiParent = Formularios.DIOS;
            buscar.Show();
        }
    }
}
