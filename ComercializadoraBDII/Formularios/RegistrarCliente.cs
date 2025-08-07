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
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void cbbTipoIdentidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTipoIdentidad.SelectedIndex == 0)
            {
                txtIdentidad.Mask = "####-####-#####";
            }
            if (cbbTipoIdentidad.SelectedIndex == 1)
            {
                txtIdentidad.Mask = "##############";
            }

        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtIdentidad.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||  cbbTipoIdentidad.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var conector = new ConectorSQL();

                    SqlParameter[] parametros = new SqlParameter[]
                {
                    conector.CrearParametro("@nombre", txtNombre.Text.Trim()),
                    conector.CrearParametro("@tipoIdentidad", cbbTipoIdentidad.Text),
                    conector.CrearParametro("@identidad", txtIdentidad.Text.Trim()),
                    conector.CrearParametro("@direccion", txtDireccion.Text.Trim()),
                    conector.CrearParametro("@telefono", txtTelefono.Text.Trim()),
                };

                    bool resultado = conector.EjecutarSP("spAgregarCliente", parametros);

                    if (resultado)
                    {
                        MessageBox.Show("Cliente registrado exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Clear();
                        txtIdentidad.Clear();
                        txtTelefono.Clear();
                        txtDireccion.Clear();
                        cbbTipoIdentidad.Text="";
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al registrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
