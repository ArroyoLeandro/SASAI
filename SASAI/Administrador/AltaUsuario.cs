using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SASAI
{
    public partial class ABMAdministrador : Form
    {
        public ABMAdministrador()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            AccesoDatos aq = new AccesoDatos();
            string procedure = "UsuarioenUso";
            SqlCommand comando =new SqlCommand();

          if (  Usuario_class.UsuarioenUso(textBox1.Text)==1)
            {
                MessageBox.Show("Este usuario ya este en uso.");
            }


            else {
                procedure = "CrearUsuario";
                comando = new SqlCommand();

                try {
                    if (Usuario_class.CrearUsuario(ref comando, procedure, textBox1.Text, textBox2.Text, 1) == 1)
                    {
                        MessageBox.Show("Usuario Creado.");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
                    
                        }

            }
        
    }
}
