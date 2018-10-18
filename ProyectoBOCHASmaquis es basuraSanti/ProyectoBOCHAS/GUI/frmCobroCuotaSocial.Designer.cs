namespace ProyectoBOCHAS
{
    partial class frmCobroCuotaSocial
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
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.txtNroSocio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNomSocio = new System.Windows.Forms.Label();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnRecibo = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombreSocio.Location = new System.Drawing.Point(277, 38);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(326, 20);
            this.txtNombreSocio.TabIndex = 17;
            // 
            // txtNroSocio
            // 
            this.txtNroSocio.Location = new System.Drawing.Point(94, 39);
            this.txtNroSocio.Name = "txtNroSocio";
            this.txtNroSocio.Size = new System.Drawing.Size(40, 20);
            this.txtNroSocio.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 21);
            this.button1.TabIndex = 15;
            this.button1.Text = ". . . ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblNomSocio
            // 
            this.lblNomSocio.AutoSize = true;
            this.lblNomSocio.Location = new System.Drawing.Point(197, 43);
            this.lblNomSocio.Name = "lblNomSocio";
            this.lblNomSocio.Size = new System.Drawing.Size(74, 13);
            this.lblNomSocio.TabIndex = 14;
            this.lblNomSocio.Text = "Nombre Socio";
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.Location = new System.Drawing.Point(9, 41);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(74, 13);
            this.lblNroSocio.TabIndex = 13;
            this.lblNroSocio.Text = "Numero Socio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha de pago";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Cursor = System.Windows.Forms.Cursors.No;
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPago.Location = new System.Drawing.Point(94, 72);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(98, 20);
            this.dtpFechaPago.TabIndex = 19;
            this.dtpFechaPago.Value = new System.DateTime(2018, 10, 18, 0, 0, 0, 0);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(9, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 20;
            this.lblCliente.Text = "Cliente";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(283, 9);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 21;
            this.lblDireccion.Text = "Direccion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(341, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 20);
            this.textBox2.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(370, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Pertenece a mes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(633, 124);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 43);
            this.btnLimpiarCampos.TabIndex = 29;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // btnRecibo
            // 
            this.btnRecibo.Location = new System.Drawing.Point(633, 75);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(75, 43);
            this.btnRecibo.TabIndex = 28;
            this.btnRecibo.Text = "Generar Recibo";
            this.btnRecibo.UseVisualStyleBackColor = true;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(633, 26);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 43);
            this.btnAñadir.TabIndex = 27;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // frmCobroCuotaSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 301);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnRecibo);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreSocio);
            this.Controls.Add(this.txtNroSocio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNomSocio);
            this.Controls.Add(this.lblNroSocio);
            this.Name = "frmCobroCuotaSocial";
            this.Text = "Cobro cuota social ";
            this.Load += new System.EventHandler(this.frmCobroCuotaSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.TextBox txtNroSocio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNomSocio;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.Button btnAñadir;
    }
}