﻿namespace ProyectoBOCHAS
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
            this.idSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblDom = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcionSocioADisciplina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.Location = new System.Drawing.Point(24, 68);
            this.lblNroSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(97, 17);
            this.lblNroSocio.TabIndex = 0;
            this.lblNroSocio.Text = "Numero Socio";
            // 
            // lblNomSocio
            // 
            this.lblNomSocio.AutoSize = true;
            this.lblNomSocio.Location = new System.Drawing.Point(273, 68);
            this.lblNomSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomSocio.Name = "lblNomSocio";
            this.lblNomSocio.Size = new System.Drawing.Size(97, 17);
            this.lblNomSocio.TabIndex = 1;
            this.lblNomSocio.Text = "Nombre Socio";
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(24, 116);
            this.lblDisciplina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(68, 17);
            this.lblDisciplina.TabIndex = 2;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(303, 116);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = ". . . ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNroSocio
            // 
            this.txtNroSocio.Location = new System.Drawing.Point(131, 63);
            this.txtNroSocio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNroSocio.Name = "txtNroSocio";
            this.txtNroSocio.Size = new System.Drawing.Size(52, 22);
            this.txtNroSocio.TabIndex = 6;
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombreSocio.Location = new System.Drawing.Point(413, 64);
            this.txtNombreSocio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(433, 22);
            this.txtNombreSocio.TabIndex = 7;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(380, 112);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(172, 24);
            this.cmbCategoria.TabIndex = 9;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbDisciplinas
            // 
            this.cmbDisciplinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplinas.FormattingEnabled = true;
            this.cmbDisciplinas.Location = new System.Drawing.Point(101, 111);
            this.cmbDisciplinas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDisciplinas.Name = "cmbDisciplinas";
            this.cmbDisciplinas.Size = new System.Drawing.Size(160, 24);
            this.cmbDisciplinas.TabIndex = 10;
            this.cmbDisciplinas.SelectedIndexChanged += new System.EventHandler(this.cmbDisciplinas_SelectedIndexChanged);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(531, 177);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(100, 53);
            this.btnAñadir.TabIndex = 11;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // dgvInscripcionSocioADisciplina
            // 
            this.dgvInscripcionSocioADisciplina.AllowUserToAddRows = false;
            this.dgvInscripcionSocioADisciplina.AllowUserToDeleteRows = false;
            this.dgvInscripcionSocioADisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcionSocioADisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSocio,
            this.nomSocio,
            this.disciplina,
            this.categoria,
            this.precioInscripcion});
            this.dgvInscripcionSocioADisciplina.Location = new System.Drawing.Point(12, 225);
            this.dgvInscripcionSocioADisciplina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInscripcionSocioADisciplina.Name = "dgvInscripcionSocioADisciplina";
            this.dgvInscripcionSocioADisciplina.ReadOnly = true;
            this.dgvInscripcionSocioADisciplina.RowHeadersVisible = false;
            this.dgvInscripcionSocioADisciplina.Size = new System.Drawing.Size(820, 182);
            this.dgvInscripcionSocioADisciplina.TabIndex = 12;
            // 
            // idSocio
            // 
            this.idSocio.HeaderText = "Numero Socio";
            this.idSocio.Name = "idSocio";
            this.idSocio.ReadOnly = true;
            this.idSocio.Width = 50;
            // 
            // nomSocio
            // 
            this.nomSocio.HeaderText = "Nombre Socio";
            this.nomSocio.Name = "nomSocio";
            this.nomSocio.ReadOnly = true;
            // 
            // disciplina
            // 
            this.disciplina.HeaderText = "Disciplina";
            this.disciplina.Name = "disciplina";
            this.disciplina.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // precioInscripcion
            // 
            this.precioInscripcion.HeaderText = "Precio Inscripcion";
            this.precioInscripcion.Name = "precioInscripcion";
            this.precioInscripcion.ReadOnly = true;
            // 
            // btnRecibo
            // 
            this.btnRecibo.Location = new System.Drawing.Point(747, 177);
            this.btnRecibo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(100, 53);
            this.btnRecibo.TabIndex = 13;
            this.btnRecibo.Text = "Generar Recibo";
            this.btnRecibo.UseVisualStyleBackColor = true;
            this.btnRecibo.Click += new System.EventHandler(this.btnRecibo_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(639, 177);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(100, 53);
            this.btnLimpiarCampos.TabIndex = 14;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(24, 203);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(101, 17);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total a abonar";
            // 
            // lblPrecioInscripcion
            // 
            this.lblPrecioInscripcion.AutoSize = true;
            this.lblPrecioInscripcion.Location = new System.Drawing.Point(575, 114);
            this.lblPrecioInscripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioInscripcion.Name = "lblPrecioInscripcion";
            this.lblPrecioInscripcion.Size = new System.Drawing.Size(119, 17);
            this.lblPrecioInscripcion.TabIndex = 16;
            this.lblPrecioInscripcion.Text = "Precio inscripcion";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(152, 199);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(109, 22);
            this.txtTotal.TabIndex = 17;
            // 
            // txtPrecioInscripcion
            // 
            this.txtPrecioInscripcion.Location = new System.Drawing.Point(703, 111);
            this.txtPrecioInscripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioInscripcion.Name = "txtPrecioInscripcion";
            this.txtPrecioInscripcion.ReadOnly = true;
            this.txtPrecioInscripcion.Size = new System.Drawing.Size(144, 22);
            this.txtPrecioInscripcion.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvInscripcionSocioADisciplina);
            this.groupBox1.Location = new System.Drawing.Point(16, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(845, 444);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(29, 12);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(74, 17);
            this.lblCliente.TabIndex = 20;
            this.lblCliente.Text = "Cliente: (*)";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(111, 9);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(224, 22);
            this.txtCliente.TabIndex = 21;
            // 
            // lblDom
            // 
            this.lblDom.AutoSize = true;
            this.lblDom.Location = new System.Drawing.Point(385, 12);
            this.lblDom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(68, 17);
            this.lblDom.TabIndex = 22;
            this.lblDom.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(464, 12);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(383, 22);
            this.txtDomicilio.TabIndex = 23;
            // 
            // frmInscripcionADisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 500);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.lblDom);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtPrecioInscripcion);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblPrecioInscripcion);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnRecibo);
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
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInscripcionADisciplina";
            this.Text = "Inscripcion Socio a Disciplina";
            this.Load += new System.EventHandler(this.frmInscripcionADisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcionSocioADisciplina)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecioInscripcion;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPrecioInscripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblDom;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioInscripcion;
    }
}