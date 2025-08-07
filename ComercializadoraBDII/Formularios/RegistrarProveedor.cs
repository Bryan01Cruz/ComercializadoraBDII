using ComercializadoraBDII.Clases;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComercializadoraBDII.Formularios
{
    public partial class RegistrarProveedor : Form
    {
        public RegistrarProveedor()
        {
            InitializeComponent();
        }

        private void RegistrarProveedor_Load(object sender, EventArgs e)
        {
            ConectorSQL conector = new ConectorSQL();
            conector.CargarComboSoloNombre(cbbTipoProveedor, "spObtenerTipoProveedor", "Nombre");
            conector.CargarComboSoloNombre(cbbBanco, "spObtenerBanco", "Nombre");
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (!txtCorreo.Text.Contains("@") || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtContacto.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtRtn.Text) || cbbTipoProveedor.Text == "" ||
                string.IsNullOrWhiteSpace(txtCuentaBancaria.Text) || cbbBanco.Text == "" || cbbTipoCuenta.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos y verifique si el correo es válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var conector = new ConectorSQL();

                    SqlParameter[] parametros = new SqlParameter[]
                {
                    conector.CrearParametro("@proveedor", txtNombre.Text.Trim()),
                    conector.CrearParametro("@tipoproveedor", cbbTipoProveedor.Text),
                    conector.CrearParametro("@contacto", txtContacto.Text.Trim()),
                    conector.CrearParametro("@direccion", txtDireccion.Text.Trim()),
                    conector.CrearParametro("@telefono", txtTelefono.Text.Trim()),
                    conector.CrearParametro("@correo", txtCorreo.Text.Trim()),
                    conector.CrearParametro("@rtn", txtRtn.Text.Trim()),
                    conector.CrearParametro("@condCredito", txtCondiciones.Text.Trim()),
                    conector.CrearParametro("@nombreBanco", cbbBanco.Text),
                    conector.CrearParametro("@numCuenta", txtCuentaBancaria.Text.Trim()),
                    conector.CrearParametro("@tipoCuenta", cbbTipoCuenta.Text)
                };

                    bool resultado = conector.EjecutarSP("spAgregarProveedor", parametros);

                    if (resultado)
                    {
                        MessageBox.Show("Proveedor registrado exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Clear();
                        txtContacto.Clear();
                        txtTelefono.Clear();
                        txtDireccion.Clear();
                        txtCorreo.Clear();
                        txtCuentaBancaria.Clear();
                        cbbBanco.SelectedItem = 0;
                        cbbTipoCuenta.SelectedItem = 0;
                        cbbTipoProveedor.SelectedItem = 0;
                        txtCondiciones.Clear();
                        txtRtn.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al registrar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error SQL: " + ex.Message, "Excepción SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error general: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtRtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRtn_Leave(object sender, EventArgs e)
        {
            if(txtRtn.TextLength < 14 || txtRtn.TextLength>14)
            {
                MessageBox.Show("El RTN debe tener 14 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
