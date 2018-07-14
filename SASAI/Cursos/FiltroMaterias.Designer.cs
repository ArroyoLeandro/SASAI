namespace SASAI.Cursos
{
    partial class FiltroMaterias
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
            this.btn_filtrarM_M = new System.Windows.Forms.Button();
            this.lbl_Nombre_M = new System.Windows.Forms.Label();
            this.txt_Nombre_M = new System.Windows.Forms.TextBox();
            this.txt_ID_M = new System.Windows.Forms.TextBox();
            this.lbl_ID_M = new System.Windows.Forms.Label();
            this.txt_precio_M = new System.Windows.Forms.TextBox();
            this.lbl_Precio_M = new System.Windows.Forms.Label();
            this.rbt_Menor_Precio = new System.Windows.Forms.RadioButton();
            this.rbt_Igual_Precio = new System.Windows.Forms.RadioButton();
            this.rbt_Mayor_Precio = new System.Windows.Forms.RadioButton();
            this.grupo_Precio_M = new System.Windows.Forms.GroupBox();
            this.grupo_Precio_M.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_filtrarM_M
            // 
            this.btn_filtrarM_M.Location = new System.Drawing.Point(116, 304);
            this.btn_filtrarM_M.Name = "btn_filtrarM_M";
            this.btn_filtrarM_M.Size = new System.Drawing.Size(128, 45);
            this.btn_filtrarM_M.TabIndex = 0;
            this.btn_filtrarM_M.Text = "Aceptar";
            this.btn_filtrarM_M.UseVisualStyleBackColor = true;
            // 
            // lbl_Nombre_M
            // 
            this.lbl_Nombre_M.AutoSize = true;
            this.lbl_Nombre_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_M.Location = new System.Drawing.Point(12, 53);
            this.lbl_Nombre_M.Name = "lbl_Nombre_M";
            this.lbl_Nombre_M.Size = new System.Drawing.Size(87, 25);
            this.lbl_Nombre_M.TabIndex = 1;
            this.lbl_Nombre_M.Text = "Nombre";
            // 
            // txt_Nombre_M
            // 
            this.txt_Nombre_M.Location = new System.Drawing.Point(131, 60);
            this.txt_Nombre_M.Name = "txt_Nombre_M";
            this.txt_Nombre_M.Size = new System.Drawing.Size(188, 20);
            this.txt_Nombre_M.TabIndex = 2;
            // 
            // txt_ID_M
            // 
            this.txt_ID_M.Location = new System.Drawing.Point(131, 105);
            this.txt_ID_M.Name = "txt_ID_M";
            this.txt_ID_M.Size = new System.Drawing.Size(188, 20);
            this.txt_ID_M.TabIndex = 4;
            // 
            // lbl_ID_M
            // 
            this.lbl_ID_M.AutoSize = true;
            this.lbl_ID_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_M.Location = new System.Drawing.Point(13, 103);
            this.lbl_ID_M.Name = "lbl_ID_M";
            this.lbl_ID_M.Size = new System.Drawing.Size(83, 20);
            this.lbl_ID_M.TabIndex = 3;
            this.lbl_ID_M.Text = "ID Materia";
            // 
            // txt_precio_M
            // 
            this.txt_precio_M.Location = new System.Drawing.Point(181, 43);
            this.txt_precio_M.Name = "txt_precio_M";
            this.txt_precio_M.Size = new System.Drawing.Size(146, 20);
            this.txt_precio_M.TabIndex = 6;
            // 
            // lbl_Precio_M
            // 
            this.lbl_Precio_M.AutoSize = true;
            this.lbl_Precio_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio_M.Location = new System.Drawing.Point(6, 35);
            this.lbl_Precio_M.Name = "lbl_Precio_M";
            this.lbl_Precio_M.Size = new System.Drawing.Size(73, 25);
            this.lbl_Precio_M.TabIndex = 5;
            this.lbl_Precio_M.Text = "Precio";
            this.lbl_Precio_M.Click += new System.EventHandler(this.lbl_Precio_M_Click);
            // 
            // rbt_Menor_Precio
            // 
            this.rbt_Menor_Precio.AutoSize = true;
            this.rbt_Menor_Precio.Location = new System.Drawing.Point(108, 20);
            this.rbt_Menor_Precio.Name = "rbt_Menor_Precio";
            this.rbt_Menor_Precio.Size = new System.Drawing.Size(37, 17);
            this.rbt_Menor_Precio.TabIndex = 7;
            this.rbt_Menor_Precio.TabStop = true;
            this.rbt_Menor_Precio.Text = "<=";
            this.rbt_Menor_Precio.UseVisualStyleBackColor = true;
            // 
            // rbt_Igual_Precio
            // 
            this.rbt_Igual_Precio.AutoSize = true;
            this.rbt_Igual_Precio.Location = new System.Drawing.Point(108, 43);
            this.rbt_Igual_Precio.Name = "rbt_Igual_Precio";
            this.rbt_Igual_Precio.Size = new System.Drawing.Size(31, 17);
            this.rbt_Igual_Precio.TabIndex = 8;
            this.rbt_Igual_Precio.TabStop = true;
            this.rbt_Igual_Precio.Text = "=";
            this.rbt_Igual_Precio.UseVisualStyleBackColor = true;
            // 
            // rbt_Mayor_Precio
            // 
            this.rbt_Mayor_Precio.AutoSize = true;
            this.rbt_Mayor_Precio.Location = new System.Drawing.Point(108, 66);
            this.rbt_Mayor_Precio.Name = "rbt_Mayor_Precio";
            this.rbt_Mayor_Precio.Size = new System.Drawing.Size(37, 17);
            this.rbt_Mayor_Precio.TabIndex = 9;
            this.rbt_Mayor_Precio.TabStop = true;
            this.rbt_Mayor_Precio.Text = ">=";
            this.rbt_Mayor_Precio.UseVisualStyleBackColor = true;
            // 
            // grupo_Precio_M
            // 
            this.grupo_Precio_M.Controls.Add(this.rbt_Mayor_Precio);
            this.grupo_Precio_M.Controls.Add(this.rbt_Igual_Precio);
            this.grupo_Precio_M.Controls.Add(this.rbt_Menor_Precio);
            this.grupo_Precio_M.Controls.Add(this.txt_precio_M);
            this.grupo_Precio_M.Controls.Add(this.lbl_Precio_M);
            this.grupo_Precio_M.Location = new System.Drawing.Point(8, 155);
            this.grupo_Precio_M.Name = "grupo_Precio_M";
            this.grupo_Precio_M.Size = new System.Drawing.Size(342, 93);
            this.grupo_Precio_M.TabIndex = 10;
            this.grupo_Precio_M.TabStop = false;
            this.grupo_Precio_M.Text = "Precio";
            // 
            // FiltroMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 361);
            this.Controls.Add(this.grupo_Precio_M);
            this.Controls.Add(this.txt_ID_M);
            this.Controls.Add(this.lbl_ID_M);
            this.Controls.Add(this.txt_Nombre_M);
            this.Controls.Add(this.lbl_Nombre_M);
            this.Controls.Add(this.btn_filtrarM_M);
            this.Name = "FiltroMaterias";
            this.Text = "FiltroMaterias";
            this.Load += new System.EventHandler(this.FiltroMaterias_Load);
            this.grupo_Precio_M.ResumeLayout(false);
            this.grupo_Precio_M.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_filtrarM_M;
        private System.Windows.Forms.Label lbl_Nombre_M;
        private System.Windows.Forms.TextBox txt_Nombre_M;
        private System.Windows.Forms.TextBox txt_ID_M;
        private System.Windows.Forms.Label lbl_ID_M;
        private System.Windows.Forms.TextBox txt_precio_M;
        private System.Windows.Forms.Label lbl_Precio_M;
        private System.Windows.Forms.RadioButton rbt_Menor_Precio;
        private System.Windows.Forms.RadioButton rbt_Igual_Precio;
        private System.Windows.Forms.RadioButton rbt_Mayor_Precio;
        private System.Windows.Forms.GroupBox grupo_Precio_M;
    }
}