namespace ProyectoBOCHAS
{
    partial class frmInscripcionBeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcionBeca));
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.txtNroSocio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNomSocio = new System.Windows.Forms.Label();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.lblBecas = new System.Windows.Forms.Label();
            this.cmbBecas = new System.Windows.Forms.ComboBox();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dgvInscripcionBecas = new System.Windows.Forms.DataGridView();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnRecibo = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.idSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcionBecas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombreSocio.Location = new System.Drawing.Point(372, 7);
            this.txtNombreSocio.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(433, 22);
            this.txtNombreSocio.TabIndex = 12;
            // 
            // txtNroSocio
            // 
            this.txtNroSocio.Location = new System.Drawing.Point(121, 6);
            this.txtNroSocio.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroSocio.Name = "txtNroSocio";
            this.txtNroSocio.Size = new System.Drawing.Size(52, 22);
            this.txtNroSocio.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = ". . . ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNomSocio
            // 
            this.lblNomSocio.AutoSize = true;
            this.lblNomSocio.Location = new System.Drawing.Point(265, 11);
            this.lblNomSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomSocio.Name = "lblNomSocio";
            this.lblNomSocio.Size = new System.Drawing.Size(97, 17);
            this.lblNomSocio.TabIndex = 9;
            this.lblNomSocio.Text = "Nombre Socio";
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.Location = new System.Drawing.Point(16, 11);
            this.lblNroSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(97, 17);
            this.lblNroSocio.TabIndex = 8;
            this.lblNroSocio.Text = "Numero Socio";
            // 
            // lblBecas
            // 
            this.lblBecas.AutoSize = true;
            this.lblBecas.Location = new System.Drawing.Point(16, 58);
            this.lblBecas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBecas.Name = "lblBecas";
            this.lblBecas.Size = new System.Drawing.Size(94, 17);
            this.lblBecas.TabIndex = 13;
            this.lblBecas.Text = "Nombre Beca";
            // 
            // cmbBecas
            // 
            this.cmbBecas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBecas.FormattingEnabled = true;
            this.cmbBecas.Location = new System.Drawing.Point(121, 54);
            this.cmbBecas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBecas.Name = "cmbBecas";
            this.cmbBecas.Size = new System.Drawing.Size(160, 24);
            this.cmbBecas.TabIndex = 14;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIni.Location = new System.Drawing.Point(499, 39);
            this.dtpFechaIni.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(237, 22);
            this.dtpFechaIni.TabIndex = 15;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(499, 71);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(237, 22);
            this.dtpFechaFin.TabIndex = 16;
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Location = new System.Drawing.Point(368, 47);
            this.lblFechaIni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(119, 17);
            this.lblFechaIni.TabIndex = 17;
            this.lblFechaIni.Text = "Fecha inicio Beca";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(368, 79);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(102, 17);
            this.lblFechaFin.TabIndex = 18;
            this.lblFechaFin.Text = "Fecha fin Beca";
            // 
            // dgvInscripcionBecas
            // 
            this.dgvInscripcionBecas.AllowUserToAddRows = false;
            this.dgvInscripcionBecas.AllowUserToDeleteRows = false;
            this.dgvInscripcionBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcionBecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSocio,
            this.nombreSocio,
            this.nroBeca,
            this.nombreBeca,
            this.fechaInicioBeca,
            this.fechaFinBeca});
            this.dgvInscripcionBecas.Location = new System.Drawing.Point(16, 138);
            this.dgvInscripcionBecas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInscripcionBecas.Name = "dgvInscripcionBecas";
            this.dgvInscripcionBecas.RowHeadersVisible = false;
            this.dgvInscripcionBecas.Size = new System.Drawing.Size(791, 185);
            this.dgvInscripcionBecas.TabIndex = 19;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(865, 135);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(100, 53);
            this.btnLimpiarCampos.TabIndex = 22;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnRecibo
            // 
            this.btnRecibo.Location = new System.Drawing.Point(865, 75);
            this.btnRecibo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(100, 53);
            this.btnRecibo.TabIndex = 21;
            this.btnRecibo.Text = "Generar Recibo";
            this.btnRecibo.UseVisualStyleBackColor = true;
            this.btnRecibo.Click += new System.EventHandler(this.btnRecibo_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(865, 15);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(100, 53);
            this.btnAñadir.TabIndex = 20;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // idSocio
            // 
            this.idSocio.HeaderText = "Numero Socio";
            this.idSocio.Name = "idSocio";
            this.idSocio.Width = 50;
            // 
            // nombreSocio
            // 
            this.nombreSocio.HeaderText = "Nombre Socio";
            this.nombreSocio.Name = "nombreSocio";
            this.nombreSocio.Width = 200;
            // 
            // nroBeca
            // 
            this.nroBeca.HeaderText = "Numero Beca";
            this.nroBeca.Name = "nroBeca";
            this.nroBeca.Visible = false;
            // 
            // nombreBeca
            // 
            this.nombreBeca.HeaderText = "Nombre Beca";
            this.nombreBeca.Name = "nombreBeca";
            // 
            // fechaInicioBeca
            // 
            this.fechaInicioBeca.HeaderText = "Fecha inicio Beca";
            this.fechaInicioBeca.Name = "fechaInicioBeca";
            // 
            // fechaFinBeca
            // 
            this.fechaFinBeca.HeaderText = "Fecha Fin Beca";
            this.fechaFinBeca.Name = "fechaFinBeca";
            // 
            // frmInscripcionBeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 373);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnRecibo);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dgvInscripcionBecas);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaIni);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaIni);
            this.Controls.Add(this.cmbBecas);
            this.Controls.Add(this.lblBecas);
            this.Controls.Add(this.txtNombreSocio);
            this.Controls.Add(this.txtNroSocio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNomSocio);
            this.Controls.Add(this.lblNroSocio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInscripcionBeca";
            this.Text = "Inscripcion Socio a Beca";
            this.Load += new System.EventHandler(this.frmInscripcionBeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcionBecas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.TextBox txtNroSocio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNomSocio;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.Label lblBecas;
        private System.Windows.Forms.ComboBox cmbBecas;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DataGridView dgvInscripcionBecas;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroBeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreBeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioBeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinBeca;
    }
}