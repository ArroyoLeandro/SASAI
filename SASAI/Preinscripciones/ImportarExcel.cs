using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Office.Interop;


namespace SASAI
{
    public partial class ImportarExcel : Form
    {
        
        public ImportarExcel()
        {
            InitializeComponent();
        }

        private void LLenarGrid(string archivo, string hoja)
        {
            //declaramos las variables         
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            string consultaHojaExcel = "Select *" +
                " from [" + hoja + "$]";
           //      NRO. INSC.,FECHA INSC.,INSTANCIA,CARRERA,ANEXO,MODALIDAD,TURNO,APELLIDO,NOMBRE,TIPO DOC.,NRO. DOC.

            //esta cadena es para archivos excel 2007 y 2010
            // string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";
            //    string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Excel 12.0 xml;HDR=No;IMEX=1;Readonly=True;";
            //para archivos de 97-2003 usar la siguiente cadena
            
            string cadenaConexionArchivoExcel = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + archivo + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                        //  conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                        
            //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer
            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer");
            }
            else
            {
                try
                {
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                    dataAdapter.Fill(dataSet, hoja);//llenamos el dataset
                    dataGridView1.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                    conexion.Close();//cerramos la conexion
                    dataGridView1.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega
                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja "+ex);
                }
            }
        }
        

        
        private void button1_Click(object sender, EventArgs e)
        {
            //creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
                                                                             //solo los archivos excel

            dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

            dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

            //si al seleccionar el archivo damos Ok
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //el nombre del archivo sera asignado al textbox

                string hoja = "Todas"; //la variable hoja tendra el valor del textbox donde colocamos el nombre de la hoja
                LLenarGrid(dialog.FileName, hoja); //se manda a llamar al metodo
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
               
            }
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.AllowUserToResizeRows = true;
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Preinscripciones.Confirmacion conf = new Preinscripciones.Confirmacion();
            int registros_ok = 0;
            if (conf.ShowDialog()==DialogResult.OK)
           { 

            AccesoDatos aq = new AccesoDatos();
            SqlCommand comando = new SqlCommand();

            
           
           
           
            for (int i =0; i<dataGridView1.Rows.Count; i++) { 
            try { comando = DatosSP.Preinscriptos(int.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()), "MAYO 2018", "0",
             dataGridView1.Rows[i].Cells[8].Value.ToString(), dataGridView1.Rows[i].Cells[7].Value.ToString(),
             dataGridView1.Rows[i].Cells[12].Value.ToString(), dataGridView1.Rows[i].Cells[11].Value.ToString(),
             0, dataGridView1.Rows[i].Cells[6].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString()
            );

                        registros_ok++;
                        aq.EjecutarProcedimientoAlmacenado(comando, "CargaPreinscripto");

                       
                }
                catch (Exception ex) {
                     //   MessageBox.Show(ex.ToString());
                }
                            }

            MessageBox.Show("Registros cargados correctamente: " + registros_ok );
               
                    Registros.CargarMovimiento("Preinscripciones", "Carga de Preinscripciones", "Carga de Preinscripciones completo", DateTime.Now.ToString());
                

            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            try { 
            for (int j = 11; j < dataGridView1.Columns.Count; j++)
            {
                dataGridView1.Columns[j].Visible = false;
            }
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[20].Visible = true;
            dataGridView1.Columns[19].Visible = true;
            }
            catch (Exception ex) {

            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            try { 
             for (int j = 11; j < dataGridView1.Columns.Count; j++)
                {
                dataGridView1.Columns[j].Visible = true;
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = true;
             }
            }

        
            catch (Exception ex) {

            }

        }

        private void ImportarExcel_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.Height = this.Height - 150;

        }

        private void ImportarExcel_Load(object sender, EventArgs e)
        {

        }
    }
}
