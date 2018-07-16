namespace SASAI
{
    partial class Alta_Especialidad
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
            this.btn_altaEspecialidad = new System.Windows.Forms.Button();
            this.lbl_precio_M_Alta = new System.Windows.Forms.Label();
            this.lbl_nombre_M_Alta = new System.Windows.Forms.Label();
            this.txb_NombreE = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_altaEspecialidad
            // 
            this.btn_altaEspecialidad.Location = new System.Drawing.Point(99, 129);
            this.btn_altaEspecialidad.Name = "btn_altaEspecialidad";
            this.btn_altaEspecialidad.Size = new System.Drawing.Size(157, 32);
            this.btn_altaEspecialidad.TabIndex = 24;
            this.btn_altaEspecialidad.Text = "Crear Especialidad: ";
            this.btn_altaEspecialidad.UseVisualStyleBackColor = true;
            this.btn_altaEspecialidad.Click += new System.EventHandler(this.btn_altaEspecialidad_Click_1);
            // 
            // lbl_precio_M_Alta
            // 
            this.lbl_precio_M_Alta.AutoSize = true;
            this.lbl_precio_M_Alta.Location = new System.Drawing.Point(96, 69);
            this.lbl_precio_M_Alta.Name = "lbl_precio_M_Alta";
            this.lbl_precio_M_Alta.Size = new System.Drawing.Size(71, 13);
            this.lbl_precio_M_Alta.TabIndex = 23;
            this.lbl_precio_M_Alta.Text = "Duracion:   ->";
            // 
            // lbl_nombre_M_Alta
            // 
            this.lbl_nombre_M_Alta.AutoSize = true;
            this.lbl_nombre_M_Alta.Location = new System.Drawing.Point(25, 34);
            this.lbl_nombre_M_Alta.Name = "lbl_nombre_M_Alta";
            this.lbl_nombre_M_Alta.Size = new System.Drawing.Size(142, 13);
            this.lbl_nombre_M_Alta.TabIndex = 21;
            this.lbl_nombre_M_Alta.Text = "Nombre de la Especialidad->";
            // 
            // txb_NombreE
            // 
            this.txb_NombreE.Location = new System.Drawing.Point(173, 31);
            this.txb_NombreE.Name = "txb_NombreE";
            this.txb_NombreE.Size = new System.Drawing.Size(133, 20);
            this.txb_NombreE.TabIndex = 20;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(186, 67);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown1.TabIndex = 25;
            // 
            // Alta_Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 206);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_altaEspecialidad);
            this.Controls.Add(this.lbl_precio_M_Alta);
            this.Controls.Add(this.lbl_nombre_M_Alta);
            this.Controls.Add(this.txb_NombreE);
            this.Name = "Alta_Especialidad";
            this.Text = "Alta_Especialidad";
            this.Load += new System.EventHandler(this.Alta_Especialidad_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_altaEspecialidad;
        private System.Windows.Forms.Label lbl_precio_M_Alta;
        private System.Windows.Forms.Label lbl_nombre_M_Alta;
        private System.Windows.Forms.TextBox txb_NombreE;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}