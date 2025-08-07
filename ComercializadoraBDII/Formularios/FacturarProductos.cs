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
    public partial class FacturarProductos : Form
    {
        public FacturarProductos()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoCliente.Text))
            {
                MessageBox.Show("Ingrese el código de proveedor a buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string codigo = txtCodigoCliente.Text.Trim();

                    var conector = new ConectorSQL();
                    var parametros = new SqlParameter[]
                    {
                    conector.CrearParametro("@Codigo", codigo)
                    };

                    DataTable resultado = conector.EjecutarConsulta("spBuscarCliente", parametros);

                    if (resultado.Rows.Count > 0)
                    {
                        txtCliente.Text = resultado.Rows[0]["Nombre"].ToString();
                    }
                    else
                    {
                        txtCliente.Text = string.Empty;
                        MessageBox.Show("No se encontró el código de proveedor ingresado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btActualizar_Click(object sender, EventArgs e)
        {
            var fila = dvgProductos.CurrentRow;

            if (fila == null || fila.IsNewRow)
            {
                MessageBox.Show("No hay ninguna fila válida seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            DialogResult confirmar = MessageBox.Show("¿Desea actualizar esta fila?",
                                                     "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                
                ConectorSQL.SumarTotal(dvgProductos, "Total", txtSubtotal);
                txtDescuento.Text = (Convert.ToDouble(txtSubtotal.Text) * 0.15).ToString();
                ConectorSQL.SumarTotal(dvgProductos, "Descuento", txtDescuento);
                txtTotal.Text = (Convert.ToDouble(txtSubtotal.Text) + Convert.ToDouble(txtDescuento.Text) - Convert.ToDouble(txtDescuento.Text)).ToString();
                txtCodigo.Text = fila.Cells["Codigo"].Value?.ToString();
                txtProducto.Text = fila.Cells["Producto"].Value?.ToString();
                cbbUnidad.Text = fila.Cells["Unidad"].Value?.ToString();
                nudCantidad.Value = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                nudPrecio.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
                dvgProductos.Rows.Remove(fila);
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dvgProductos.CurrentRow == null || dvgProductos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("No hay ninguna fila válida seleccionada para eliminar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar esta fila?",
                                                        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                dvgProductos.Rows.Remove(dvgProductos.CurrentRow);
                ConectorSQL.SumarTotal(dvgProductos, "Total", txtSubtotal);
                txtImpuesto.Text = (Convert.ToDouble(txtSubtotal.Text) * 0.15).ToString();
                ConectorSQL.SumarTotal(dvgProductos, "Descuento", txtDescuento);
                txtTotal.Text = (Convert.ToDouble(txtSubtotal.Text) + Convert.ToDouble(txtImpuesto.Text) - Convert.ToDouble(txtDescuento.Text)).ToString();

            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtProducto.Text) || nudCantidad.Value == 0 || nudPrecio.Value == 0 || cbbUnidad.Text=="")
            {
                MessageBox.Show("Debe ingresar todos los campos para insertar un registro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nuevaFila = dvgProductos.Rows.Add();
            dvgProductos.Rows[nuevaFila].Cells["Codigo"].Value = txtCodigo.Text;
            dvgProductos.Rows[nuevaFila].Cells["Producto"].Value = txtProducto.Text;
            dvgProductos.Rows[nuevaFila].Cells["Cantidad"].Value = nudCantidad.Value;
            dvgProductos.Rows[nuevaFila].Cells["Unidad"].Value = cbbUnidad.Text;
            if (cbbDescuento.Text == "0%")
            {
                dvgProductos.Rows[nuevaFila].Cells["Descuento"].Value = 0;
            }
            if (dvgProductos.Text == "5%")
            {
                dvgProductos.Rows[nuevaFila].Cells["Descuento"].Value = 0.05;
            }
            dvgProductos.Rows[nuevaFila].Cells["Precio"].Value = nudPrecio.Value;
            dvgProductos.Rows[nuevaFila].Cells["Total"].Value = nudPrecio.Value * nudCantidad.Value * (1 - Convert.ToDecimal(dvgProductos.Rows[nuevaFila].Cells["Descuento"].Value));
            //if (cbbDescuento.Text == "0%")
            //{
            //    dvgProductos.Rows[nuevaFila].Cells["Descuento"].Value = nudPrecio.Value * 0;
            //}
            //else
            //{
            //    dvgProductos.Rows[nuevaFila].Cells["Descuento"].Value = nudPrecio.Value * Convert.ToDecimal(0.05);
            //}
            //dvgProductos.Rows[nuevaFila].Cells["Precio"].Value = nudPrecio.Value;
            //dvgProductos.Rows[nuevaFila].Cells["Total"].Value = nudPrecio.Value * nudCantidad.Value;

            ConectorSQL.SumarTotal(dvgProductos, "Total", txtSubtotal);

            txtCodigo.Clear();
            txtCodigo.Focus();
            txtProducto.Clear();
            nudCantidad.Value = 0;
            nudPrecio.Value = 0;
            cbbUnidad.Text = "";
            txtUnidad.Clear();

            txtImpuesto.Text = (Convert.ToDouble(txtSubtotal.Text) * 0.15).ToString();
            ConectorSQL.SumarTotal(dvgProductos, "Descuento", txtDescuento);
            txtTotal.Text = (Convert.ToDouble(txtSubtotal.Text) + Convert.ToDouble(txtImpuesto.Text) - Convert.ToDouble(txtDescuento.Text)).ToString();
        }

        public static DataTable CrearTablaDetalle()
        {
            var dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Cantidad", typeof(decimal));
            dt.Columns.Add("Unidad", typeof(string));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Descuento", typeof(decimal));
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
                    Convert.ToDecimal(fila.Cells["Cantidad"].Value ?? 0),
                    fila.Cells["Unidad"].Value?.ToString(),
                    Convert.ToDecimal(fila.Cells["Precio"].Value ?? 0),
                    Convert.ToDecimal(fila.Cells["Descuento"].Value ?? 0)
                );
            }
            return dt;
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            var conector = new ConectorSQL();
            var tablaDetalle = CargarDesdeGrid(dvgProductos);

            var parametros = new[]
            {
            conector.CrearParametro("@clienteID", Convert.ToInt32(txtCodigoCliente.Text)),
            conector.CrearParametro("@tipo", cbbTipoPago.Text),
            conector.CrearParametro("@fecha", dtpFecha.Value),
            new SqlParameter("@tDetalle", SqlDbType.Structured)
        {
            TypeName = "DetalleVenta",
            Value = tablaDetalle
        }
        };

            bool resultado = conector.EjecutarSP("spFacturarProductos", parametros);
            MessageBox.Show(resultado ? "Registro exitoso" : "Ocurrió un error", "Resultado", MessageBoxButtons.OK, resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            dvgProductos.Rows.Clear();
            txtCliente.Clear();
            txtCodigoCliente.Clear();
            txtCodigo.Clear();
            txtDescuento.Clear();
            txtImpuesto.Clear();
            txtProducto.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
            txtUnidad.Clear();
            cbbDescuento.Text = "0%";
            nudCantidad.Value = 0;
            nudPrecio.Value = 0;
            dtpFecha.Value = DateTime.Now;
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text.Trim();
                string unidad = cbbUnidad.Text.Trim();

                var conector = new ConectorSQL();
                var parametros = new SqlParameter[]
                {
                        conector.CrearParametro("@Codigo", codigo),
                        conector.CrearParametro("@Unidad", unidad)
                };

                DataTable resultado = conector.EjecutarConsulta("spBuscarProductoVenta", parametros);

                if (resultado.Rows.Count > 0)
                {
                    txtProducto.Text = resultado.Rows[0]["Nombre"].ToString();
                    nudPrecio.Value = Convert.ToDecimal(resultado.Rows[0]["Precio"]);
                    txtUnidad.Text = resultado.Rows[0]["Unidad"].ToString();
                }
                else
                {
                    txtProducto.Text = string.Empty;
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

        private void FacturarProductos_Load(object sender, EventArgs e)
        {
            cbbDescuento.Text = "0%";
        }
    }
}
