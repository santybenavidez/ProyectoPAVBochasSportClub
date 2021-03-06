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
    public partial class frmBecas : Form
    {
        Becas becas = new Becas();

        public frmBecas()
        {
            InitializeComponent();
        }

        private void frmBecas_Load(object sender, EventArgs e)
        {
            llenarGrilla(becas.ConsultarBecas(), dgvBecas);
        }

        private void llenarGrilla(DataTable tabla, DataGridView grilla)
        {
            grilla.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grilla.Rows.Add(tabla.Rows[i]["idBeca"], tabla.Rows[i]["nombre"], tabla.Rows[i]["descripcion"]);
                }
            }
        }

   
        private void Limpiar() //Deja al form deshabilitado
        {
         
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            
        }

        private void dgvBecas_SelectionChanged(object sender, EventArgs e)
        {
            txtNombre.Text = dgvBecas.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvBecas.CurrentRow.Cells[2].Value.ToString();
        }

        private void agregarBecaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
                MessageBox.Show("Debe cargar el nombre de la nueva Beca", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                becas.CargarBeca(txtNombre.Text, txtDescripcion.Text);
                llenarGrilla(becas.ConsultarBecas(), dgvBecas);
                MessageBox.Show("Beca creada", "Creación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void eliminarBecaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
                MessageBox.Show("Debe seleccionar una beca en la lista", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (MessageBox.Show("¿Seguro desea eliminar la beca '" + txtNombre.Text + "'?", "Confimación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Int32.Parse(dgvBecas.CurrentRow.Cells[0].Value.ToString());
                    becas.EliminarBeca(id);
                    MessageBox.Show("Beca eliminada", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarGrilla(becas.ConsultarBecas(), dgvBecas);
                    Limpiar();
                }
                else
                {
                    Limpiar();
                }
            }
        }

        private void modificarBecaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
                MessageBox.Show("Debe seleccionar una beca en la lista", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (MessageBox.Show("¿Seguro desea modificar la beca '" + txtNombre.Text + "'?", "Confimación de modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Int32.Parse(dgvBecas.CurrentRow.Cells[0].Value.ToString());
                    becas.ModificarBeca(id, txtNombre.Text, txtDescripcion.Text);
                    MessageBox.Show("Beca modificada", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarGrilla(becas.ConsultarBecas(), dgvBecas);
                    Limpiar();
                }
                else
                {
                    Limpiar();
                }
            }
        }
    }
}
