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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection cn = new SqlConnection();
                AccesoDatos aq = new AccesoDatos();
                cn = aq.ObtenerConexion();
            SqlCommand comando = new SqlCommand();
            comando = DatosSP.Usuarios(Txt_Usuario.Text,Txt_Contra.Text);

                //  MessageBox.Show(aq.EjecutarProcedimientoAlmacenado(comando, "VerificarUsuario").ToString());

                comando.CommandText = "select * from usuarios where usuario = '" + Txt_Usuario.Text + "' " +" and contrasena = '" + Txt_Contra.Text + "'";
                comando.Connection = cn;
            

                SqlDataReader dr = comando.ExecuteReader();

              //  MessageBox.Show(comando.CommandText);
                 while (dr.Read()==true) 
                 {
                    this.Hide();
                    Formularios.enviarFormulario().ShowDialog();
                    this.Close();
                }
                cn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
