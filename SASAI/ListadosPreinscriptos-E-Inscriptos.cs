using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SASAI
{
    public partial class ListadosPreinscriptos_E_Inscriptos : Form
    {
        public ListadosPreinscriptos_E_Inscriptos()
        {
            InitializeComponent();
        }

        AccesoDatos aq = new AccesoDatos();
        DataSet ds = new DataSet();

        private void ListadosPreinscriptos_E_Inscriptos_Load(object sender, EventArgs e)
        {
           

            try
            {

                string consulta2 = "select * from Preinscriptos";
                aq.cargaTabla("Preinscriptos", consulta2, ref ds);
                dataGridView1.DataSource = ds.Tables["Preinscriptos"];

                for (int count = 0; count < dataGridView1.Rows.Count; count++)
                {
                    //condicion que hace pintar las filas
                   // if (dataGridView1.Rows[count].Cells[5].Value!= 0)
                   if(count %2 ==0)
                    {
                        dataGridView1.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        dataGridView1.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btn_flt_Click(object sender, EventArgs e)
        {

            if (chk_rojo.Checked == true) {
                string consulta2 = "select * from Preinscriptos";
                aq.cargaTabla("Preinscriptos", consulta2, ref ds);
                dataGridView1.DataSource = ds.Tables["Preinscriptos"];
                for (int count = 0; count < dataGridView1.Rows.Count; count++)
                {
                    dataGridView1.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
            if (chk_verde.Checked == true)
            {
                string consulta2 = "select * from Preinscriptos inner join Inscriptos on Preinscriptos.DNI=Inscriptos.DNI";
                aq.cargaTabla("PreinscriptosE_Inscriptos", consulta2, ref ds);
                dataGridView1.DataSource = ds.Tables["PreinscriptosE_Inscriptos"];
                for (int count = 0; count < dataGridView1.Rows.Count; count++)
                {
                    dataGridView1.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                }
            }
        }
    }
}
