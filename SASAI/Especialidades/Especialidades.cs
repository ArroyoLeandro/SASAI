﻿using System;
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
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
        }
        public static String Variable;

        private void cargarGrid()
        {
            AccesoDatos aq = new AccesoDatos();
            DataSet ds = new DataSet();


            try
            {

                string consulta = "select Codespecialidad as CODIGO, nombre as NOMBRE,AniosAprox as DURACION from Especialidades";
                ListadoEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                aq.cargaTabla("Especialidades", consulta, ref ds);
                ListadoEspecialidades.DataSource = ds.Tables["Especialidades"];


            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }


        private void Especialidades_Load(object sender, EventArgs e)
        {
            ListadoEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            cargarGrid();
            try
            {
                txb_ID_E.Text = ListadoEspecialidades.Rows[0].Cells[0].Value.ToString();
                txb_NOMBRE_E.Text = ListadoEspecialidades.Rows[0].Cells[1].Value.ToString();
                numericUpDown1.Text = ListadoEspecialidades.Rows[0].Cells[2].Value.ToString();
               
            }
            catch (Exception) { }

            
            //MessageBox.Show(numero.ToString());
        }

        private void btn_Modificar_E_Click(object sender, EventArgs e)
        {
            AccesoDatos aq = new AccesoDatos();
            SqlCommand comando = new SqlCommand();

            try
            {

                int numero = int.Parse(numericUpDown1.Value.ToString());
                comando = DatosSP.Especialidades(txb_NOMBRE_E.Text,txb_ID_E.Text,numero);
                aq.EjecutarProcedimientoAlmacenado(comando, "EspecialidadModificar");
                cargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ListadoEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            string CantidadFilas = ListadoEspecialidades.Rows.Count.ToString();
            int cant = Convert.ToInt32(CantidadFilas.ToString());
            cant = cant - 1;

            //MessageBox.Show(CantidadFilas);
            //MessageBox.Show(cant.ToString());
            // cargo en la texbox desde la tabla datagrid
            int i = 0;

            for (i = 0; i < cant; i++)
            {
                if (ListadoEspecialidades.Rows[i].Selected == true)
                {
                    txb_ID_E.Text = ListadoEspecialidades.Rows[i].Cells[0].Value.ToString();
                    txb_NOMBRE_E.Text = ListadoEspecialidades.Rows[i].Cells[1].Value.ToString();
                    numericUpDown1.Text = ListadoEspecialidades.Rows[i].Cells[2].Value.ToString();
                }
            }


        }

        private void btn_Agregar_E_Click(object sender, EventArgs e)
        {
            string CantidadFilas = ListadoEspecialidades.Rows.Count.ToString();
            int cant = Convert.ToInt32(CantidadFilas.ToString());
            cant = cant - 1;

            Variable = cant.ToString();

            Formularios.AbrirFormularioHijos(new Alta_Especialidad());
            cargarGrid();
        }

        private void btn_Filtrar_E_Click(object sender, EventArgs e)
        {
            string consulta = "";
            Especialidad_F f = new Especialidad_F();
            if (f.ShowDialog() == DialogResult.OK)
            {
                consulta = f.consulta;

            }
            //MessageBox.Show(consulta);
            try
            {
                AccesoDatos aq = new AccesoDatos();
                DataSet ds = new DataSet();
                aq.cargaTabla("Especialidades", consulta, ref ds);
                ListadoEspecialidades.DataSource = ds.Tables["Especialidades"];
            }
            catch (Exception) { }
        }
    }
}
