namespace ProyectoBOCHAS
{
    partial class frmBecas
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
            this.dgvBecas = new System.Windows.Forms.DataGridView();
            this.idBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtInstrucciones = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarBecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarBecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarBecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBecas
            // 
            this.dgvBecas.AllowUserToAddRows = false;
            this.dgvBecas.AllowUserToDeleteRows = false;
            this.dgvBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBeca,
            this.nombre,
            this.descripcion});
            this.dgvBecas.Location = new System.Drawing.Point(11, 37);
            this.dgvBecas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBecas.Name = "dgvBecas";
            this.dgvBecas.ReadOnly = true;
            this.dgvBecas.RowHeadersVisible = false;
            this.dgvBecas.RowTemplate.Height = 24;
            this.dgvBecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBecas.Size = new System.Drawing.Size(485, 141);
            this.dgvBecas.TabIndex = 0;
            this.dgvBecas.SelectionChanged += new System.EventHandler(this.dgvBecas_SelectionChanged);
            // 
            // idBeca
            // 
            this.idBeca.HeaderText = "# Beca";
            this.idBeca.Name = "idBeca";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre Beca";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 88;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 225);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre: (*)";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(17, 262);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 222);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(384, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(87, 259);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(383, 72);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtInstrucciones
            // 
            this.txtInstrucciones.AutoSize = true;
            this.txtInstrucciones.Location = new System.Drawing.Point(17, 191);
            this.txtInstrucciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtInstrucciones.Name = "txtInstrucciones";
            this.txtInstrucciones.Size = new System.Drawing.Size(459, 13);
            this.txtInstrucciones.TabIndex = 11;
            this.txtInstrucciones.Text = "Cargue los campos abajo para agregar beca o seleccione una de la lista para modif" +
    "icar/eliminar.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarBecaToolStripMenuItem,
            this.eliminarBecaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.archivoToolStripMenuItem.Text = "Becas";
            // 
            // agregarBecaToolStripMenuItem
            // 
            this.agregarBecaToolStripMenuItem.Name = "agregarBecaToolStripMenuItem";
            this.agregarBecaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.agregarBecaToolStripMenuItem.Text = "Agregar Beca";
            this.agregarBecaToolStripMenuItem.Click += new System.EventHandler(this.agregarBecaToolStripMenuItem_Click);
            // 
            // eliminarBecaToolStripMenuItem
            // 
            this.eliminarBecaToolStripMenuItem.Name = "eliminarBecaToolStripMenuItem";
            this.eliminarBecaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.eliminarBecaToolStripMenuItem.Text = "Eliminar Beca";
            this.eliminarBecaToolStripMenuItem.Click += new System.EventHandler(this.eliminarBecaToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarBecaToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // modificarBecaToolStripMenuItem
            // 
            this.modificarBecaToolStripMenuItem.Name = "modificarBecaToolStripMenuItem";
            this.modificarBecaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.modificarBecaToolStripMenuItem.Text = "Modificar beca";
            this.modificarBecaToolStripMenuItem.Click += new System.EventHandler(this.modificarBecaToolStripMenuItem_Click);
            // 
            // frmBecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 470);
            this.Controls.Add(this.txtInstrucciones);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvBecas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBecas";
            this.Text = "frmBecas";
            this.Load += new System.EventHandler(this.frmBecas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBecas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Label txtInstrucciones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarBecaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarBecaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarBecaToolStripMenuItem;
    }
}