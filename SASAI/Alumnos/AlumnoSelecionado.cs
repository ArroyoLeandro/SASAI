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
    public partial class AlumnoSelecionado : Form
    {
        public string Alumno { get; set; }
        public AlumnoSelecionado(string alumno)
        {
            InitializeComponent();

            Alumno = alumno;
        }
    }
}
