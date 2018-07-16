namespace SASAI
{
    partial class Especialidad_F
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
            this.txt_ID_E = new System.Windows.Forms.TextBox();
            this.lbl_ID_M = new System.Windows.Forms.Label();
            this.txt_Nombre_E = new System.Windows.Forms.TextBox();
            this.lbl_Nombre_M = new System.Windows.Forms.Label();
            this.btn_filtrarM_M = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ID_E
            // 
            this.txt_ID_E.Location = new System.Drawing.Point(176, 81);
            this.txt_ID_E.Name = "txt_ID_E";
            this.txt_ID_E.Size = new System.Drawing.Size(188, 20);
            this.txt_ID_E.TabIndex = 27;
            // 
            // lbl_ID_M
            // 
            this.lbl_ID_M.AutoSize = true;
            this.lbl_ID_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_M.Location = new System.Drawing.Point(21, 81);
            this.lbl_ID_M.Name = "lbl_ID_M";
            this.lbl_ID_M.Size = new System.Drawing.Size(149, 20);
            this.lbl_ID_M.TabIndex = 26;
            this.lbl_ID_M.Text = "ID ESPECIALIDAD";
            // 
            // txt_Nombre_E
            // 
            this.txt_Nombre_E.Location = new System.Drawing.Point(176, 36);
            this.txt_Nombre_E.Name = "txt_Nombre_E";
            this.txt_Nombre_E.Size = new System.Drawing.Size(188, 20);
            this.txt_Nombre_E.TabIndex = 25;
            // 
            // lbl_Nombre_M
            // 
            this.lbl_Nombre_M.AutoSize = true;
            this.lbl_Nombre_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_M.Location = new System.Drawing.Point(83, 31);
            this.lbl_Nombre_M.Name = "lbl_Nombre_M";
            this.lbl_Nombre_M.Size = new System.Drawing.Size(87, 25);
            this.lbl_Nombre_M.TabIndex = 24;
            this.lbl_Nombre_M.Text = "Nombre";
            // 
            // btn_filtrarM_M
            // 
            this.btn_filtrarM_M.Location = new System.Drawing.Point(120, 164);
            this.btn_filtrarM_M.Name = "btn_filtrarM_M";
            this.btn_filtrarM_M.Size = new System.Drawing.Size(128, 45);
            this.btn_filtrarM_M.TabIndex = 23;
            this.btn_filtrarM_M.Text = "Aceptar";
            this.btn_filtrarM_M.UseVisualStyleBackColor = true;
            this.btn_filtrarM_M.Click += new System.EventHandler(this.btn_filtrarM_M_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "DURACION";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(201, 119);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 29;
            // 
            // Especialidad_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 224);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ID_E);
            this.Controls.Add(this.lbl_ID_M);
            this.Controls.Add(this.txt_Nombre_E);
            this.Controls.Add(this.lbl_Nombre_M);
            this.Controls.Add(this.btn_filtrarM_M);
            this.Name = "Especialidad_F";
            this.Text = "Especialidad_F";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ID_E;
        private System.Windows.Forms.Label lbl_ID_M;
        private System.Windows.Forms.TextBox txt_Nombre_E;
        private System.Windows.Forms.Label lbl_Nombre_M;
        private System.Windows.Forms.Button btn_filtrarM_M;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}