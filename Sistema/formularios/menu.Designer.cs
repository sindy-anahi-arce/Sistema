
namespace Sistema
{
    partial class menu
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
            this.cATALAGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOVIMIENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mINERIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cATALAGOToolStripMenuItem,
            this.mOVIMIENTOSToolStripMenuItem,
            this.rEPORTEToolStripMenuItem,
            this.mINERIASToolStripMenuItem,
            this.sALIDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cATALAGOToolStripMenuItem
            // 
            this.cATALAGOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.datosGeneralesToolStripMenuItem,
            this.modulosToolStripMenuItem,
            this.permisosToolStripMenuItem});
            this.cATALAGOToolStripMenuItem.Name = "cATALAGOToolStripMenuItem";
            this.cATALAGOToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.cATALAGOToolStripMenuItem.Text = "CATALAGO";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // datosGeneralesToolStripMenuItem
            // 
            this.datosGeneralesToolStripMenuItem.Name = "datosGeneralesToolStripMenuItem";
            this.datosGeneralesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.datosGeneralesToolStripMenuItem.Text = "Datos generales";
            this.datosGeneralesToolStripMenuItem.Click += new System.EventHandler(this.datosGeneralesToolStripMenuItem_Click);
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modulosToolStripMenuItem.Text = "Modulos";
            this.modulosToolStripMenuItem.Click += new System.EventHandler(this.modulosToolStripMenuItem_Click);
            // 
            // mOVIMIENTOSToolStripMenuItem
            // 
            this.mOVIMIENTOSToolStripMenuItem.Name = "mOVIMIENTOSToolStripMenuItem";
            this.mOVIMIENTOSToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.mOVIMIENTOSToolStripMenuItem.Text = "MOVIMIENTOS";
            // 
            // rEPORTEToolStripMenuItem
            // 
            this.rEPORTEToolStripMenuItem.Name = "rEPORTEToolStripMenuItem";
            this.rEPORTEToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.rEPORTEToolStripMenuItem.Text = "REPORTE";
            // 
            // mINERIASToolStripMenuItem
            // 
            this.mINERIASToolStripMenuItem.Name = "mINERIASToolStripMenuItem";
            this.mINERIASToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.mINERIASToolStripMenuItem.Text = "MINERIAS";
            // 
            // sALIDAToolStripMenuItem
            // 
            this.sALIDAToolStripMenuItem.Name = "sALIDAToolStripMenuItem";
            this.sALIDAToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.sALIDAToolStripMenuItem.Text = "SALIDA";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.permisosToolStripMenuItem.Text = "Permisos";
            this.permisosToolStripMenuItem.Click += new System.EventHandler(this.permisosToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1008, 467);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cATALAGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOVIMIENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mINERIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosGeneralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
    }
}