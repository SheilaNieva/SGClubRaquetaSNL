
namespace SGClubRaquetaSNL
{
    partial class Form_Principal
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
            this.tsmenuAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuAdministrar,
            this.tsMenuReservas,
            this.tsMenuInformes,
            this.tsMenuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // tsmenuAdministrar
            // 
            this.tsmenuAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sociosToolStripMenuItem,
            this.pistasToolStripMenuItem});
            this.tsmenuAdministrar.Name = "tsmenuAdministrar";
            this.tsmenuAdministrar.Size = new System.Drawing.Size(95, 20);
            this.tsmenuAdministrar.Text = "ADMINISTRAR";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.sociosToolStripMenuItem.Text = "Socios";
            this.sociosToolStripMenuItem.Click += new System.EventHandler(this.sociosToolStripMenuItem_Click);
            // 
            // pistasToolStripMenuItem
            // 
            this.pistasToolStripMenuItem.Name = "pistasToolStripMenuItem";
            this.pistasToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.pistasToolStripMenuItem.Text = "Pistas";
            this.pistasToolStripMenuItem.Click += new System.EventHandler(this.pistasToolStripMenuItem_Click);
            // 
            // tsMenuReservas
            // 
            this.tsMenuReservas.Name = "tsMenuReservas";
            this.tsMenuReservas.Size = new System.Drawing.Size(71, 20);
            this.tsMenuReservas.Text = "RESERVAS";
            this.tsMenuReservas.Click += new System.EventHandler(this.tsMenuReservas_Click);
            // 
            // tsMenuInformes
            // 
            this.tsMenuInformes.Name = "tsMenuInformes";
            this.tsMenuInformes.Size = new System.Drawing.Size(76, 20);
            this.tsMenuInformes.Text = "INFORMES";
            // 
            // tsMenuSalir
            // 
            this.tsMenuSalir.Name = "tsMenuSalir";
            this.tsMenuSalir.Size = new System.Drawing.Size(49, 20);
            this.tsMenuSalir.Text = "SALIR";
            this.tsMenuSalir.Click += new System.EventHandler(this.tsMenuSalir_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmenuAdministrar;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuReservas;
        private System.Windows.Forms.ToolStripMenuItem tsMenuInformes;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSalir;
    }
}

