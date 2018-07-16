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
        DataSet ds = new DataSet();
        public AlumnosTodos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlumnosF buscar = new AlumnosF();

            //buscar.MdiParent = Formularios.DIOS;
            Formularios.AbrirFormularioHijos(buscar);
        }

        private void AlumnosTodos_Load(object sender, EventArgs e)
        {
            AccesoDatos aq = new AccesoDatos();
            string consulta = "select top 50 * from inscriptos";
            

            aq.cargaTabla("Inscriptos", consulta, ref ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // dataGridView1.SelectedRows
            GestionSql aw = new GestionSql();
          //  falta corregir esto jejejejeje que seria el borrar 1 solo inscripto
          /// aw.EliminarInscripto("Inscriptos",ds,"EliminarInscripto", dataGridView1.SelectedRows)
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         

           
            string Dni = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            MessageBox.Show(Dni);
            AlumnoSelecionado aq = new AlumnoSelecionado(Dni);
            Formularios.AbrirFormularioHijos(aq);
        }
    }
}
