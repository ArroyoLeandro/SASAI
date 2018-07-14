namespace SASAI.Cursos
{
    partial class AltaMaterias
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
            this.btn_altaMateria = new System.Windows.Forms.Button();
            this.lbl_precio_M_Alta = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_nombre_M_Alta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_altaMateria
            // 
            this.btn_altaMateria.Location = new System.Drawing.Point(72, 103);
            this.btn_altaMateria.Name = "btn_altaMateria";
            this.btn_altaMateria.Size = new System.Drawing.Size(157, 32);
            this.btn_altaMateria.TabIndex = 9;
            this.btn_altaMateria.Text = "Crear Materia";
            this.btn_altaMateria.UseVisualStyleBackColor = true;
            // 
            // lbl_precio_M_Alta
            // 
            this.lbl_precio_M_Alta.AutoSize = true;
            this.lbl_precio_M_Alta.Location = new System.Drawing.Point(1, 58);
            this.lbl_precio_M_Alta.Name = "lbl_precio_M_Alta";
            this.lbl_precio_M_Alta.Size = new System.Drawing.Size(116, 13);
            this.lbl_precio_M_Alta.TabIndex = 8;
            this.lbl_precio_M_Alta.Text = "Precio de la Materia  ->";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 7;
            // 
            // lbl_nombre_M_Alta
            // 
            this.lbl_nombre_M_Alta.AutoSize = true;
            this.lbl_nombre_M_Alta.Location = new System.Drawing.Point(1, 23);
            this.lbl_nombre_M_Alta.Name = "lbl_nombre_M_Alta";
            this.lbl_nombre_M_Alta.Size = new System.Drawing.Size(120, 13);
            this.lbl_nombre_M_Alta.TabIndex = 6;
            this.lbl_nombre_M_Alta.Text = "Nombre de la Materia ->";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 5;
            // 
            // AltaMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 164);
            this.Controls.Add(this.btn_altaMateria);
            this.Controls.Add(this.lbl_precio_M_Alta);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_nombre_M_Alta);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaMaterias";
            this.Text = "AltaMaterias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_altaMateria;
        private System.Windows.Forms.Label lbl_precio_M_Alta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_nombre_M_Alta;
        private System.Windows.Forms.TextBox textBox1;
    }
}