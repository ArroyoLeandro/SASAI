using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace SASAI
{
    class Registros
    {
       static public void CargarDetalle()
        {
           /* create table DetalleMov(
CodMov int not null,
Usuario varchar(20) not null,
Antes varchar(100) not null,
Despues varchar(100) not null,
fecha date not null
constraint pk_claveDetalleMov primary key(codmov, Usuario, fecha)
*/


        }
        static public void CargarMovimiento(string TablaModificada,string NombredeldatoModificado,string antes, string despues)
        {
            try { 

            AccesoDatos conexion = new AccesoDatos();

            string user = Formularios.Usuario;
            SqlCommand comando = new SqlCommand();

           
            comando = DatosSP.Movimientos(user, TablaModificada, NombredeldatoModificado,antes,despues);
            conexion.ConfigurarProcedure(ref comando, "CargaMovimiento");
            comando.Connection = conexion.ObtenerConexion();

            SqlDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {

                if (int.Parse(reader[0].ToString()) == 1)
                {
                   
                }

            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
        /*create table Movimientos(
CodMov int not null,
Usuario varchar (20) not null,
tablaModificada varchar (60) not null,
DatoModificado varchar (80) not null ,
fecha date not null
)
*/

    }

