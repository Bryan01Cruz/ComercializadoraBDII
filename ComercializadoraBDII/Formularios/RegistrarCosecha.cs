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
    public partial class RegistrarCosecha : Form
    {
        public RegistrarCosecha()
        {
            InitializeComponent();
        }

        private void RegistrarCosecha_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || nudCantidad.Value == 0 || nudPrecio.Value == 0)
            {
                MessageBox.Show("Debe ingresar todos los campos para insertar un registro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agrega fila al DataGridView
            int nuevaFila = dgvCosecha.Rows.Add();
            dgvCosecha.Rows[nuevaFila].Cells["Codigo"].Value = txtCodigo.Text;
            dgvCosecha.Rows[nuevaFila].Cells["Producto"].Value = cbbProducto.Text;
            dgvCosecha.Rows[nuevaFila].Cells["Cantidad"].Value = nudCantidad.Value;
            dgvCosecha.Rows[nuevaFila].Cells["Unidad"].Value = txtUnidad.Text;
            dgvCosecha.Rows[nuevaFila].Cells["Precio"].Value = nudPrecio.Value;
            dgvCosecha.Rows[nuevaFila].Cells["Total"].Value = nudPrecio.Value * nudCantidad.Value;

            ConectorSQL.SumarTotal(dgvCosecha, "Total", txtTotal);

            // Limpieza
            txtCodigo.Clear();
            txtCodigo.Focus();
            cbbProducto.SelectedIndex = 0;
            nudCantidad.Value = 0;
            nudPrecio.Value = 0;
            txtUnidad.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validar si hay fila seleccionada
            if (dgvCosecha.CurrentRow == null || dgvCosecha.CurrentRow.IsNewRow)
            {
                MessageBox.Show("No hay ninguna fila válida seleccionada para eliminar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar esta fila?",
                                                        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                dgvCosecha.Rows.Remove(dgvCosecha.CurrentRow);
                ConectorSQL.SumarTotal(dgvCosecha, "Total", txtTotal);
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            var fila = dgvCosecha.CurrentRow;

            if (fila == null || fila.IsNewRow)
            {
                MessageBox.Show("No hay ninguna fila válida seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar antes de eliminar
            DialogResult confirmar = MessageBox.Show("¿Desea actualizar esta fila?",
                                                     "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                // Copia datos a los Text
                txtCodigo.Text = fila.Cells["Codigo"].Value?.ToString();
                cbbProducto.Text = fila.Cells["Producto"].Value?.ToString();
                txtUnidad.Text = fila.Cells["Unidad"].Value?.ToString();
                nudCantidad.Value = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                nudPrecio.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
                dgvCosecha.Rows.Remove(fila);
                ConectorSQL.SumarTotal(dgvCosecha, "Total", txtTotal);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoBodega_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtCodigoBodega.Text))
            //{
            //    MessageBox.Show("Ingrese el código de bodega a buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            try
            {
                string codigo = txtCodigoBodega.Text.Trim();

                var conector = new ConectorSQL();
                var parametros = new SqlParameter[]
                {
                    conector.CrearParametro("@Codigo", codigo)
                };

                DataTable resultado = conector.EjecutarConsulta("spBuscarBodega", parametros);

                if (resultado.Rows.Count > 0)
                {
                    txtBodega.Text = resultado.Rows[0]["Nombre"].ToString();
                    nudDisponible.Value = Convert.ToDecimal(resultado.Rows[0]["Espacio"]);
                }
                else
                {
                    txtBodega.Text = string.Empty;
                    nudDisponible.Value = 0;
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
            //}

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    string codigo = txtCodigo.Text.Trim();

            //    var conector = new ConectorSQL();
            //    var parametros = new SqlParameter[]
            //    {
            //            conector.CrearParametro("@Codigo", codigo)
            //    };

            //    DataTable resultado = conector.EjecutarConsulta("spBuscarProducto", parametros);

            //    if (resultado.Rows.Count > 0)
            //    {
            //        txtProducto.Text = resultado.Rows[0]["Nombre"].ToString();
            //        nudPrecio.Value = Convert.ToDecimal(resultado.Rows[0]["Precio"]);
            //        txtUnidad.Text = resultado.Rows[0]["Unidad"].ToString();
            //    }
            //    else
            //    {
            //        txtProducto.Text = string.Empty;
            //        MessageBox.Show("No se encontró el código ingresado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show($"Error de conexión o ejecución de consulta:\n{ex.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Ocurrió un error inesperado:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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

                conector2.CargarComboSoloNombre(cbbFincas, "spBuscarFincaCosecha", "Nombre", "", parametros2);
                DataTable resultado = conector.EjecutarConsulta("spBuscarProductor", parametros);


                if (resultado.Rows.Count > 0)
                {
                    txtProductor.Text = resultado.Rows[0]["Nombre"].ToString();
                }
                else
                {
                    txtProductor.Text = string.Empty;
                    MessageBox.Show("No se encontró el código.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigoProductor.Focus();
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

        public static DataTable CrearTablaDetalle()
        {
            var dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Unidad", typeof(string));
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
                    fila.Cells["Producto"].Value?.ToString(),
                    Convert.ToInt32(fila.Cells["Cantidad"].Value ?? 0),
                    fila.Cells["Unidad"].Value?.ToString(),
                    Convert.ToDecimal(fila.Cells["Precio"].Value ?? 0)
                );
            }
            return dt;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            var conector = new ConectorSQL();
            var tablaDetalle = CargarDesdeGrid(dgvCosecha);

            var parametros = new[]
            {
            conector.CrearParametro("@agricultorID", Convert.ToInt32(txtCodigoProductor.Text)),
            conector.CrearParametro("@finca", cbbFincas.Text),
            conector.CrearParametro("@bodega", txtBodega.Text),
            conector.CrearParametro("@fecha", dtpFechaEntrega.Value),
            new SqlParameter("@tDetalle", SqlDbType.Structured)
        {
            TypeName = "DetalleCosecha",
            Value = tablaDetalle
        }
    };

            bool resultado = conector.EjecutarSP("spRegistrarCosecha", parametros);
            MessageBox.Show(resultado ? "Registro exitoso" : "Ocurrió un error", "Resultado", MessageBoxButtons.OK, resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            dgvCosecha.Rows.Clear();
            txtBodega.Clear();
            txtCodigoBodega.Clear();
            nudDisponible.Value = 0;
            txtCodigo.Clear();
            nudCantidad.Value = 0;
            txtTotal.Clear();
            dtpFechaEntrega.Value= DateTime.Now;


        }

        private void cbbFincas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string finca = cbbFincas.Text;

                var conector = new ConectorSQL();
                var parametros = new SqlParameter[]
                {
                    conector.CrearParametro("@Finca", finca)
                };
                conector.CargarComboSoloNombre(cbbProducto, "spBuscarProductosFinca", "Nombre", "", parametros);
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

        private void cbbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string producto = cbbProducto.Text;

                var conector = new ConectorSQL();
                var parametros = new SqlParameter[]
                {
                    conector.CrearParametro("@Producto", producto)
                };
                DataTable resultado = conector.EjecutarConsulta("spBuscarCodigoProducto", parametros);

                if (resultado.Rows.Count > 0)
                {
                    txtCodigo.Text = resultado.Rows[0]["Codigo"].ToString();
                }
                //else
                //{
                //    MessageBox.Show("No se encontró el código.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
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
