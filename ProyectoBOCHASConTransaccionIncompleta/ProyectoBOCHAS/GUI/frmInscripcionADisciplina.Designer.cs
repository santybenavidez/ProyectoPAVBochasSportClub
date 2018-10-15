namespace ProyectoBOCHAS
{
    partial class frmInscripcionADisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcionADisciplina));
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.lblNomSocio = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNroSocio = new System.Windows.Forms.TextBox();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbDisciplinas = new System.Windows.Forms.ComboBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.dgvInscripcionSocioADisciplina = new System.Windows.Forms.DataGridView();
            this.nroSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRecibo = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecioInscripcion = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrecioInscripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcionSocioADisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.Location = new System.Drawing.Point(12, 7);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(74, 13);
            this.lblNroSocio.TabIndex = 0;
            this.lblNroSocio.Text = "Numero Socio";
            // 
            // lblNomSocio
            // 
            this.lblNomSocio.AutoSize = true;
            this.lblNomSocio.Location = new System.Drawing.Point(199, 7);
            this.lblNomSocio.Name = "lblNomSocio";
            this.lblNomSocio.Size = new System.Drawing.Size(74, 13);
            this.lblNomSocio.TabIndex = 1;
            this.lblNomSocio.Text = "Nombre Socio";
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(12, 46);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplina.TabIndex = 2;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(221, 46);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 21);
            this.button1.TabIndex = 5;
            this.button1.Text = ". . . ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNroSocio
            // 
            this.txtNroSocio.Location = new System.Drawing.Point(92, 3);
            this.txtNroSocio.Name = "txtNroSocio";
            this.txtNroSocio.Size = new System.Drawing.Size(40, 20);
            this.txtNroSocio.TabIndex = 6;
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombreSocio.Location = new System.Drawing.Point(304, 4);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(326, 20);
            this.txtNombreSocio.TabIndex = 7;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(279, 43);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(130, 21);
            this.cmbCategoria.TabIndex = 9;
          
            // 
            // cmbDisciplinas
            // 
            this.cmbDisciplinas.FormattingEnabled = true;
            this.cmbDisciplinas.Location = new System.Drawing.Point(70, 42);
            this.cmbDisciplinas.Name = "cmbDisciplinas";
            this.cmbDisciplinas.Size = new System.Drawing.Size(121, 21);
            this.cmbDisciplinas.TabIndex = 10;
            this.cmbDisciplinas.SelectedIndexChanged += new System.EventHandler(this.cmbDisciplinas_SelectedIndexChanged);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(392, 70);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 43);
            this.btnAñadir.TabIndex = 11;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // dgvInscripcionSocioADisciplina
            // 
            this.dgvInscripcionSocioADisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcionSocioADisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroSocio,
            this.nomSocio,
            this.disciplina,
            this.categoria,
            this.precioInscripcion});
            this.dgvInscripcionSocioADisciplina.Location = new System.Drawing.Point(15, 119);
            this.dgvInscripcionSocioADisciplina.Name = "dgvInscripcionSocioADisciplina";
            this.dgvInscripcionSocioADisciplina.Size = new System.Drawing.Size(615, 148);
            this.dgvInscripcionSocioADisciplina.TabIndex = 12;
            // 
            // nroSocio
            // 
            this.nroSocio.HeaderText = "Numero Socio";
            this.nroSocio.Name = "nroSocio";
            // 
            // nomSocio
            // 
            this.nomSocio.HeaderText = "Nombre Socio";
            this.nomSocio.Name = "nomSocio";
            // 
            // disciplina
            // 
            this.disciplina.HeaderText = "Disciplina";
            this.disciplina.Name = "disciplina";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // precioInscripcion
            // 
            this.precioInscripcion.HeaderText = "Precio Inscripcion";
            this.precioInscripcion.Name = "precioInscripcion";
            // 
            // btnRecibo
            // 
            this.btnRecibo.Location = new System.Drawing.Point(554, 70);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(75, 43);
            this.btnRecibo.TabIndex = 13;
            this.btnRecibo.Text = "Generar Recibo";
            this.btnRecibo.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(473, 70);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 43);
            this.btnLimpiarCampos.TabIndex = 14;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 85);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total a abonar";
            // 
            // lblPrecioInscripcion
            // 
            this.lblPrecioInscripcion.AutoSize = true;
            this.lblPrecioInscripcion.Location = new System.Drawing.Point(425, 45);
            this.lblPrecioInscripcion.Name = "lblPrecioInscripcion";
            this.lblPrecioInscripcion.Size = new System.Drawing.Size(90, 13);
            this.lblPrecioInscripcion.TabIndex = 16;
            this.lblPrecioInscripcion.Text = "Precio inscripcion";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(108, 82);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(83, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // txtPrecioInscripcion
            // 
            this.txtPrecioInscripcion.Location = new System.Drawing.Point(521, 42);
            this.txtPrecioInscripcion.Name = "txtPrecioInscripcion";
            this.txtPrecioInscripcion.ReadOnly = true;
            this.txtPrecioInscripcion.Size = new System.Drawing.Size(109, 20);
            this.txtPrecioInscripcion.TabIndex = 18;
            // 
            // frmInscripcionADisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 343);
            this.Controls.Add(this.txtPrecioInscripcion);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblPrecioInscripcion);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnRecibo);
            this.Controls.Add(this.dgvInscripcionSocioADisciplina);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.cmbDisciplinas);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtNombreSocio);
            this.Controls.Add(this.txtNroSocio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.lblNomSocio);
            this.Controls.Add(this.lblNroSocio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInscripcionADisciplina";
            this.Text = "Inscripcion Socio a Disciplina";
            this.Load += new System.EventHandler(this.frmInscripcionADisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcionSocioADisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.Label lblNomSocio;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNroSocio;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbDisciplinas;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DataGridView dgvInscripcionSocioADisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioInscripcion;
        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecioInscripcion;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPrecioInscripcion;
    }
}