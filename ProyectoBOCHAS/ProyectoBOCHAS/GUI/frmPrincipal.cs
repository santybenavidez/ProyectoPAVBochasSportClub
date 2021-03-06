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
    public partial class frmPrincipal : Form
    {
        Usuario usuario = new Usuario();
        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar sesión?", "Confirmación de cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmBecas frmBecas = new frmBecas();
            frmBecas.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmSocios frmSocios = new frmSocios();
            frmSocios.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmDisciplinas frmDisciplinas = new frmDisciplinas();
            frmDisciplinas.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos frmProductos = new frmProductos();
            frmProductos.ShowDialog();
        }

        private void inscripcionADisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inscripcionDeSocioADisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscripcionADisciplina inscripcionADisciplina = new frmInscripcionADisciplina();
            inscripcionADisciplina.ShowDialog();
        }

        private void inscripcionDeSocioABecasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscripcionBeca pantallaInscripcionBeca = new frmInscripcionBeca();
            pantallaInscripcionBeca.ShowDialog();
        }

        private void cobroDeCuotasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCobroCuotaSocial pantallaCobroCuotaSocial = new frmCobroCuotaSocial();
            pantallaCobroCuotaSocial.ShowDialog();
        }

        private void cobroDeCuotasDisciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCobroCuotaDisciplina pantallaCuotaDisciplina = new frmCobroCuotaDisciplina();
            pantallaCuotaDisciplina.ShowDialog();
        }

        private void cobroDeIndumentariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentaProductos frmVentaProductos = new frmVentaProductos();
            frmVentaProductos.Show();
        }

        private void porDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSociosXDisciplinas frmGrafico = new frmSociosXDisciplinas();
            frmGrafico.ShowDialog();
        }

        private void ventasPorTiposDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentasXTipoProducto frmVentasxTipoProductos = new frmVentasXTipoProducto();
            frmVentasxTipoProductos.ShowDialog();
        }

        private void listadoCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoCompletoSocios listado = new frmListadoCompletoSocios();
            listado.ShowDialog();
        }

        private void recibosPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecibosPorFecha frmRecibo = new frmRecibosPorFecha();
            frmRecibo.ShowDialog();
        }
    }
}
