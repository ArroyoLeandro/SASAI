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
    public partial class UsuariosModificacion : Form
    {
        public UsuariosModificacion()
        {
            InitializeComponent();
            txt_passAnterior.PasswordChar ='*';
            txt_passNueva.PasswordChar = '*';
            txt_passNuevaConfirm.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool passame = false;
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "VerificarUsuario";
            SqlCommand comando = new SqlCommand();

            comando = DatosSP.Usuarios(Formularios.Usuario, txt_passAnterior.Text, 2);
            conexion.ConfigurarProcedure(ref comando, consulta);
            comando.Connection = conexion.ObtenerConexion();

            SqlDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {

                if (int.Parse(reader[0].ToString()) == 1)
                {
                    passame = true;
                }

            }

            MessageBox.Show(passame.ToString());
            if (passame==true)
            {
                if (txt_passNuevaConfirm.Text == txt_passNueva.Text)
                {
                    comando = DatosSP.Usuarios(Formularios.Usuario, txt_passNueva.Text);
                    if (conexion.EjecutarProcedimientoAlmacenado(comando, "UsuarioCambioContra")!=0)
                    { 
                        
                            MessageBox.Show("Se ha cambiado correctamente la contraseña.");
                        txt_passAnterior.Clear();
                        txt_passNueva.Clear();
                        txt_passNuevaConfirm.Clear();
                    }

                }
                else { MessageBox.Show("No coinciden la nueva contraseña con la verificacion."); }


            }
            else { MessageBox.Show("Contraseña actual incorrecta."); }

        }

        private void lbl_passAnterior_Click(object sender, EventArgs e)
        {

        }
    }
}
