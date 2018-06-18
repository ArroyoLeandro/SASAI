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
using System.Data;

namespace SASAI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            GestionSql.Usuario_SP("mariano", "pt", "EliminarUsuario");
            
         //   SqlDataReader dr = Comando.ExecuteReader();
          //  dr.Read();
          //  MessageBox.Show(dr[0].ToString());

           

            
        }
    }
}
