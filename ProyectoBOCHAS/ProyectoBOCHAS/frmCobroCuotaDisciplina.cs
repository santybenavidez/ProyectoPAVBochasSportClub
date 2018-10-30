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
    public partial class frmCobroCuotaDisciplina : Form
    {
        Validadores validadores = new Validadores();
        CuotaDisciplina transaccion = new CuotaDisciplina();

        private bool bandera = false;
        private bool bandera2 = false;

        public frmCobroCuotaDisciplina()
        {
            InitializeComponent();
        }

        private void cargarComboMeses()
        {
            String[] Meses = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            cmbMes.Items.AddRange(Meses);
        }

        private void llenarComboDisciplinas() //carga el combo disciplinas, la bandera es porque se activaba el metodo de cambio antes de que ponga bien los valores y daba excepcion de sql
        {
            DataTable tabla = new DataTable();
            tabla = transaccion.buscarDisciplinas();
            cmbDisciplinas.DataSource = tabla;
            cmbDisciplinas.ValueMember = tabla.Columns[0].ColumnName.ToString();
            bandera = true;
            cmbDisciplinas.DisplayMember = tabla.Columns[1].ColumnName.ToString();
        }

        private void cargarComboCategorias() //carga las categorias de la disciplina seleccionada
        {
            DataTable tabla = new DataTable();
            tabla = transaccion.buscarCategoriasXDisciplinas(cmbDisciplinas.Text);
            cmbCategoria.DataSource = tabla;
            cmbCategoria.ValueMember = tabla.Columns[0].ColumnName.ToString();
            bandera2 = true;
            cmbCategoria.DisplayMember = tabla.Columns[1].ColumnName.ToString();
        }

        private void cmbDisciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bandera)
            {
                cmbCategoria.Enabled = true;
                cargarComboCategorias();
            }
        }

        private void frmCobroCuotaDisciplina_Load(object sender, EventArgs e)
        {
            cmbCategoria.Enabled = false;
            llenarComboDisciplinas();
            cargarComboMeses();
        }

        private void llenarPrecioCuota() //completa el precio de la inscripcion a una categoria
        {
            DataTable tabla = new DataTable();
            tabla = transaccion.buscarPrecioCuota(cmbCategoria.Text, cmbDisciplinas.Text); //espero no tengamos dos categorias en la misma disciplina con el mismo nombre
            txtCuota.Text = tabla.Rows[0][2].ToString();
        }

        private double calculartotal() //calcula el total que termina yendo al recibo
        {
            double total = 0;
            for (int i = 0; i < dgvDetalle.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvDetalle.Rows[i].Cells[4].Value.ToString());
            }
            return total;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bandera2)
            {
                llenarPrecioCuota();
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (validadores.ValidarTxt(txtNroSocio))
            {
                DataTable tabla = new DataTable();
                tabla = transaccion.buscarSocios(txtNroSocio.Text);
                if (tabla.Rows.Count > 0)
                    txtNombreSocio.Text = tabla.Rows[0][1].ToString() + " " + tabla.Rows[0][2].ToString();
                else
                    MessageBox.Show("No existe ningun socio con este numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreSocio.Text = string.Empty;
            txtNroSocio.Text = string.Empty;
            dgvDetalle.Rows.Clear();
            txtCliente.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombreSocio.Text == string.Empty)
                MessageBox.Show("Debe ingresar un numero de socio valido", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                dgvDetalle.Rows.Add(txtNroSocio.Text, txtNombreSocio.Text, cmbDisciplinas.Text, cmbCategoria.Text, txtCuota.Text, cmbMes.Text);
                txtTotal.Text = Convert.ToString(calculartotal());
            }
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count > 0)
            {
                transaccion.encabezado(txtTotal.Text, "Cuota Disciplina", txtCliente.Text, txtDomicilio.Text);
                bool existeBD = false; //bandera que uso para validar que no este tratando de cargar repetido
                bool socioInscripto = false;
                for (int i=0; i < dgvDetalle.Rows.Count; i++)
                {
                    DataTable tabla1 = new DataTable();
                    DataTable tabla2 = new DataTable();
                    tabla1 = transaccion.buscarIdDisciplina(dgvDetalle.Rows[i].Cells["disciplina"].Value.ToString());
                    int idSocio = Convert.ToInt32(dgvDetalle.Rows[i].Cells["idSocio"].Value.ToString());
                    int idDisciplina = Convert.ToInt32(tabla1.Rows[0][0]);
                    tabla2 = transaccion.buscarIdCategoria(dgvDetalle.Rows[i].Cells["categoria"].Value.ToString(), idDisciplina);
                    int idCategoria = Convert.ToInt32(tabla2.Rows[0][0]);
                    transaccion.detalle(idSocio, idDisciplina, idCategoria, dgvDetalle.Rows[i].Cells["mes"].Value.ToString());
                    socioInscripto = transaccion.validarValidez(idSocio, idCategoria, idDisciplina);
                    existeBD = transaccion.validarCuota(idSocio, idCategoria, idDisciplina, dgvDetalle.Rows[i].Cells["mes"].Value.ToString());
                }
                if (existeBD || socioInscripto)
                {
                    MessageBox.Show("Alguna de las cuotas ya estaba cargada o el socio no esta inscripto", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnLimpiarCampos_Click(sender, e);
                }
                else
                {
                    bool anduvo = transaccion.realizarTransaccion();
                    if (anduvo)
                    {
                        MessageBox.Show("La inscripción se realizo", "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string nroRecibo = transaccion.nroRecibo();
                        DataTable tabla = validadores.GetDataTableFromDGV(dgvDetalle);
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
            }
            else
                MessageBox.Show("No cargo ningun pago de cuota", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
