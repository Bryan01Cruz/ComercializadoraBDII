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
    public partial class LiquidacionCosecha : Form
    {
        public LiquidacionCosecha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || cbbCosecha.Text == "" || cbbMetodo.Text == "" || nudMonto.Value == 0)
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
                    conector.CrearParametro("@agricultorID", txtCodigo.Text.Trim()),
                    conector.CrearParametro("@cosechaID", cbbCosecha.Text.Trim()),
                    conector.CrearParametro("@fecha", dtpFecha.Text),
                    conector.CrearParametro("@metodoPago", cbbMetodo.Text),
                    conector.CrearParametro("@monto", nudMonto.Value),
                };

                    bool resultado = conector.EjecutarSP("spRegistrarLiquidacionAgricultor", parametros);

                    if (resultado)
                    {
                        MessageBox.Show("Liquidación registradoa exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodigo.Clear();
                        cbbCosecha.Text = "";
                        dtpFecha.Value = DateTime.Now;
                        cbbMetodo.Text = "";
                        nudMonto.Value = 0;
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

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text.Trim();

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

                conector2.CargarComboSoloNombre(cbbCosecha, "spBuscarCosechaCodigo", "CosechaID", "", parametros2);
                DataTable resultado = conector.EjecutarConsulta("spBuscarProductor", parametros);


                if (resultado.Rows.Count > 0)
                {
                    txtNombre.Text = resultado.Rows[0]["Nombre"].ToString();
                }
                else
                {
                    txtNombre.Text = string.Empty;
                    MessageBox.Show("No se encontró el código.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Focus();
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

        private void cbbCosecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /* 1. Obtener los IDs seleccionados -------------------------------- */
                

                if (!int.TryParse(txtCodigo.Text, out int agricultorId))
                {
                    //MessageBox.Show("Código de agricultor inválido.");
                    return;
                }

                /* 2. Preparar y ejecutar la función ------------------------------- */
                var con = new ConectorSQL();
                string sql = @"SELECT dbo.fLiquidacionPendienteAgricultorPorCosecha
                   (@cosechaID, @agricultorID)";

                if (!int.TryParse(cbbCosecha.Text?.ToString(), out int cosechaId))
                {
                    //MessageBox.Show("Seleccione una cosecha válida.");
                    return;
                }

                var param = new[]
                {
                    con.CrearParametro("@cosechaID",   cosechaId),
                    con.CrearParametro("@agricultorID", agricultorId)
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
