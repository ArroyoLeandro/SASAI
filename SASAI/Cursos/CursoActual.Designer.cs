namespace SASAI
{
    partial class CursoActual
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
            this.lb_NombreCurso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_FechaInicio = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_FechaFinal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_NombreCurso
            // 
            this.lb_NombreCurso.AutoSize = true;
            this.lb_NombreCurso.Location = new System.Drawing.Point(11, 23);
            this.lb_NombreCurso.Name = "lb_NombreCurso";
            this.lb_NombreCurso.Size = new System.Drawing.Size(77, 13);
            this.lb_NombreCurso.TabIndex = 0;
            this.lb_NombreCurso.Text = "Nombre Curso:";
            this.lb_NombreCurso.Click += new System.EventHandler(this.lb_NombreCurso_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar Datos Curso";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_FechaInicio
            // 
            this.lb_FechaInicio.AutoSize = true;
            this.lb_FechaInicio.Location = new System.Drawing.Point(11, 51);
            this.lb_FechaInicio.Name = "lb_FechaInicio";
            this.lb_FechaInicio.Size = new System.Drawing.Size(66, 13);
            this.lb_FechaInicio.TabIndex = 3;
            this.lb_FechaInicio.Text = "Fecha Incio:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(591, 216);
            this.dataGridView1.TabIndex = 5;
            // 
            // lb_FechaFinal
            // 
            this.lb_FechaFinal.AutoSize = true;
            this.lb_FechaFinal.Location = new System.Drawing.Point(12, 79);
            this.lb_FechaFinal.Name = "lb_FechaFinal";
            this.lb_FechaFinal.Size = new System.Drawing.Size(65, 13);
            this.lb_FechaFinal.TabIndex = 4;
            this.lb_FechaFinal.Text = "Fecha Final:";
            this.lb_FechaFinal.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alumnos";
            // 
            // CursoActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_FechaFinal);
            this.Controls.Add(this.lb_FechaInicio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_NombreCurso);
            this.Name = "CursoActual";
            this.Text = "Curso Actual (Poner nombre del curso en este lugar)";
            this.Load += new System.EventHandler(this.CursoActual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_NombreCurso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_FechaInicio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_FechaFinal;
        private System.Windows.Forms.Label label4;
    }
}