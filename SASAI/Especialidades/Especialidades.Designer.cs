namespace SASAI
{
    partial class Especialidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_Especialidad = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txb_NOMBRE_E = new System.Windows.Forms.TextBox();
            this.txb_ID_E = new System.Windows.Forms.TextBox();
            this.lbl_DURACION_E = new System.Windows.Forms.Label();
            this.lbl_NOMBRE_E = new System.Windows.Forms.Label();
            this.lbl_ID_E = new System.Windows.Forms.Label();
            this.btn_Agregar_E = new System.Windows.Forms.Button();
            this.btn_Filtrar_E = new System.Windows.Forms.Button();
            this.btn_Modificar_E = new System.Windows.Forms.Button();
            this.ListadoEspecialidades = new System.Windows.Forms.DataGridView();
            this.grp_Especialidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Especialidad
            // 
            this.grp_Especialidad.AutoSize = true;
            this.grp_Especialidad.Controls.Add(this.numericUpDown1);
            this.grp_Especialidad.Controls.Add(this.txb_NOMBRE_E);
            this.grp_Especialidad.Controls.Add(this.txb_ID_E);
            this.grp_Especialidad.Controls.Add(this.lbl_DURACION_E);
            this.grp_Especialidad.Controls.Add(this.lbl_NOMBRE_E);
            this.grp_Especialidad.Controls.Add(this.lbl_ID_E);
            this.grp_Especialidad.Controls.Add(this.btn_Agregar_E);
            this.grp_Especialidad.Controls.Add(this.btn_Filtrar_E);
            this.grp_Especialidad.Controls.Add(this.btn_Modificar_E);
            this.grp_Especialidad.Location = new System.Drawing.Point(12, 12);
            this.grp_Especialidad.Name = "grp_Especialidad";
            this.grp_Especialidad.Size = new System.Drawing.Size(553, 203);
            this.grp_Especialidad.TabIndex = 17;
            this.grp_Especialidad.TabStop = false;
            this.grp_Especialidad.Text = "Especialidades: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(460, 65);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // txb_NOMBRE_E
            // 
            this.txb_NOMBRE_E.Location = new System.Drawing.Point(131, 65);
            this.txb_NOMBRE_E.Name = "txb_NOMBRE_E";
            this.txb_NOMBRE_E.Size = new System.Drawing.Size(278, 20);
            this.txb_NOMBRE_E.TabIndex = 9;
            // 
            // txb_ID_E
            // 
            this.txb_ID_E.Enabled = false;
            this.txb_ID_E.Location = new System.Drawing.Point(21, 65);
            this.txb_ID_E.Name = "txb_ID_E";
            this.txb_ID_E.Size = new System.Drawing.Size(72, 20);
            this.txb_ID_E.TabIndex = 8;
            // 
            // lbl_DURACION_E
            // 
            this.lbl_DURACION_E.AutoSize = true;
            this.lbl_DURACION_E.Location = new System.Drawing.Point(461, 35);
            this.lbl_DURACION_E.Name = "lbl_DURACION_E";
            this.lbl_DURACION_E.Size = new System.Drawing.Size(56, 13);
            this.lbl_DURACION_E.TabIndex = 7;
            this.lbl_DURACION_E.Text = "Duracion: ";
            // 
            // lbl_NOMBRE_E
            // 
            this.lbl_NOMBRE_E.AutoSize = true;
            this.lbl_NOMBRE_E.Location = new System.Drawing.Point(194, 35);
            this.lbl_NOMBRE_E.Name = "lbl_NOMBRE_E";
            this.lbl_NOMBRE_E.Size = new System.Drawing.Size(134, 13);
            this.lbl_NOMBRE_E.TabIndex = 6;
            this.lbl_NOMBRE_E.Text = "NOMBRE ESPECIALIDAD";
            // 
            // lbl_ID_E
            // 
            this.lbl_ID_E.AutoSize = true;
            this.lbl_ID_E.Location = new System.Drawing.Point(18, 35);
            this.lbl_ID_E.Name = "lbl_ID_E";
            this.lbl_ID_E.Size = new System.Drawing.Size(87, 13);
            this.lbl_ID_E.TabIndex = 5;
            this.lbl_ID_E.Text = "ID Especialidad: ";
            // 
            // btn_Agregar_E
            // 
            this.btn_Agregar_E.Location = new System.Drawing.Point(21, 146);
            this.btn_Agregar_E.Name = "btn_Agregar_E";
            this.btn_Agregar_E.Size = new System.Drawing.Size(141, 38);
            this.btn_Agregar_E.TabIndex = 1;
            this.btn_Agregar_E.Text = "Agregar Especialidad";
            this.btn_Agregar_E.UseVisualStyleBackColor = true;
            this.btn_Agregar_E.Click += new System.EventHandler(this.btn_Agregar_E_Click);
            // 
            // btn_Filtrar_E
            // 
            this.btn_Filtrar_E.Location = new System.Drawing.Point(197, 146);
            this.btn_Filtrar_E.Name = "btn_Filtrar_E";
            this.btn_Filtrar_E.Size = new System.Drawing.Size(141, 38);
            this.btn_Filtrar_E.TabIndex = 3;
            this.btn_Filtrar_E.Text = "Filtrar";
            this.btn_Filtrar_E.UseVisualStyleBackColor = true;
            this.btn_Filtrar_E.Click += new System.EventHandler(this.btn_Filtrar_E_Click);
            // 
            // btn_Modificar_E
            // 
            this.btn_Modificar_E.Location = new System.Drawing.Point(393, 146);
            this.btn_Modificar_E.Name = "btn_Modificar_E";
            this.btn_Modificar_E.Size = new System.Drawing.Size(141, 38);
            this.btn_Modificar_E.TabIndex = 2;
            this.btn_Modificar_E.Text = "Modificar Especialidad: ";
            this.btn_Modificar_E.UseVisualStyleBackColor = true;
            this.btn_Modificar_E.Click += new System.EventHandler(this.btn_Modificar_E_Click);
            // 
            // ListadoEspecialidades
            // 
            this.ListadoEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoEspecialidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListadoEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoEspecialidades.Location = new System.Drawing.Point(12, 235);
            this.ListadoEspecialidades.MultiSelect = false;
            this.ListadoEspecialidades.Name = "ListadoEspecialidades";
            this.ListadoEspecialidades.ReadOnly = true;
            this.ListadoEspecialidades.Size = new System.Drawing.Size(553, 183);
            this.ListadoEspecialidades.TabIndex = 16;
            this.ListadoEspecialidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoEspecialidades_CellContentClick);
            // 
            // Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 448);
            this.Controls.Add(this.grp_Especialidad);
            this.Controls.Add(this.ListadoEspecialidades);
            this.Name = "Especialidades";
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.Especialidades_Load);
            this.grp_Especialidad.ResumeLayout(false);
            this.grp_Especialidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEspecialidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Especialidad;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txb_NOMBRE_E;
        private System.Windows.Forms.TextBox txb_ID_E;
        private System.Windows.Forms.Label lbl_DURACION_E;
        private System.Windows.Forms.Label lbl_NOMBRE_E;
        private System.Windows.Forms.Label lbl_ID_E;
        private System.Windows.Forms.Button btn_Agregar_E;
        private System.Windows.Forms.Button btn_Filtrar_E;
        private System.Windows.Forms.Button btn_Modificar_E;
        private System.Windows.Forms.DataGridView ListadoEspecialidades;
    }
}