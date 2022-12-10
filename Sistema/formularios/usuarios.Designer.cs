
namespace Sistema.formularios
{
    partial class usuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mOVIMIENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.rOLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDABARROTERol = new Sistema.BDABARROTERol();
            this.rOLTableAdapter = new Sistema.BDABARROTERolTableAdapters.ROLTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDABARROTERol)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOVIMIENTOSToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 28);
            this.menuStrip1.TabIndex = 0;
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
            this.catalogoToolStripMenuItem.Click += new System.EventHandler(this.catalogoToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(669, 27);
            this.toolStrip1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rol:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(133, 130);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(326, 30);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(133, 343);
            this.txtContra.MaxLength = 8;
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(326, 30);
            this.txtContra.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(133, 198);
            this.txtNom.MaxLength = 50;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(326, 30);
            this.txtNom.TabIndex = 7;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // cmbRoles
            // 
            this.cmbRoles.DataSource = this.rOLBindingSource;
            this.cmbRoles.DisplayMember = "NOMBRE";
            this.cmbRoles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(133, 266);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(326, 31);
            this.cmbRoles.TabIndex = 8;
            this.cmbRoles.ValueMember = "IDCLAVE";
            // 
            // rOLBindingSource
            // 
            this.rOLBindingSource.DataMember = "ROL";
            this.rOLBindingSource.DataSource = this.bDABARROTERol;
            // 
            // bDABARROTERol
            // 
            this.bDABARROTERol.DataSetName = "BDABARROTERol";
            this.bDABARROTERol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rOLTableAdapter
            // 
            this.rOLTableAdapter.ClearBeforeFill = true;
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(669, 456);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "usuarios";
            this.Load += new System.EventHandler(this.usuarios_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDABARROTERol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem mOVIMIENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsBtnGuardar;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
        private System.Windows.Forms.ToolStripButton tsBtnEliminar;
        private System.Windows.Forms.ToolStripButton tsBtnImprimir;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cmbRoles;
        private BDABARROTERol bDABARROTERol;
        private System.Windows.Forms.BindingSource rOLBindingSource;
        private BDABARROTERolTableAdapters.ROLTableAdapter rOLTableAdapter;
    }
}