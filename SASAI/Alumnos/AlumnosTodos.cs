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
       
        public int numtabla { get; set; }
        DataSet ds = new DataSet();
        AccesoDatos aq = new AccesoDatos();
        string consulta = "";
        public AlumnosTodos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AlumnosF buscar = new AlumnosF();
            //buscar.MdiParent = Formularios.DIOS;
            Formularios.AbrirFormularioHijos(buscar);
            
          //  consulta = buscar.qseyo;
            numtabla = buscar.tablita;
            //MessageBox.Show(buscar.tablita.ToString());

            if (numtabla != 0) { 
            aq.cargaTabla("asd", consulta, ref ds);
            dataGridView1.DataSource = ds.Tables["asd"];
            }
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

            ds = new DataSet();
            GestionSql aw = new GestionSql();
             consulta = "select * from inscriptos";
            aq.cargaTabla("tabla", consulta, ref ds);
            dataGridView1.DataSource = ds.Tables[0];


         }

       

        private void AlumnosTodos_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.Height = this.Height - 180;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



            string Dni = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            //MessageBox.Show(Dni);


            AlumnoSelecionado aqr = new AlumnoSelecionado(Dni, 1);
            Formularios.AbrirFormularioHijos(aqr);
            ds = new DataSet();
            consulta = "select * from inscriptos";
            aq.cargaTabla("tabla", consulta, ref ds);
            dataGridView1.DataSource = ds.Tables[0];


        }
    }
}
