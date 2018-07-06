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
            AccesoDatos aq = new AccesoDatos();
            DataSet ds = new DataSet();
            string consulta = "select* from Usuarios where usuario = '"+Txt_Usuario.Text+"' and contrasena = '"+Txt_Contra.Text+"'";

            // AccesoDatos aq = new AccesoDatos();
            //  DataSet ds = new DataSet();
            //  string consulta = "select* from Usuarios where usuario = '"+Txt_Usuario.Text+"' and contrasena = '"+Txt_Contra.Text+"'";
            SqlCommand comando = new SqlCommand();



            if (Usuario_class.VerificarAlluser(Txt_Usuario.Text,Txt_Contra.Text) !=-1)
            {
                Formularios.Usuario = Txt_Usuario.Text;
                Formularios.acceso = Usuario_class.VerificarAlluser(Txt_Usuario.Text, Txt_Contra.Text);
                this.Hide();
                Formularios.enviarFormulario().ShowDialog();
                this.Close();

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
        }

          

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
             
            }
        }
    }
}
