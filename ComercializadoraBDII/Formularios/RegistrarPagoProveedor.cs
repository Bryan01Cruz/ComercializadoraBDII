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
    public partial class RegistrarPagoProveedor : Form
    {
        public RegistrarPagoProveedor()
        {
            InitializeComponent();
        }

        private void txtCodigoProveedor_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoProveedor.Text.Trim();

                var conector = new ConectorSQL();
                var parametros = new SqlParameter[]
                {
                    conector.CrearParametro("@Codigo", codigo)
                };

                var conector2 = new ConectorSQL();
                var parametros2 = new SqlParameter[]
                {
                        conector2.CrearParametro("@Codigo", codigo)
                };

                conector2.CargarComboSoloNombre(cbbCompra, "spBuscarCompraCodigo", "CompraID", "", parametros2);
                DataTable resultado = conector.EjecutarConsulta("spBuscarProveedor", parametros);


                if (resultado.Rows.Count > 0)
                {
                    txtProveedor.Text = resultado.Rows[0]["Nombre"].ToString();
                }
                else
                {
                    txtProveedor.Text = string.Empty;
                    MessageBox.Show("No se encontró el código.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtCompra_Leave(object sender, EventArgs e)
        {
            
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoProveedor.Text) || cbbMetodo.Text == "" || cbbCompra.Text=="" || nudMonto.Value == 0)
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
                    conector.CrearParametro("@proveedorID", Convert.ToInt32(txtCodigoProveedor.Text.Trim())),
                    conector.CrearParametro("@compraInsumoID",  Convert.ToInt32(cbbCompra.Text.Trim())),
                    conector.CrearParametro("@fecha", dtpFecha.Text),
                    conector.CrearParametro("@metodoPago", cbbMetodo.Text),
                    conector.CrearParametro("@monto", nudMonto.Value),
                };

                    bool resultado = conector.EjecutarSP("spRegistrarPagoProveedor", parametros);

                    if (resultado)
                    {
                        MessageBox.Show("Pago registrado exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodigoProveedor.Clear();
                        txtProveedor.Text = "";
                        dtpFecha.Value = DateTime.Now;
                        cbbMetodo.Text = "";
                        nudMonto.Value = 0;
                        txtCompra.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al registrar el pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cbbCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCodigoProveedor.Text, out int proveedorId))
                {

                    return;
                }


                var con = new ConectorSQL();
                string sql = @"SELECT DBO.fSaldoPendienteProveedorPorCompra(@proveedorID,@compraInsumosID)";

                if (!int.TryParse(cbbCompra.Text?.ToString(), out int CompraId))
                {

                    return;
                }

                var param = new[]
                {
                    con.CrearParametro("@proveedorID",   proveedorId),
                    con.CrearParametro("@compraInsumosID", CompraId)
    };

                decimal saldo = Convert.ToDecimal(con.EjecutarEscalar(sql, param));

                nudMonto.Value = saldo;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de conexión o ejecución de consulta:\n{ex.Message}",
                                "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
