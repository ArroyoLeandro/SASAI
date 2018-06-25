namespace SASAI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interesadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preinscripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadistcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaBajaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlXUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.preinscripcionToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.estadistcasToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursoActualToolStripMenuItem,
            this.todosToolStripMenuItem});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // cursoActualToolStripMenuItem
            // 
            this.cursoActualToolStripMenuItem.Name = "cursoActualToolStripMenuItem";
            this.cursoActualToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.cursoActualToolStripMenuItem.Text = "Actual";
            this.cursoActualToolStripMenuItem.Click += new System.EventHandler(this.cursoActualToolStripMenuItem_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosAlumnosToolStripMenuItem,
            this.interesadosToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // todosLosAlumnosToolStripMenuItem
            // 
            this.todosLosAlumnosToolStripMenuItem.Name = "todosLosAlumnosToolStripMenuItem";
            this.todosLosAlumnosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.todosLosAlumnosToolStripMenuItem.Text = "Todos los Alumnos";
            this.todosLosAlumnosToolStripMenuItem.Click += new System.EventHandler(this.todosLosAlumnosToolStripMenuItem_Click);
            // 
            // interesadosToolStripMenuItem
            // 
            this.interesadosToolStripMenuItem.Name = "interesadosToolStripMenuItem";
            this.interesadosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.interesadosToolStripMenuItem.Text = "Interesados";
            this.interesadosToolStripMenuItem.Click += new System.EventHandler(this.interesadosToolStripMenuItem_Click_1);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.materiasToolStripMenuItem.Text = "Materias";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // preinscripcionToolStripMenuItem
            // 
            this.preinscripcionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem});
            this.preinscripcionToolStripMenuItem.Name = "preinscripcionToolStripMenuItem";
            this.preinscripcionToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.preinscripcionToolStripMenuItem.Text = "Preinscripcion";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportarToolStripMenuItem.Text = "Importar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioDeContraseñaToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cambioDeContraseñaToolStripMenuItem
            // 
            this.cambioDeContraseñaToolStripMenuItem.Name = "cambioDeContraseñaToolStripMenuItem";
            this.cambioDeContraseñaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.cambioDeContraseñaToolStripMenuItem.Text = "Cambio de Contraseña";
            this.cambioDeContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambioDeContraseñaToolStripMenuItem_Click);
            // 
            // estadistcasToolStripMenuItem
            // 
            this.estadistcasToolStripMenuItem.Name = "estadistcasToolStripMenuItem";
            this.estadistcasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadistcasToolStripMenuItem.Text = "Estadisticas";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaBajaUsuarioToolStripMenuItem,
            this.controlXUsuarioToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // cargaBajaUsuarioToolStripMenuItem
            // 
            this.cargaBajaUsuarioToolStripMenuItem.Name = "cargaBajaUsuarioToolStripMenuItem";
            this.cargaBajaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cargaBajaUsuarioToolStripMenuItem.Text = "ABM USUARIOS";
            // 
            // controlXUsuarioToolStripMenuItem
            // 
            this.controlXUsuarioToolStripMenuItem.Name = "controlXUsuarioToolStripMenuItem";
            this.controlXUsuarioToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.controlXUsuarioToolStripMenuItem.Text = "Control x Usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 660);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoActualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preinscripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadistcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaBajaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlXUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interesadosToolStripMenuItem;
    }
}

