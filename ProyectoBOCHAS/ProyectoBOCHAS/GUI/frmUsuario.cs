﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBOCHAS.GUI;

namespace ProyectoBOCHAS
{
    public partial class frmUsuario : Form
    {
        Usuario usuario = new Usuario();

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            llenarGrilla(usuario.ConsultarUsuario(), dgvUsuario);
        }

        private void llenarGrilla(DataTable tabla, DataGridView grilla)
        {
            grilla.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grilla.Rows.Add(tabla.Rows[i]["idUsuario"], tabla.Rows[i]["nombreUsuario"], tabla.Rows[i]["password"]);
                }
            }
        }

        private void dgvUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //esconde la contraseña en el la grilla stackoverflow FTW
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

     

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Mostrar contraseña
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                if (checkBox1.CheckState == CheckState.Unchecked)
                {
                    txtPassword.PasswordChar = '*';
                }
            }
        }


        private void cmdModUsuario_Click(object sender, EventArgs e)
        {
            frmModUser fr = new frmModUser();
            fr.ShowDialog();
            llenarGrilla(usuario.ConsultarUsuario(), dgvUsuario);
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty || txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("No realizo la carga de alguno de los campos.", "Validación de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtUsuario.Text.Length > 20)
                {
                    MessageBox.Show("El nombre de usuario debe tener 20 caracteres o menos", "Validación de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (txtPassword.Text.Length > 10)
                    {
                        MessageBox.Show("La contraseña debe tener 10 caracteres o menos", "Validación de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        usuario.CargarUsuario(txtUsuario.Text, txtPassword.Text);
                        llenarGrilla(usuario.ConsultarUsuario(), dgvUsuario);
                        MessageBox.Show("Usuario creado", "Creacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
            }
        }


        public void limpiar()
        {
            txtPassword.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModUser fr = new frmModUser();
            fr.ShowDialog();
            llenarGrilla(usuario.ConsultarUsuario(), dgvUsuario);
        }
    }
}
