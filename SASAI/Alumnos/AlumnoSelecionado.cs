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
        public string Tabla { get; set; }
        public AlumnoSelecionado(string alumno,string tabla= "Inscriptos")
        {
            InitializeComponent();

            Alumno = alumno;
            Tabla = tabla;
        }

        private void AlumnoSelecionado_Load(object sender, EventArgs e)
        {
            tb_DNI.Text = Alumno;
            string consulta = "";
            if (Tabla == "Preinscriptos") {
             consulta = "select Nombre,Apellido,Email,Telefono,codcurso from " + Tabla +" where DNI= " + Alumno;
            }
            else {
                 consulta = "select * from " + Tabla + " where DNI= " + Alumno;

            }
            AccesoDatos aq = new AccesoDatos();
            DataSet ds = new DataSet();
            aq.cargaTabla("tabla", consulta, ref ds);

            if (Tabla == "Preinscriptos")
            {
              textBox1.Text=  ds.Tables[0].Rows[0]["Apellido"].ToString();
              textBox2.Text=  ds.Tables[0].Rows[0]["Nombre"].ToString();
              tb_CodCurso.Text = ds.Tables[0].Rows[0]["codcurso"].ToString();
              tb_Email.Text = ds.Tables[0].Rows[0]["Email"].ToString();

                lb_top.Text = textBox1.Text+" "+textBox2.Text;
            }
            else {
                try
                {
                    textBox1.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
                    textBox2.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
                    tb_DNI.Text = ds.Tables[0].Rows[0]["DNI"].ToString();
                    tb_CodCurso.Text = ds.Tables[0].Rows[0]["codcurso"].ToString();
                    tb_Email.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                    tb_Telefono.Text = ds.Tables[0].Rows[0]["Telefono"].ToString();
                    cb_activo.Checked = bool.Parse(ds.Tables[0].Rows[0]["Activo"].ToString());
                    cb_cuil.Checked = bool.Parse(ds.Tables[0].Rows[0]["Const_Cuil"].ToString());
                    cb_Dni.Checked =bool.Parse( ds.Tables[0].Rows[0]["Fotoc_DNI"].ToString());
                    cb_analitico.Checked = bool.Parse(ds.Tables[0].Rows[0]["Const_Analitico"].ToString());
                    cb_4x4.Checked = bool.Parse(ds.Tables[0].Rows[0]["Foto4x4"].ToString());
                    cb_ConstanciaTrabajo.Checked = bool.Parse(ds.Tables[0].Rows[0]["Const_Trabajo"].ToString());
                    tb_Fecha.Text = ds.Tables[0].Rows[0]["FechaEntregaDoc"].ToString();
                    tb_Observaciones.Text = ds.Tables[0].Rows[0]["Observaciones"].ToString();



                    lb_top.Text = textBox1.Text + " " + textBox2.Text;
                }
                catch (Exception ea) { MessageBox.Show(ea.ToString()); }
               
                
            }
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (Tabla == "Preinscriptos")
            {
                /* string consulta= "insert into dbo.Inscriptos (DNI, Nombre, Apellido,UltimoCurso, Email, Telefono,Activo,Const_Analitico, Const_Cuil, Fotoc_DNI, Foto4x4, Const_Cuil, FechaEntregaDoc, observaciones) select "
                */
                AccesoDatos aq = new AccesoDatos();
                DataSet ds = new DataSet();
                SqlCommand comando = new SqlCommand();

              /*  comando = DatosSP.Inscriptos(int.Parse(tb_DNI.Text), tb_CodCurso.Text, textBox2.Text, textBox1.Text, tb_Email.Text, tb_Telefono.Text, bool.Parse(cb_activo.Checked.ToString())
                     , bool.Parse(cb_analitico.Checked.ToString()),
                   bool.Parse(cb_cuil.Checked.ToString()), bool.Parse(cb_Dni.Checked.ToString()), bool.Parse(cb_4x4.Checked.ToString()), bool.Parse(cb_ConstanciaTrabajo.Checked.ToString()), tb_Fecha.Text,tb_Observaciones.Text);
                aq.EjecutarProcedimientoAlmacenado(comando, "CargaInscripto");
                */
            }
            else
            {
                AccesoDatos aq = new AccesoDatos();
                DataSet ds = new DataSet();
                SqlCommand comando = new SqlCommand();

              /*  comando = DatosSP.Inscriptos(int.Parse(tb_DNI.Text), tb_CodCurso.Text, textBox2.Text, textBox1.Text, tb_Email.Text, tb_Telefono.Text, bool.Parse(cb_activo.CheckState.ToString())
                     , bool.Parse(cb_analitico.Checked.ToString()),
                   bool.Parse(cb_cuil.Checked.ToString()), bool.Parse(cb_Dni.Checked.ToString()), bool.Parse(cb_4x4.Checked.ToString()), bool.Parse(cb_ConstanciaTrabajo.Checked.ToString()), tb_Fecha.Text.ToString(), tb_Observaciones.Text);
                aq.EjecutarProcedimientoAlmacenado(comando, "ModificarInscripto"); */
            }
        }
    }
}
