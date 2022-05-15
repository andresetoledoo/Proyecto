
namespace Proyecto
{
    partial class Interfaz
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adopciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.OldLace;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem,
            this.adopciónToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.gestionarEmpleadosToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 98);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1695, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAnimalToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.modificarDatosAnimalToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(95, 33);
            this.accionesToolStripMenuItem.Text = "Animal";
            // 
            // registrarAnimalToolStripMenuItem
            // 
            this.registrarAnimalToolStripMenuItem.Name = "registrarAnimalToolStripMenuItem";
            this.registrarAnimalToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.registrarAnimalToolStripMenuItem.Text = "Alta animal";
            this.registrarAnimalToolStripMenuItem.Click += new System.EventHandler(this.registrarAnimalToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.consultarToolStripMenuItem.Text = "Baja animal";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // modificarDatosAnimalToolStripMenuItem
            // 
            this.modificarDatosAnimalToolStripMenuItem.Name = "modificarDatosAnimalToolStripMenuItem";
            this.modificarDatosAnimalToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.modificarDatosAnimalToolStripMenuItem.Text = "Modificar datos animal";
            this.modificarDatosAnimalToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosAnimalToolStripMenuItem_Click);
            // 
            // adopciónToolStripMenuItem
            // 
            this.adopciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaAnimalToolStripMenuItem});
            this.adopciónToolStripMenuItem.Name = "adopciónToolStripMenuItem";
            this.adopciónToolStripMenuItem.Size = new System.Drawing.Size(120, 33);
            this.adopciónToolStripMenuItem.Text = "Adopción";
            // 
            // consultaAnimalToolStripMenuItem
            // 
            this.consultaAnimalToolStripMenuItem.Name = "consultaAnimalToolStripMenuItem";
            this.consultaAnimalToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.consultaAnimalToolStripMenuItem.Text = "Consulta animal";
            this.consultaAnimalToolStripMenuItem.Click += new System.EventHandler(this.consultaAnimalToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarReportesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(113, 33);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Visible = false;
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // consultarReportesToolStripMenuItem
            // 
            this.consultarReportesToolStripMenuItem.Name = "consultarReportesToolStripMenuItem";
            this.consultarReportesToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            this.consultarReportesToolStripMenuItem.Text = "Consultar reportes";
            this.consultarReportesToolStripMenuItem.Click += new System.EventHandler(this.consultarReportesToolStripMenuItem_Click);
            // 
            // gestionarEmpleadosToolStripMenuItem
            // 
            this.gestionarEmpleadosToolStripMenuItem.Name = "gestionarEmpleadosToolStripMenuItem";
            this.gestionarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(234, 33);
            this.gestionarEmpleadosToolStripMenuItem.Text = "Gestionar empleados";
            this.gestionarEmpleadosToolStripMenuItem.Visible = false;
            this.gestionarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.gestionarEmpleadosToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(153, 33);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1695, 800);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Interfaz";
            this.Text = "Interfaz";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            this.MouseLeave += new System.EventHandler(this.Interfaz_MouseLeave);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adopciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}