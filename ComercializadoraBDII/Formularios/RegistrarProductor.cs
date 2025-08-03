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

namespace ComercializadoraBDII.Formularios
{
    public partial class RegistrarProductor : Form
    {
        public RegistrarProductor()
        {
            InitializeComponent();
        }

        private void RegistrarProductor_Load(object sender, EventArgs e)
        {
            ConectorSQL conector = new ConectorSQL();
            conector.CargarComboSoloNombre(cbbBanco, "spObtenerBanco", "Nombre");
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtIdentidad.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtCuentaBancaria.Text) || cbbBanco.Text==""
                || cbbTipoCuenta.Text=="")
            {
                MessageBox.Show("Ingrese todos los datos y verifique si el correo es válido.","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var conector = new ConectorSQL();

                    SqlParameter[] parametros = new SqlParameter[]
                {
                    conector.CrearParametro("@nombre", txtNombre.Text.Trim()),
                    conector.CrearParametro("@dni", txtIdentidad.Text.Trim()),
                    conector.CrearParametro("@telefono", txtTelefono.Text.Trim()),
                    conector.CrearParametro("@direccion", txtDireccion.Text.Trim()),
                    conector.CrearParametro("@email", txtCorreo.Text.Trim()),
                    conector.CrearParametro("@nombreBanco", cbbBanco.Text),
                    conector.CrearParametro("@tipoCuenta", cbbTipoCuenta.Text),
                    conector.CrearParametro("@numCuenta", txtCuentaBancaria.Text.Trim())
                };

                    bool resultado = conector.EjecutarSP("spAgregarAgricultor", parametros);

                    if (resultado)
                    {
                        MessageBox.Show("Agricultor registrado exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Clear();
                        txtIdentidad.Clear();
                        txtTelefono.Clear();
                        txtDireccion.Clear();
                        txtCorreo.Clear();
                        txtCuentaBancaria.Clear();
                        cbbBanco.SelectedItem = 0;
                        cbbTipoCuenta.SelectedItem = 0;
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al registrar el agricultor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtCuentaBancaria_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCuentaBancaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
