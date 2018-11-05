using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProyectoBOCHAS
{
    public partial class frmVentaProductos : Form
    {
        Validadores validadores = new Validadores();
        VentaProductos transaccion = new VentaProductos();
        private bool bandera = false;
        

        public frmVentaProductos()
        {
            InitializeComponent();

        }

        private void llenarComboProductos() //carga el combo Productos, la bandera es porque se activaba el metodo de cambio antes de que ponga bien los valores y daba excepcion de sql
        {
            DataTable tabla = new DataTable();
            tabla = transaccion.buscarProductos();
            cmbProductos.DataSource = tabla;
            cmbProductos.ValueMember = tabla.Columns[0].ColumnName.ToString();
            bandera = true;
            cmbProductos.DisplayMember = tabla.Columns[1].ColumnName.ToString();
        }

        private void cargarTipos() //carga el tipos del producto seleccionado
        {
            string tipo = transaccion.buscarTipo(cmbProductos.Text);
            txtTipo.Text = tipo;

        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bandera)
            {
                cargarTipos();
                DataTable precio = transaccion.buscarPrecioProducto(cmbProductos.Text);
                txtPrecioU.Text = precio.Rows[0][0].ToString();
            }
        }

        private void frmVentaProductos_Load(object sender, EventArgs e)
        {
            llenarComboProductos();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty || txtPrecioU.Text == string.Empty)
            { }
            else if (validadores.ValidarTxt(textBox2))
            {
                double a, b;
                a = Convert.ToDouble(textBox2.Text);
                b = Convert.ToDouble(txtPrecioU.Text);
                txtSubTotal.Text = (a * b).ToString();
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == string.Empty)
                MessageBox.Show("Debe ingresar una cantidad valida", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                dgvProductos.Rows.Add(cmbProductos.Text, txtTipo.Text, textBox2.Text, txtPrecioU.Text, txtSubTotal.Text);
                txtTotal.Text = Convert.ToString(calculartotal());
            }

        }

        private double calculartotal()
        {
            double total = 0;
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvProductos.Rows[i].Cells[4].Value.ToString());
            }
            return total;
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            if (validadores.validarNoVacio(txtCliente, lblCliente) && validadores.validarNoVacio(txtDomicilio, lblDireccion))
            {

                if (dgvProductos.Rows.Count > 0)
                {
                    transaccion.encabezado(txtTotal.Text, "Venta de Indumentaria Deportiva", txtCliente.Text, txtDomicilio.Text);//cargo en recibo
                    for (int i = 0; i < dgvProductos.RowCount; i++)
                    {
                        DataTable tablaIdProducto = transaccion.buscarIdProducto(dgvProductos.Rows[i].Cells["descripcion_producto"].Value.ToString());
                        DataTable tablaIdTipoProducto = transaccion.buscarIdTipoProducto(dgvProductos.Rows[i].Cells["tipo_producto"].Value.ToString());

                        int idProducto = Convert.ToInt32(tablaIdProducto.Rows[0][0].ToString());
                        int idTipoProducto = Convert.ToInt32(tablaIdTipoProducto.Rows[0][0].ToString());

                        transaccion.detalle(idProducto, idTipoProducto);
                    }

                    bool anduvo = transaccion.realizarTransaccion();

                    if (anduvo)
                    {
                        MessageBox.Show("El recibo se generó con exito", "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string nroRecibo = transaccion.nRecibo();
                        DataTable tabla = validadores.GetDataTableFromDGV(dgvProductos);
                        frmRecibo frmRecibo = new frmRecibo(txtCliente.Text, txtDomicilio.Text, nroRecibo, tabla);
                        btnLimpiarCampos_Click(sender, e);
                        frmRecibo.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal...", "Inscripción fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnLimpiarCampos_Click(sender, e);
                    }
                }
                else
                    MessageBox.Show("No cargo ningun pago de cuota", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            txtCliente.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            cmbProductos.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtPrecioU.Text = string.Empty;
            textBox2.Text = string.Empty;
            txtSubTotal.Text = string.Empty;
            txtTotal.Text = string.Empty;
        }
    }
}
