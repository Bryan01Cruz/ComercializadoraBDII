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
    public partial class EntregaInsumos : Form
    {
        public EntregaInsumos()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoInsumo.Text) || string.IsNullOrWhiteSpace(txtInsumo.Text) || nudCantidad.Value == 0 || nudPrecio.Value == 0 || string.IsNullOrWhiteSpace(txtUnidad.Text))
            {
                MessageBox.Show("Debe ingresar todos los campos para insertar un registro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nuevaFila = dgvEntregas.Rows.Add();
            dgvEntregas.Rows[nuevaFila].Cells["Codigo"].Value = txtCodigoInsumo.Text;
            dgvEntregas.Rows[nuevaFila].Cells["Insumo"].Value = txtInsumo.Text;
            dgvEntregas.Rows[nuevaFila].Cells["Cantidad"].Value = nudCantidad.Value;
            dgvEntregas.Rows[nuevaFila].Cells["Unidad"].Value = txtUnidad.Text;
            dgvEntregas.Rows[nuevaFila].Cells["Precio"].Value = nudPrecio.Value;
            if (cbbDescuento.Text == "0%")
            {
                dgvEntregas.Rows[nuevaFila].Cells["Descuento"].Value = nudPrecio.Value * 0;
            }
            else
            {
                dgvEntregas.Rows[nuevaFila].Cells["Descuento"].Value = nudPrecio.Value * Convert.ToDecimal(0.05);
            }
            dgvEntregas.Rows[nuevaFila].Cells["Total"].Value = nudPrecio.Value * nudCantidad.Value;

            ConectorSQL.SumarTotal(dgvEntregas, "Total", txtSubtotal);

            txtCodigoInsumo.Clear();
            txtCodigoInsumo.Focus();
            txtInsumo.Clear();
            nudCantidad.Value = 0;
            nudPrecio.Value = 0;
            txtUnidad.Clear();

            txtIGO.Text = (Convert.ToDouble(txtSubtotal.Text) * 0.05).ToString();
            ConectorSQL.SumarTotal(dgvEntregas, "Descuento", txtDescuento);
            txtTotal.Text = (Convert.ToDouble(txtSubtotal.Text) - Convert.ToDouble(txtIGO.Text)).ToString();
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
                        MessageBox.Show("No se encontró el código de productor ingresado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtCodigoInsumo_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoInsumo.Text.Trim();

                var conector = new ConectorSQL();
                var parametros = new SqlParameter[]
                {
                        conector.CrearParametro("@Codigo", codigo)
                };

                DataTable resultado = conector.EjecutarConsulta("spBuscarInsumo", parametros);

                if (resultado.Rows.Count > 0)
                {
                    txtInsumo.Text = resultado.Rows[0]["Nombre"].ToString();
                    nudPrecio.Value = Convert.ToDecimal(resultado.Rows[0]["Precio"]);
                    txtUnidad.Text = resultado.Rows[0]["Unidad"].ToString();
                }
                else
                {
                    txtInsumo.Text = string.Empty;
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

        private void btEliminar_Click(object sender, EventArgs e)
        {
            // Validar si hay fila seleccionada
            if (dgvEntregas.CurrentRow == null || dgvEntregas.CurrentRow.IsNewRow)
            {
                MessageBox.Show("No hay ninguna fila válida seleccionada para eliminar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar esta fila?",
                                                        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                dgvEntregas.Rows.Remove(dgvEntregas.CurrentRow);
                ConectorSQL.SumarTotal(dgvEntregas, "Total", txtSubtotal);
                txtIGO.Text = (Convert.ToDouble(txtSubtotal.Text) * 0.05).ToString();
                ConectorSQL.SumarTotal(dgvEntregas, "Descuento", txtDescuento);
                txtTotal.Text = (Convert.ToDouble(txtSubtotal.Text) - Convert.ToDouble(txtIGO.Text)).ToString();

            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            var fila = dgvEntregas.CurrentRow;

            if (fila == null || fila.IsNewRow)
            {
                MessageBox.Show("No hay ninguna fila válida seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmar = MessageBox.Show("¿Desea actualizar esta fila?",
                                                     "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                dgvEntregas.Rows.Remove(fila);
                ConectorSQL.SumarTotal(dgvEntregas, "Total", txtSubtotal);
                txtIGO.Text = (Convert.ToDouble(txtSubtotal.Text) * 0.05).ToString();
                ConectorSQL.SumarTotal(dgvEntregas, "Descuento", txtDescuento);
                txtTotal.Text = (Convert.ToDouble(txtSubtotal.Text) - Convert.ToDouble(txtIGO.Text)).ToString();
             
                txtCodigoInsumo.Text = fila.Cells["Codigo"].Value?.ToString();
                txtInsumo.Text = fila.Cells["Insumo"].Value?.ToString();
                txtUnidad.Text = fila.Cells["Unidad"].Value?.ToString();
                nudCantidad.Value = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                nudPrecio.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
            }
        }

        private void EntregaInsumos_Load(object sender, EventArgs e)
        {
            cbbDescuento.Text = "0%";
        }

        public static DataTable CrearTablaDetalle()
        {
            var dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Insumo", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Unidad", typeof(string));
            dt.Columns.Add("Descuento", typeof(decimal));
            dt.Columns.Add("Precio", typeof(decimal));

            return dt;
        }

        public static DataTable CargarDesdeGrid(DataGridView dgv)
        {
            var dt = CrearTablaDetalle();
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.IsNewRow) continue;

                dt.Rows.Add(
                    fila.Cells["Codigo"].Value?.ToString(),
                    fila.Cells["Insumo"].Value?.ToString(),
                    Convert.ToInt32(fila.Cells["Cantidad"].Value ?? 0),
                    fila.Cells["Unidad"].Value?.ToString(),
                    Convert.ToDecimal(fila.Cells["Descuento"].Value ?? 0),
                    Convert.ToDecimal(fila.Cells["Precio"].Value ?? 0)

                );
            }
            return dt;
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            var conector = new ConectorSQL();
            var tablaDetalle = CargarDesdeGrid(dgvEntregas);

            var parametros = new[]
            {
            conector.CrearParametro("@agricultorID", Convert.ToInt32(txtCodigoProductor.Text)),
            conector.CrearParametro("@fecha", dtpFechaEntrega.Value),
            new SqlParameter("@tDetalle", SqlDbType.Structured)
        {
            TypeName = "DetalleInsumo",
            Value = tablaDetalle
        }
        };

            bool resultado = conector.EjecutarSP("spRegistrarInsumosAgricultor", parametros);
            MessageBox.Show(resultado ? "Registro exitoso" : "Ocurrió un error", "Resultado", MessageBoxButtons.OK, resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            dgvEntregas.Rows.Clear();
            txtTotal.Clear();
            txtSubtotal.Clear();
            txtIGO.Clear();
            txtInsumo.Clear();
            txtCodigoInsumo.Clear();
            txtUnidad.Clear();
            txtDescuento.Clear();
            dtpFechaEntrega.Value = DateTime.Now;
            txtCodigoProductor.Clear();
            txtProductor.Clear();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
