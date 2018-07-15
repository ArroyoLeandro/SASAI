﻿using System;
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
using Microsoft.Office.Interop;

namespace SASAI
{
    public partial class BajaPreinscriptos : Form
    {
        public BajaPreinscriptos()
        {
            InitializeComponent();
        }

        private void BajaPreinscriptos_Load(object sender, EventArgs e)
        {
            AccesoDatos aq = new AccesoDatos();
            DataSet ds = new DataSet();
            string consulta = "select * from preinscriptos";
            aq.cargaTabla("Preinscriptos", consulta, ref ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[10].Visible = false;

            for (int i = 0; i < dataGridView1.Columns.Count; i++) { 
                dataGridView1.Columns[i].ReadOnly =true;

            }
            dataGridView1.Columns[11].ReadOnly = false;

        }
        


        private void BajaPreinscriptos_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.Height = this.Height - 150;
            dataGridView1.Width = this.Width -40;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            AccesoDatos aq = new AccesoDatos();
            int aux=0;
            for (int i = 0; i < dataGridView1.RowCount; i++) {

                  MessageBox.Show(dataGridView1.Rows[i].Cells[11].Value.ToString());


                if (dataGridView1.Rows[i].Cells[11].Value.ToString()== "True")
                {
                     aux = 1;
                }
                else { aux = 0; }

               string consulta = "update dbo.Preinscriptos  set baja ="+aux +" where DNI ="+ dataGridView1.Rows[i].Cells[0].Value;

               aq.cargaTabla("asd", consulta, ref ds);


            }
        }
    }
}
