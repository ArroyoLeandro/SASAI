using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SASAI
{
    class DatosSP
    {




        public static void InscriptosDNI(ref SqlCommand Comando, DataRow fila)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@DNI", SqlDbType.Int);
            SqlParametros.Value = fila["DNI"];
        }

    
        public static SqlCommand Materias (string CodMateria,string NombreMateria,string monto )
        {
        
            SqlCommand Comando = new SqlCommand();
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@CodMateria", SqlDbType.NVarChar, 40);
            SqlParametros.Value = CodMateria;
            SqlParametros = Comando.Parameters.Add("@NombreMateria", SqlDbType.NVarChar, 100);
            SqlParametros.Value = NombreMateria;
            SqlParametros = Comando.Parameters.Add("@Monto", SqlDbType.Money);
            SqlParametros.Value = int.Parse(monto);
                    return Comando;
        }

        public static SqlCommand DetalleMov (string CodMov ,string Usuario ,string Antes,
                                             string Despues, DateTime fecha)
         {
            SqlCommand Comando = new SqlCommand();
             SqlParameter SqlParametros = new SqlParameter();
             SqlParametros = Comando.Parameters.Add ("@CodMov",SqlDbType.Int);
             SqlParametros.Value = CodMov;
             SqlParametros = Comando.Parameters.Add ("@Usuario",SqlDbType.NVarChar, 20);
             SqlParametros.Value = Usuario;
             SqlParametros = Comando.Parameters.Add ("@Antes",SqlDbType.NVarChar, 100);
             SqlParametros.Value = Antes;
             SqlParametros = Comando.Parameters.Add ("@Despues",SqlDbType.NVarChar, 100);
             SqlParametros.Value = Despues;
             SqlParametros = Comando.Parameters.Add ("@fecha",SqlDbType.Date);
             SqlParametros.Value = fecha;
             return Comando;
             
         }
        
        public static SqlCommand MateriasxCurso 
            (string CodMateria  ,string CodCurso  ,string CodEspecialidad )
         {
            SqlCommand Comando = new SqlCommand();
             SqlParameter SqlParametros = new SqlParameter();
             SqlParametros = Comando.Parameters.Add ("@CodMateria",SqlDbType.NVarChar,40);
             SqlParametros.Value = CodMateria;
             SqlParametros = Comando.Parameters.Add ("@CodCurso",SqlDbType.NVarChar,40);
             SqlParametros.Value = CodCurso;
             SqlParametros = Comando.Parameters.Add ("@CodEspecialidad",SqlDbType.NVarChar,40);
             SqlParametros.Value = CodEspecialidad;
                         
             return Comando;
             
         }

        public static SqlCommand Cursos
            (string CodCurso  ,string FechaInicio  ,string FechaFinal, int Nota_Min,int CapacidadMax )
         {
            SqlCommand Comando = new SqlCommand();
             SqlParameter SqlParametros = new SqlParameter();
             SqlParametros = Comando.Parameters.Add ("@CodCurso",SqlDbType.NVarChar,40);
             SqlParametros.Value = CodCurso;
             SqlParametros = Comando.Parameters.Add ("@FechaInicio",SqlDbType.Date);
             SqlParametros.Value = FechaInicio;
             SqlParametros = Comando.Parameters.Add ("@FechaFinal",SqlDbType.Date);
             SqlParametros.Value = FechaFinal;
             SqlParametros = Comando.Parameters.Add ("@Nota_Min",SqlDbType.Date);
             SqlParametros.Value = Nota_Min;
             SqlParametros = Comando.Parameters.Add ("@CapacidadMax",SqlDbType.Date);
             SqlParametros.Value = CapacidadMax;
                         
             return Comando;
             
         }
         
        public static SqlCommand EspecialidadesXCursos
             (string CodCurso  ,string CodEspecialidad  ) 
         {
            SqlCommand Comando = new SqlCommand();
             SqlParameter SqlParametros = new SqlParameter();
             SqlParametros = Comando.Parameters.Add ("@CodCurso",SqlDbType.NVarChar,40);
             SqlParametros.Value = CodCurso;
             SqlParametros = Comando.Parameters.Add ("@CodEspecialidad ",SqlDbType.Date);
             SqlParametros.Value = CodEspecialidad ;
          return Comando;
             
         }

        public static SqlCommand Especialidades
             (string nombre   ,string Codespecialidad,int AniosAprox)
         {
            SqlCommand Comando = new SqlCommand();
             SqlParameter SqlParametros = new SqlParameter();
             SqlParametros = Comando.Parameters.Add ("@Codespecialidad",SqlDbType.NVarChar,40);
             SqlParametros.Value = Codespecialidad ;
             SqlParametros = Comando.Parameters.Add ("@nombre",SqlDbType.NVarChar,40);
             SqlParametros.Value = nombre;
             SqlParametros = Comando.Parameters.Add ("@AniosAprox",SqlDbType.Int);
             SqlParametros.Value = AniosAprox;
          return Comando;
             
         }
        
         public static SqlCommand AlumnosxMateriasxCursos 
             (int DNI,string CodMateria ,string Codcurso,string CodEspecialidad, int NotaMateria )
         {
            SqlCommand Comando = new SqlCommand();
             SqlParameter SqlParametros = new SqlParameter();
          SqlParametros = Comando.Parameters.Add ("@DNI",SqlDbType.Int);
             SqlParametros.Value = DNI ;
             SqlParametros = Comando.Parameters.Add ("@CodMateria",SqlDbType.NVarChar,40);
             SqlParametros.Value = CodMateria ;
             SqlParametros = Comando.Parameters.Add ("@Codcurso",SqlDbType.NVarChar,40);
             SqlParametros.Value = Codcurso  ;
             SqlParametros = Comando.Parameters.Add ("@NotaMateria",SqlDbType.Int);
             SqlParametros.Value = NotaMateria;
          return Comando;
             
         }

        public static SqlCommand Inscriptos 
             (int DNI,string Nombre ,string Apellido, string UltimoCurso,
             string Email, string Telefono,bool Activo,bool Const_Analitico,bool Const_Cuil,
             bool Fotoc_DNI, bool Foto4x4, bool Const_Trabajo,
              DateTime FechaEntregaDoc, string observaciones             )
            
         {
            SqlCommand Comando = new SqlCommand();
             SqlParameter SqlParametros = new SqlParameter();
          SqlParametros = Comando.Parameters.Add ("@DNI",SqlDbType.Int);
             SqlParametros.Value = DNI ;
             SqlParametros = Comando.Parameters.Add ("@Nombre",SqlDbType.NVarChar,50);
             SqlParametros.Value = Nombre  ;
             SqlParametros = Comando.Parameters.Add ("@Apellido",SqlDbType.NVarChar,50);
             SqlParametros.Value = Apellido;
            SqlParametros = Comando.Parameters.Add("@UltimoCurso", SqlDbType.NVarChar, 40);
            SqlParametros.Value = UltimoCurso;
            SqlParametros = Comando.Parameters.Add("@Email", SqlDbType.NVarChar, 100);
            SqlParametros.Value = Email;
            SqlParametros = Comando.Parameters.Add ("@Telefono",SqlDbType.NVarChar,50);
             SqlParametros.Value = Telefono;
            SqlParametros = Comando.Parameters.Add("@Activo", SqlDbType.Bit);
            SqlParametros.Value = Activo;
            SqlParametros = Comando.Parameters.Add ("@Const_Analitico",SqlDbType.Bit);
             SqlParametros.Value = Const_Analitico;
          SqlParametros = Comando.Parameters.Add ("@Const_Cuil",SqlDbType.Bit);
             SqlParametros.Value = Const_Cuil;
          SqlParametros = Comando.Parameters.Add ("@Fotoc_DNI",SqlDbType.Bit);
             SqlParametros.Value = Fotoc_DNI;
          SqlParametros = Comando.Parameters.Add ("@Foto4x4",SqlDbType.Bit);
             SqlParametros.Value = Foto4x4;
          SqlParametros = Comando.Parameters.Add ("@Const_Trabajo",SqlDbType.Bit);
             SqlParametros.Value = Const_Trabajo;
          SqlParametros = Comando.Parameters.Add ("@FechaEntregaDoc",SqlDbType.Date);
             SqlParametros.Value = FechaEntregaDoc;
          SqlParametros = Comando.Parameters.Add ("@observaciones",SqlDbType.NVarChar,50);
             SqlParametros.Value = observaciones;
          
          return Comando;
             
         }


        
         public static SqlCommand Interesados 
             (string Email,string Nombre,string Apellido, DateTime FechaConsulta)
         {
         SqlCommand Comando = new SqlCommand();
             SqlParameter SqlParametros = new SqlParameter();
          SqlParametros = Comando.Parameters.Add ("@Email",SqlDbType.NVarChar, 100);
             SqlParametros.Value = Email ;
          SqlParametros = Comando.Parameters.Add ("@Nombre",SqlDbType.NVarChar, 50);
             SqlParametros.Value = Nombre ;
             SqlParametros = Comando.Parameters.Add ("@Apellido",SqlDbType.NVarChar, 50);
             SqlParametros.Value = Apellido;
             SqlParametros = Comando.Parameters.Add ("@FechaConsulta",SqlDbType.Date);
             SqlParametros.Value = FechaConsulta;
         
            return Comando;
         }
        
        public static SqlCommand Preinscriptos 
             (int DNI,string codcurso,string IDinscripto,string Nombre,string Apellido,
              string Email,string Telefono,int DNIOLD,string Turno,string Modalidad)
         {
          SqlCommand Comando = new SqlCommand();
             SqlParameter SqlParametros = new SqlParameter();
          SqlParametros = Comando.Parameters.Add ("@DNI",SqlDbType.Int);
             SqlParametros.Value = DNI;
          SqlParametros = Comando.Parameters.Add ("@codcurso",SqlDbType.NVarChar, 40);
             SqlParametros.Value = codcurso;
             SqlParametros = Comando.Parameters.Add ("@Idinscripto",SqlDbType.Int);
             SqlParametros.Value = IDinscripto;
             SqlParametros = Comando.Parameters.Add ("@Nombre",SqlDbType.NVarChar, 50);
             SqlParametros.Value = Nombre;
             SqlParametros = Comando.Parameters.Add ("@Apellido",SqlDbType.NVarChar, 50);
             SqlParametros.Value = Apellido;
             SqlParametros = Comando.Parameters.Add ("@Email",SqlDbType.NVarChar, 100);
             SqlParametros.Value = Email;
             SqlParametros = Comando.Parameters.Add ("@Telefono",SqlDbType.NVarChar, 30);
             SqlParametros.Value = Telefono;
             SqlParametros = Comando.Parameters.Add ("@DNIOLD",SqlDbType.Int);
             SqlParametros.Value = DNIOLD;
             SqlParametros = Comando.Parameters.Add ("@Turno",SqlDbType.NVarChar, 60);
             SqlParametros.Value = Turno;
             SqlParametros = Comando.Parameters.Add ("@Modalidad", SqlDbType.NVarChar, 60);
             SqlParametros.Value = Modalidad;
            SqlParametros = Comando.Parameters.Add("@usuarioactivo", SqlDbType.NVarChar, 20);
            SqlParametros.Value = Formularios.Usuario;

            return Comando;
             
         }
        
    }

    class Usuario_class
    {
        public static SqlCommand Usuarios_completo(string usuario, string contrasena, int val = 1)
        {

            SqlCommand Comando = new SqlCommand();
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@user", SqlDbType.NVarChar, 20);
            SqlParametros.Value = usuario;
            SqlParametros = Comando.Parameters.Add("@contra", SqlDbType.NVarChar, 50);
            SqlParametros.Value = contrasena;
            SqlParametros = Comando.Parameters.Add("@acceso", SqlDbType.Int);
            SqlParametros.Value = val;


            return Comando;
        }

        public static void Usuario_user (ref SqlCommand Comando,string user)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@user", SqlDbType.NVarChar, 20);
            SqlParametros.Value = user;
            
        }
        public static void Usuario_baja(ref SqlCommand Comando, int baja)
        {
            
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@baja", SqlDbType.Bit);
            SqlParametros.Value = baja;

        }
        public static void Usuario_Contrasena (ref SqlCommand Comando, string contra)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@contra", SqlDbType.NVarChar, 50);
            SqlParametros.Value = contra;

        }

        public static int ActualizarUser(string usuario, string contrasena, int val ,int baja)
        {
            SqlCommand comando = new SqlCommand();
            AccesoDatos aq = new AccesoDatos();
          comando=  Usuario_class.Usuarios_completo(usuario, contrasena, val);
            Usuario_class.Usuario_baja(ref comando, baja);
            aq.ConfigurarProcedure(ref comando, "ActualizarUsuario");
            comando.Connection = aq.ObtenerConexion();

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                if (int.Parse(reader[0].ToString()) == 1)
                {
                    return 1;
                }

            }

            return -1;
        }

        public static int UsuarioenUso(string nombreuser)
        {
            SqlCommand comando = new SqlCommand();
            AccesoDatos aq = new AccesoDatos();
            Usuario_class.Usuario_user(ref comando, nombreuser);

            aq.ConfigurarProcedure(ref comando, "UsuarioEnuso");
            comando.Connection = aq.ObtenerConexion();

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                if (int.Parse(reader[0].ToString()) == 1)
                {
                    return 1;
                }

            }
            return -1;
        }
        public static int VerificarUsuarioActivo(string nombreuser, string contrasena)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                AccesoDatos aq = new AccesoDatos();
                Usuario_user(ref comando, nombreuser);
                Usuario_Contrasena(ref comando, contrasena);


                aq.ConfigurarProcedure(ref comando, "VerificarUsuarioActivo");
                comando.Connection = aq.ObtenerConexion();

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {


                    //  MessageBox.Show( reader[0].ToString());

                    return (int.Parse(reader[0].ToString()));

                }
                return -100;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -100;
            }
        }

        public static int VerificarAlluser(string nombreuser,string contrasena)
        {
            try { 
            SqlCommand comando = new SqlCommand();
            AccesoDatos aq = new AccesoDatos();
            comando = Usuario_class.Usuarios_completo(nombreuser,contrasena,1);

            aq.ConfigurarProcedure(ref comando, "VerificarUsuario");
            comando.Connection = aq.ObtenerConexion();

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                if (int.Parse(reader[0].ToString()) != 0)
                {
                    return int.Parse(reader[0].ToString());
                }

            }
                return -1;

            }
            catch (Exception ex) {
                return -1;
            }
        }

        public static int CrearUsuario (ref SqlCommand comando, string procedure, string nombreuser,string contra,int acceso =1)
        {
            AccesoDatos aq = new AccesoDatos();

           comando= Usuario_class.Usuarios_completo(nombreuser, contra, acceso);

            aq.ConfigurarProcedure(ref comando, procedure);
            comando.Connection = aq.ObtenerConexion();

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                if (int.Parse(reader[0].ToString()) == 1)
                {
                    return 1;
                }

            }
            return -1;

        }


    }
}