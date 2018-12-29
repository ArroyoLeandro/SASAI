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
    public partial class Curso_Actual : Form
    {
        public string Nombre { get; set; }
        public Curso_Actual()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Curso_Actual_Load(object sender, EventArgs e)
        {
            AccesoDatos aq = new AccesoDatos();
            DataSet ds = new DataSet();

            try
            {
                string consulta2 = "select codCurso, FechaInicio,FechaFinal from Cursos where actual = 1";
                aq.cargaTabla("Cursos", consulta2, ref ds);
                lb_NombreCurso.Text = "Nombre Curso: " + ds.Tables["Cursos"].Rows[0][0].ToString();
                lb_FechaInicio.Text = "Fecha de Inicio: " + ds.Tables["Cursos"].Rows[0][1].ToString();
                lb_FechaFinal.Text = "Fecha de Final: " + ds.Tables["Cursos"].Rows[0][2].ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


            try
            {

                string consulta = "select Nombre, Apellido, DNI, Email, Telefono from Inscriptos  inner join Cursos on Cursos.CodCurso = Inscriptos.UltimoCurso   where Cursos.actual = 1";

                aq.cargaTabla("Inscriptos", consulta, ref ds);

                dataGridView1.DataSource = ds.Tables["Inscriptos"];
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


        }
    }
}
