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
    public partial class RegistrarLote : Form
    {
        public RegistrarLote()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarLote_Load(object sender, EventArgs e)
        {
            try
            {
                ConectorSQL conector = new ConectorSQL();
                conector.CargarComboSoloNombre(cbbTipoRiego, "spObtenerTipoRiego", "Nombre");
                conector.CargarComboSoloNombre(cbbTipoSuelo, "spObtenerTipoSuelo", "Nombre");
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoFinca.Text) || string.IsNullOrWhiteSpace(txtFinca.Text) || string.IsNullOrWhiteSpace(txtCodigoProducto.Text) ||
                string.IsNullOrWhiteSpace(txtProducto.Text) || nudArea.Value == 0 || cbbTipoSuelo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var conector = new ConectorSQL();

                    SqlParameter[] parametros = new SqlParameter[]
                {
                    conector.CrearParametro("@fincaID", txtCodigoFinca.Text.Trim()),
                    conector.CrearParametro("@codigoProducto", txtCodigoProducto.Text.Trim()),
                    conector.CrearParametro("@nombre", txtProducto.Text.Trim()),
                    conector.CrearParametro("@extension", nudArea.Value),
                    conector.CrearParametro("@tipoSuelo", cbbTipoSuelo.Text),
                    conector.CrearParametro("@tipoRiego", cbbTipoRiego.Text)
                };

                    bool resultado = conector.EjecutarSP("spAgregarLoteFinca", parametros);

                    if (resultado)
                    {
                        MessageBox.Show("Lote registrado exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodigoProducto.Clear();
                        txtProducto.Clear();
                        nudArea.Value = 0;
                        cbbTipoRiego.SelectedIndex = 0;
                        cbbTipoSuelo.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al registrar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtCodigoFinca_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoFinca.Text))
            {
                MessageBox.Show("Ingrese el código de finca a buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string codigo = txtCodigoFinca.Text.Trim();

                    var conector = new ConectorSQL();
                    var parametros = new SqlParameter[]
                    {
                    conector.CrearParametro("@Codigo", codigo)
                    };

                    DataTable resultado = conector.EjecutarConsulta("spBuscarFinca", parametros);

                    if (resultado.Rows.Count > 0)
                    {
                        txtFinca.Text = resultado.Rows[0]["Nombre"].ToString();
                    }
                    else
                    {
                        txtFinca.Text = string.Empty;
                        MessageBox.Show("No se encontró el código de finca ingresado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoProducto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoProducto.Text))
            {
                MessageBox.Show("Ingrese el código de finca a buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string codigo = txtCodigoProducto.Text.Trim();

                    var conector = new ConectorSQL();
                    var parametros = new SqlParameter[]
                    {
                    conector.CrearParametro("@Codigo", codigo)
                    };

                    DataTable resultado = conector.EjecutarConsulta("spBuscarProducto", parametros);

                    if (resultado.Rows.Count > 0)
                    {
                        txtProducto.Text = resultado.Rows[0]["Nombre"].ToString();
                    }
                    else
                    {
                        txtProducto.Text = string.Empty;
                        MessageBox.Show("No se encontró el código de producto ingresado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
