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
            Txt_Contra.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "VerificarUsuario";
           SqlCommand comando = new SqlCommand();
           

            comando = DatosSP.Usuarios(Txt_Usuario.Text, Txt_Contra.Text, 2);
            conexion.ConfigurarProcedure(ref comando, consulta);
            comando.Connection = conexion.ObtenerConexion();
            
            SqlDataReader reader=comando.ExecuteReader();
           
         
            while (reader.Read())
            {

                if (int.Parse(reader[0].ToString())==1)
                {
                    Formularios.Usuario = Txt_Usuario.Text;
                    this.Hide();
                    Formularios.enviarFormulario().ShowDialog();
                    this.Close();
                }

            }


        }

    

        private void Txt_Contra_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void Txt_Contra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button1_Click(sender, e);
            }

            if ((int)e.KeyChar == (int)Keys.RControlKey && (int)e.KeyChar == (int)Keys.Back)
                Txt_Contra.Clear();
                
                    
           }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
