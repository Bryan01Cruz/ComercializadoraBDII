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
    public partial class AbonosProductor : Form
    {
        public AbonosProductor()
        {
            InitializeComponent();
        }

        private void txtCodigoProductor_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoProductor.Text.Trim();

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
                    txtProductor.Text = resultado.Rows[0]["Nombre"].ToString();
                }
                else
                {
                    txtProductor.Text = string.Empty;
                    MessageBox.Show("No se encontró el código.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductor.Focus();
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

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoProductor.Text) || cbbCosecha.Text == "" || cbbMetodo.Text == "" || nudMonto.Value == 0)
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
                    conector.CrearParametro("@agricultorID", txtCodigoProductor.Text.Trim()),
                    conector.CrearParametro("@cosechaID", cbbCosecha.Text.Trim()),
                    conector.CrearParametro("@fecha", dtpFecha.Text),
                    conector.CrearParametro("@metodoPago", cbbMetodo.Text),
                    conector.CrearParametro("@monto", nudMonto.Value),
                };

                    bool resultado = conector.EjecutarSP("spRegistrarAbonoAgricultor", parametros);

                    if (resultado)
                    {
                        MessageBox.Show("Abono registrado exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodigoProductor.Clear();
                        txtProductor.Clear();
                        cbbCosecha.Text = "";
                        dtpFecha.Value = DateTime.Now;
                        cbbMetodo.Text = "";
                        nudMonto.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al registrar los registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cbbCosecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCodigoProductor.Text, out int agricultorId))
                {
                    return;
                }

                var con = new ConectorSQL();
                string sql = @"SELECT dbo.fLiquidacionPendienteAgricultorPorCosecha
                   (@cosechaID, @agricultorID)";

                if (!int.TryParse(cbbCosecha.Text?.ToString(), out int cosechaId))
                {
                    return;
                }

                var param = new[]
                {
                    con.CrearParametro("@cosechaID",   cosechaId),
                    con.CrearParametro("@agricultorID", agricultorId)
    };

                decimal saldo = Convert.ToDecimal(con.EjecutarEscalar(sql, param));

                nudSaldo.Value = saldo;
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

        private void AbonosProductor_Load(object sender, EventArgs e)
        {

        }
    }
}
