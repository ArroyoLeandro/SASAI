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
    public partial class AlumnosF : Form
    {
        public AlumnosF()
        {
            InitializeComponent();
        }

        private void AlumnosF_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta = "";
            armarconsulta(ref consulta, "Inscriptos");
          //  MessageBox.Show(consulta);
            AccesoDatos aq = new AccesoDatos();
            DataSet ds = new DataSet();

            aq.cargaTabla("Inscriptos", consulta, ref ds);

            // para saber si existe..

            //  MessageBox.Show( ds.Tables[0].Rows[0][0].ToString());
            try {
                if (ds.Tables["Inscriptos"].Rows[0][1].ToString() != string.Empty)
                {
                    AlumnoSelecionado aw = new AlumnoSelecionado(textBox1.Text);
                    Formularios.AbrirFormularioHijos(aw);
                }
                  }
            catch (Exception ex) {
                consulta = "select DNI,Nombre,Apellido,Email,Telefono,codcurso from Preinscriptos where DNI ="+textBox1.Text;
                aq.cargaTabla("Preinscriptos", consulta, ref ds);
                try {
                    if (ds.Tables["Preinscriptos"].Rows[0][1].ToString() != string.Empty) {
                        AlumnoSelecionado aw = new AlumnoSelecionado(textBox1.Text,"Preinscriptos");
                        Formularios.AbrirFormularioHijos(aw);


                    }
                }
                catch (Exception )
                { }
             
            }
            

           // dataGridView1.DataSource = ds.Tables["Inscriptos"];

          //  Application.Exit();

        }


        public void armarconsulta(ref string ar,string tabla)
        {
            string d1 = " AND ";

            int num = 0;
            if (ar == string.Empty)
            {
                ar = "select * from  "+tabla;

                
            }

            if (textBox1.Text != string.Empty)
            {
                if (num != 0) { ar += d1; num = 0; }
                else { ar += " where "; }
                ar += " DNI = '" + textBox1.Text + "' ";
                num++;
            }
            if (textBox2.Text != string.Empty)
            {
                if (num != 0) { ar += d1; num = 0; }
                else { ar += " where "; }
                ar += "  Nombre like '%" + textBox2.Text + "%' ";
                num++;
            }

            if (textBox3.Text != string.Empty)
            {
                if (num != 0) { ar += d1; num = 0; }
                else { ar += " where "; }
                ar += "  Apellido like '%" + textBox3.Text + "%' ";
                num++;

            }

            if (textBox4.Text != string.Empty)
            {
                if (num != 0) { ar += d1; num = 0; }
                else { ar += " where "; }
                ar += "  email  like '%" + textBox4.Text + "%' ";
                num++;

            }
            if (textBox5.Text != string.Empty)
            {
                if (num != 0) { ar += d1; num = 0; }
                else { ar += " where "; }
                ar += "  UltimoCurso  like '%" + textBox5.Text + "%' ";
                num++;

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
