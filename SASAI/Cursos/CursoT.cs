﻿using System;
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
    public partial class CursoT : Form
    {
        public CursoT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CursoT_Filtrar CursoF = new CursoT_Filtrar();
            CursoF.MdiParent = Formularios.DIOS;
            CursoF.Show();
        }
    }
}
