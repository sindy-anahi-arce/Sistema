namespace Sistema.formularios
{
    partial class Permisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permisos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdPer = new System.Windows.Forms.TextBox();
            this.txtId_rol = new System.Windows.Forms.TextBox();
            this.txtNomRol = new System.Windows.Forms.TextBox();
            this.txtId_modu = new System.Windows.Forms.TextBox();
            this.txtNomModu = new System.Windows.Forms.TextBox();
            this.rbConsultar = new System.Windows.Forms.RadioButton();
            this.rbGrabar = new System.Windows.Forms.RadioButton();
            this.rbActualizar = new System.Windows.Forms.RadioButton();
            this.rbBorrar = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mOVIMIENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave modulo:";
            // 
            // txtIdPer
            // 
            this.txtIdPer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPer.Location = new System.Drawing.Point(152, 103);
            this.txtIdPer.Name = "txtIdPer";
            this.txtIdPer.Size = new System.Drawing.Size(479, 30);
            this.txtIdPer.TabIndex = 3;
            this.txtIdPer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPer_KeyPress);
            // 
            // txtId_rol
            // 
            this.txtId_rol.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_rol.Location = new System.Drawing.Point(152, 203);
            this.txtId_rol.Name = "txtId_rol";
            this.txtId_rol.Size = new System.Drawing.Size(100, 30);
            this.txtId_rol.TabIndex = 4;
            this.txtId_rol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_rol_KeyPress);
            // 
            // txtNomRol
            // 
            this.txtNomRol.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomRol.Location = new System.Drawing.Point(258, 203);
            this.txtNomRol.Name = "txtNomRol";
            this.txtNomRol.Size = new System.Drawing.Size(373, 30);
            this.txtNomRol.TabIndex = 5;
            this.txtNomRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomRol_KeyPress);
            // 
            // txtId_modu
            // 
            this.txtId_modu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_modu.Location = new System.Drawing.Point(152, 286);
            this.txtId_modu.Name = "txtId_modu";
            this.txtId_modu.Size = new System.Drawing.Size(100, 30);
            this.txtId_modu.TabIndex = 6;
            // 
            // txtNomModu
            // 
            this.txtNomModu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomModu.Location = new System.Drawing.Point(258, 286);
            this.txtNomModu.Name = "txtNomModu";
            this.txtNomModu.Size = new System.Drawing.Size(373, 30);
            this.txtNomModu.TabIndex = 7;
            this.txtNomModu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomModu_KeyPress);
            // 
            // rbConsultar
            // 
            this.rbConsultar.AutoSize = true;
            this.rbConsultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConsultar.Location = new System.Drawing.Point(70, 392);
            this.rbConsultar.Name = "rbConsultar";
            this.rbConsultar.Size = new System.Drawing.Size(114, 27);
            this.rbConsultar.TabIndex = 8;
            this.rbConsultar.TabStop = true;
            this.rbConsultar.Text = "Consultar";
            this.rbConsultar.UseVisualStyleBackColor = true;
            // 
            // rbGrabar
            // 
            this.rbGrabar.AutoSize = true;
            this.rbGrabar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrabar.Location = new System.Drawing.Point(240, 392);
            this.rbGrabar.Name = "rbGrabar";
            this.rbGrabar.Size = new System.Drawing.Size(94, 27);
            this.rbGrabar.TabIndex = 9;
            this.rbGrabar.TabStop = true;
            this.rbGrabar.Text = "Grabar";
            this.rbGrabar.UseVisualStyleBackColor = true;
            // 
            // rbActualizar
            // 
            this.rbActualizar.AutoSize = true;
            this.rbActualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActualizar.Location = new System.Drawing.Point(400, 392);
            this.rbActualizar.Name = "rbActualizar";
            this.rbActualizar.Size = new System.Drawing.Size(116, 27);
            this.rbActualizar.TabIndex = 10;
            this.rbActualizar.TabStop = true;
            this.rbActualizar.Text = "Actualizar";
            this.rbActualizar.UseVisualStyleBackColor = true;
            // 
            // rbBorrar
            // 
            this.rbBorrar.AutoSize = true;
            this.rbBorrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBorrar.Location = new System.Drawing.Point(603, 392);
            this.rbBorrar.Name = "rbBorrar";
            this.rbBorrar.Size = new System.Drawing.Size(87, 27);
            this.rbBorrar.TabIndex = 11;
            this.rbBorrar.TabStop = true;
            this.rbBorrar.Text = "Borrar";
            this.rbBorrar.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnGuardar,
            this.tsBtnBuscar,
            this.tsBtnEliminar,
            this.tsBtnImprimir,
            this.tsBtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(748, 27);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnGuardar
            // 
            this.tsBtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnGuardar.Image")));
            this.tsBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGuardar.Name = "tsBtnGuardar";
            this.tsBtnGuardar.Size = new System.Drawing.Size(29, 24);
            this.tsBtnGuardar.Text = "Guardar";
            this.tsBtnGuardar.Click += new System.EventHandler(this.tsBtnGuardar_Click);
            // 
            // tsBtnBuscar
            // 
            this.tsBtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBuscar.Image")));
            this.tsBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBuscar.Name = "tsBtnBuscar";
            this.tsBtnBuscar.Size = new System.Drawing.Size(29, 24);
            this.tsBtnBuscar.Text = "Buscar";
            this.tsBtnBuscar.Click += new System.EventHandler(this.tsBtnBuscar_Click);
            // 
            // tsBtnEliminar
            // 
            this.tsBtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEliminar.Image")));
            this.tsBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEliminar.Name = "tsBtnEliminar";
            this.tsBtnEliminar.Size = new System.Drawing.Size(29, 24);
            this.tsBtnEliminar.Text = "Eliminar";
            this.tsBtnEliminar.Click += new System.EventHandler(this.tsBtnEliminar_Click);
            // 
            // tsBtnImprimir
            // 
            this.tsBtnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnImprimir.Image")));
            this.tsBtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnImprimir.Name = "tsBtnImprimir";
            this.tsBtnImprimir.Size = new System.Drawing.Size(29, 24);
            this.tsBtnImprimir.Text = "imprimir";
            // 
            // tsBtnSalir
            // 
            this.tsBtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSalir.Image")));
            this.tsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSalir.Name = "tsBtnSalir";
            this.tsBtnSalir.Size = new System.Drawing.Size(29, 24);
            this.tsBtnSalir.Text = "salir";
            this.tsBtnSalir.Click += new System.EventHandler(this.tsBtnSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOVIMIENTOSToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mOVIMIENTOSToolStripMenuItem
            // 
            this.mOVIMIENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.borrarToolStripMenuItem,
            this.catalogoToolStripMenuItem});
            this.mOVIMIENTOSToolStripMenuItem.Name = "mOVIMIENTOSToolStripMenuItem";
            this.mOVIMIENTOSToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.mOVIMIENTOSToolStripMenuItem.Text = "MOVIMIENTOS ";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.borrarToolStripMenuItem.Text = "Borrar";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.catalogoToolStripMenuItem.Text = "Catálogo";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(748, 440);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rbBorrar);
            this.Controls.Add(this.rbActualizar);
            this.Controls.Add(this.rbGrabar);
            this.Controls.Add(this.rbConsultar);
            this.Controls.Add(this.txtNomModu);
            this.Controls.Add(this.txtId_modu);
            this.Controls.Add(this.txtNomRol);
            this.Controls.Add(this.txtId_rol);
            this.Controls.Add(this.txtIdPer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Permisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.Permisos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdPer;
        private System.Windows.Forms.TextBox txtId_rol;
        private System.Windows.Forms.TextBox txtNomRol;
        private System.Windows.Forms.TextBox txtId_modu;
        private System.Windows.Forms.TextBox txtNomModu;
        private System.Windows.Forms.RadioButton rbConsultar;
        private System.Windows.Forms.RadioButton rbGrabar;
        private System.Windows.Forms.RadioButton rbActualizar;
        private System.Windows.Forms.RadioButton rbBorrar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnGuardar;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
        private System.Windows.Forms.ToolStripButton tsBtnEliminar;
        private System.Windows.Forms.ToolStripButton tsBtnImprimir;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mOVIMIENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}