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
    public partial class RegistrarFinca : Form
    {
        public RegistrarFinca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoProductor.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtFinca.Text) ||
                nudArea.Value == 0)
            {
                MessageBox.Show("Rellene todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var conector = new ConectorSQL();

                    SqlParameter[] parametros = new SqlParameter[]
                {
                    conector.CrearParametro("@agricultorID", txtCodigoProductor.Text.Trim()),
                    conector.CrearParametro("@nombre", txtFinca.Text.Trim()),
                    conector.CrearParametro("@ubicacion", txtDireccion.Text.Trim()),
                    conector.CrearParametro("@extension", nudArea.Value)
                };

                    bool resultado = conector.EjecutarSP("spAgregarFinca", parametros);

                    if (resultado)
                    {
                        MessageBox.Show("Finca registrada exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodigoProductor.Clear();
                        txtCodigoProductor.Focus();
                        txtProductor.Clear();
                        txtDireccion.Clear();
                        txtFinca.Clear();
                        nudArea.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al registrar la finca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtCodigoProductor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoProductor.Text))
            {
                MessageBox.Show("Ingrese el código de productor a buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string codigo = txtCodigoProductor.Text.Trim();

                    var conector = new ConectorSQL();
                    var parametros = new SqlParameter[]
                    {
                    conector.CrearParametro("@Codigo", codigo)
                    };

                    DataTable resultado = conector.EjecutarConsulta("spBuscarProductor", parametros);

                    if (resultado.Rows.Count > 0)
                    {
                        txtProductor.Text = resultado.Rows[0]["Nombre"].ToString();
                    }
                    else
                    {
                        txtProductor.Text = string.Empty;
                        MessageBox.Show("No se encontró el código ingresado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error de conexión o ejecución de consulta:\n{ex.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error inesperado:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
