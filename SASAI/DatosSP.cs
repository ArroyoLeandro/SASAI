using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SASAI
{
    class DatosSP
    {


        public static SqlCommand Usuarios(string usuario, string contrasena, string acceso = "1")
        {

            SqlCommand Comando = new SqlCommand();
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@user", SqlDbType.NVarChar, 20);
            SqlParametros.Value = usuario;
            SqlParametros = Comando.Parameters.Add("@contra", SqlDbType.NVarChar, 20);
            SqlParametros.Value = contrasena;
            SqlParametros = Comando.Parameters.Add("@acceso", SqlDbType.Int);
            SqlParametros.Value = int.Parse(acceso);


            return Comando;
        }

        public static void Inscriptos(ref SqlCommand Comando, DataRow fila)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@DNI", SqlDbType.Int);
            SqlParametros.Value = fila["DNI"];
        }

    }
}
