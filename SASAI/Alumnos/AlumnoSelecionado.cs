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
using Microsoft.Office.Interop;


namespace SASAI
{
    public partial class AlumnoSelecionado : Form
    {
        public string Alumno { get; set; }
        public int Tabla { get; set; }
        DataSet ds;
        string consulta;
        AccesoDatos sq;

        public AlumnoSelecionado(string alumno,int tabla= 1)
        {
            InitializeComponent();
            Alumno = alumno;
          //  MessageBox.Show(tabla.ToString());
            Tabla = tabla;


        }
        public void CargarTextboxInscripto(DataSet ds)
        {
            tb_DNI.Text = ds.Tables[0].Rows[0]["DNI"].ToString();
            tb_CodCurso.Text = ds.Tables[0].Rows[0]["UltimoCurso"].ToString();
            textBox2.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            textBox1.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
            tb_Email.Text = ds.Tables[0].Rows[0]["Email"].ToString();
            tb_Telefono.Text = ds.Tables[0].Rows[0]["Telefono"].ToString();
            tb_Observaciones.Text = ds.Tables[0].Rows[0]["Observaciones"].ToString();
        }
        public void CargarTextboxPreInscripto(DataSet ds)
        {
            tb_DNI.Text = ds.Tables[0].Rows[0]["DNI"].ToString();
            tb_CodCurso.Text = ds.Tables[0].Rows[0]["CodCurso"].ToString();
            textBox2.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            textBox1.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
            tb_Email.Text = ds.Tables[0].Rows[0]["Email"].ToString();
            tb_Telefono.Text = ds.Tables[0].Rows[0]["Telefono"].ToString();

        }
        public void CargarBoleanos(DataSet ds) {
                
            
            if (ds.Tables[0].Rows[0]["Const_Analitico"].ToString() == "True") {

                cb_analitico.Checked = true;
            }
            else
            {
                cb_analitico.Checked = false;
                }
            if (ds.Tables[0].Rows[0]["Const_Cuil"].ToString() == "True")
            {

                cb_cuil.Checked = true;
            }
            else
            {
                cb_analitico.Checked = false;
            }
            if (ds.Tables[0].Rows[0]["Activo"].ToString() == "True")
            {

                cb_activo.Checked = true;
            }
            else
            {
                cb_activo.Checked = false;
            }
            if (ds.Tables[0].Rows[0]["Fotoc_DNI"].ToString() == "True")
            {

                cb_Dni.Checked = true;
                
            }
            else
            {
                cb_Dni.Checked = false;
            }
            if (ds.Tables[0].Rows[0]["Foto4x4"].ToString() == "True")
            {

                cb_4x4.Checked = true;
            }
            else
            {
                cb_4x4.Checked = false;
            }
            if (ds.Tables[0].Rows[0]["Const_Trabajo"].ToString() == "True")
            {

               cb_ConstanciaTrabajo.Checked = true;
            }
            else
            {
                cb_ConstanciaTrabajo.Checked = false;
            }


        }
        private void AlumnoSelecionado_Load(object sender, EventArgs e)
        {
            sq = new AccesoDatos();
            ds = new DataSet();
            if (Tabla == 1) { 
                consulta = "select * from Inscriptos where DNI="+Alumno;
                sq.cargaTabla("TablaSelecionado", consulta, ref ds);
                CargarTextboxInscripto(ds);
                CargarBoleanos(ds);
            }
            else {
                consulta = "select * from Preinscriptos where DNI=" + Alumno;
                sq.cargaTabla("TablaSelecionado", consulta, ref ds);
                CargarTextboxPreInscripto(ds);
             
            }
            

        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (Tabla == 1)
            {
                DateTime fecha = new DateTime();
                fecha = DateTime.Today;
                tb_Fecha.Text = fecha.ToString();
                

                    AccesoDatos aq = new AccesoDatos();
                    DataSet ds = new DataSet();
                    SqlCommand comando = new SqlCommand();

                string codcurso = "";

                codcurso = "select CodCurso from Cursos where actual =1";
                AccesoDatos aff = new AccesoDatos();
                aff.cargaTabla("5:35AM..",codcurso,ref ds);

              codcurso=  ds.Tables["5:35AM.."].Rows[0][0].ToString();
              //  MessageBox.Show(codcurso);
                



                comando = DatosSP.Inscriptos(int.Parse(tb_DNI.Text), textBox2.Text, textBox1.Text, codcurso, tb_Email.Text, tb_Telefono.Text, cb_activo.Checked
                       , cb_analitico.Checked,
                    cb_cuil.Checked, cb_Dni.Checked, cb_4x4.Checked, cb_ConstanciaTrabajo.Checked, fecha, tb_Observaciones.Text);
                aq.EjecutarProcedimientoAlmacenado(comando, "ModificarInscripto");
                MessageBox.Show("Alumno modificado correctamente");
                this.Close();


            }
            else
            {
                    AccesoDatos aq = new AccesoDatos();
                    DataSet ds = new DataSet();
                    SqlCommand comando = new SqlCommand();

                DateTime fecha = new DateTime();
                fecha = DateTime.Today;
                tb_Fecha.Text = fecha.ToString();
                string codcurso = "";

                codcurso = "select CodCurso from Cursos where actual =1";
                AccesoDatos aff = new AccesoDatos();
                aff.cargaTabla("5:35AM..", codcurso, ref ds);

                codcurso = ds.Tables["5:35AM.."].Rows[0][0].ToString();

                comando = DatosSP.Inscriptos(int.Parse(tb_DNI.Text), textBox2.Text, textBox1.Text, codcurso, tb_Email.Text, tb_Telefono.Text, cb_activo.Checked
                        , cb_analitico.Checked,
                     cb_cuil.Checked, cb_Dni.Checked, cb_4x4.Checked, cb_ConstanciaTrabajo.Checked, fecha, tb_Observaciones.Text);
                aq.EjecutarProcedimientoAlmacenado(comando, "CargaInscripto");
                MessageBox.Show("Alumno Inscripto correctamente");
                this.Close();
            }



            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
