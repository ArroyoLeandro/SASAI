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
    public partial class BajayModificacionAdministrador : Form
    {
        AccesoDatos aq = new AccesoDatos();
        DataSet ds = new DataSet();

        public BajayModificacionAdministrador()
        {
            InitializeComponent();
            

        }
        private void BajayModificacionAdministrador_Load(object sender, EventArgs e)
        {

                string consulta = "select * from Usuarios";
                aq.cargaTabla("Usuarios", consulta, ref ds);
                dataGridView1.DataSource = ds.Tables["Usuarios"];
            dataGridView1.Rows[2].Cells[3].Selected = true;
            radioButton2.Checked = true;
             


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                       
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[3].Value.ToString() != "0")
                        {
                            dataGridView1.Rows[i].Visible = true;
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                        }
                    }
                    catch (Exception) { }
                }

            

            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows[2].Cells[3].Selected = false ;
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() != "0")
                    try { dataGridView1.Rows[i].Visible = false; }
                    catch (Exception) { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
