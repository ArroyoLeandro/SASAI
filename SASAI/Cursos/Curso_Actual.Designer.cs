namespace SASAI
{
    partial class Curso_Actual
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_FechaFinal = new System.Windows.Forms.Label();
            this.lb_FechaInicio = new System.Windows.Forms.Label();
            this.lb_NombreCurso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alumnos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(591, 216);
            this.dataGridView1.TabIndex = 11;
            // 
            // lb_FechaFinal
            // 
            this.lb_FechaFinal.AutoSize = true;
            this.lb_FechaFinal.Location = new System.Drawing.Point(9, 78);
            this.lb_FechaFinal.Name = "lb_FechaFinal";
            this.lb_FechaFinal.Size = new System.Drawing.Size(65, 13);
            this.lb_FechaFinal.TabIndex = 10;
            this.lb_FechaFinal.Text = "Fecha Final:";
            // 
            // lb_FechaInicio
            // 
            this.lb_FechaInicio.AutoSize = true;
            this.lb_FechaInicio.Location = new System.Drawing.Point(8, 50);
            this.lb_FechaInicio.Name = "lb_FechaInicio";
            this.lb_FechaInicio.Size = new System.Drawing.Size(66, 13);
            this.lb_FechaInicio.TabIndex = 9;
            this.lb_FechaInicio.Text = "Fecha Incio:";
            // 
            // lb_NombreCurso
            // 
            this.lb_NombreCurso.AutoSize = true;
            this.lb_NombreCurso.Location = new System.Drawing.Point(8, 22);
            this.lb_NombreCurso.Name = "lb_NombreCurso";
            this.lb_NombreCurso.Size = new System.Drawing.Size(77, 13);
            this.lb_NombreCurso.TabIndex = 7;
            this.lb_NombreCurso.Text = "Nombre Curso:";
            // 
            // Curso_Actual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_FechaFinal);
            this.Controls.Add(this.lb_FechaInicio);
            this.Controls.Add(this.lb_NombreCurso);
            this.Name = "Curso_Actual";
            this.Text = "Curso_Actual";
            this.Load += new System.EventHandler(this.Curso_Actual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_FechaFinal;
        private System.Windows.Forms.Label lb_FechaInicio;
        private System.Windows.Forms.Label lb_NombreCurso;
    }
}