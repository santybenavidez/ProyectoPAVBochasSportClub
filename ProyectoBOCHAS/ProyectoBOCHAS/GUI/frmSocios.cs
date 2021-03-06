﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBOCHAS
{
    public partial class frmSocios : Form
    {
        Socios socios = new Socios();
        Validadores validadores = new Validadores();

        public frmSocios()
        {
            InitializeComponent();
        }

        private void frmSocios_Load(object sender, EventArgs e)
        {
            llenarGrilla(socios.ConsultarSocio(), dgvSocios);
        }

        private void llenarGrilla(DataTable tabla, DataGridView grilla)
        {
            grilla.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grilla.Rows.Add(tabla.Rows[i]["idSocio"], tabla.Rows[i]["apellido"], tabla.Rows[i]["nombre"], tabla.Rows[i]["direccion"], tabla.Rows[i]["dni"], tabla.Rows[i]["fechaNacimiento"], tabla.Rows[i]["nroTelefono"], tabla.Rows[i]["responsableTelefono"]);
                }
            }
        }

        private void limpiarCampos()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtResponsable.Text = string.Empty;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == string.Empty || txtNombre.Text == string.Empty || txtDni.Text == string.Empty || (txtTelefono.Text == string.Empty || txtResponsable.Text == string.Empty))
            {
                MessageBox.Show("No realizo la carga de algun campo obligatorio", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (validadores.ValidarTxt(txtDni) && validadores.ValidarTxt(txtTelefono))
            {
                bool bandera = socios.NuevoSocio(txtApellido.Text, txtNombre.Text, txtDireccion.Text, txtDni.Text, dtpFecha.Value.ToString("MM/dd/yyyy"), txtTelefono.Text, txtResponsable.Text);
                if (bandera)
                {
                    llenarGrilla(socios.ConsultarSocio(), dgvSocios);
                    limpiarCampos();
                    MessageBox.Show("Socio creado", "Creación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Algo salio mal...", "Creación fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarCampos();
                }
            }

        }

        private void modificarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModSocios frmModSocios = new frmModSocios();
            frmModSocios.ShowDialog();
            llenarGrilla(socios.ConsultarSocio(), dgvSocios);
        }
    }
}
