namespace SASAI
{
    partial class ListadosPreinscriptos_E_Inscriptos
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
            this.btn_flt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_verde = new System.Windows.Forms.RadioButton();
            this.chk_rojo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_flt
            // 
            this.btn_flt.Location = new System.Drawing.Point(80, 65);
            this.btn_flt.Name = "btn_flt";
            this.btn_flt.Size = new System.Drawing.Size(82, 27);
            this.btn_flt.TabIndex = 2;
            this.btn_flt.Text = "Filtrar";
            this.btn_flt.UseVisualStyleBackColor = true;
            this.btn_flt.Click += new System.EventHandler(this.btn_flt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(12, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 206);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_rojo);
            this.groupBox1.Controls.Add(this.chk_verde);
            this.groupBox1.Controls.Add(this.btn_flt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rojo = Preinscriptos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Verde = Preinscriptos + Inscriptos";
            // 
            // chk_verde
            // 
            this.chk_verde.AutoSize = true;
            this.chk_verde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_verde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_verde.ForeColor = System.Drawing.Color.Lime;
            this.chk_verde.Location = new System.Drawing.Point(86, 19);
            this.chk_verde.Name = "chk_verde";
            this.chk_verde.Size = new System.Drawing.Size(57, 17);
            this.chk_verde.TabIndex = 3;
            this.chk_verde.TabStop = true;
            this.chk_verde.Text = "Verde";
            this.chk_verde.UseVisualStyleBackColor = true;
            // 
            // chk_rojo
            // 
            this.chk_rojo.AutoSize = true;
            this.chk_rojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_rojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_rojo.ForeColor = System.Drawing.Color.Red;
            this.chk_rojo.Location = new System.Drawing.Point(87, 40);
            this.chk_rojo.Name = "chk_rojo";
            this.chk_rojo.Size = new System.Drawing.Size(50, 17);
            this.chk_rojo.TabIndex = 4;
            this.chk_rojo.TabStop = true;
            this.chk_rojo.Text = "Rojo";
            this.chk_rojo.UseVisualStyleBackColor = true;
            // 
            // ListadosPreinscriptos_E_Inscriptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListadosPreinscriptos_E_Inscriptos";
            this.Text = "ListadosPreinscriptos_E_Inscriptos";
            this.Load += new System.EventHandler(this.ListadosPreinscriptos_E_Inscriptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_flt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton chk_rojo;
        private System.Windows.Forms.RadioButton chk_verde;
    }
}