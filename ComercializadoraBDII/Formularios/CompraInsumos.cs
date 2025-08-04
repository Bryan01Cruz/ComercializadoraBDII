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
    public partial class CompraInsumos : Form
    {

        public CompraInsumos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.AgregarInsumo forma = new Formularios.AgregarInsumo();
            forma.ShowDialog();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(txtCodigoInsumo.Text) || string.IsNullOrWhiteSpace(txtInsumo.Text) || nudCantidad.Value == 0 || nudPrecio.Value == 0 || string.IsNullOrWhiteSpace(txtUnidad.Text))
            {
                MessageBox.Show("Debe ingresar todos los campos para insertar un registro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar fila al DataGridView
            int nuevaFila = dgvInsumos.Rows.Add();
            dgvInsumos.Rows[nuevaFila].Cells["Codigo"].Value = txtCodigoInsumo.Text;
            dgvInsumos.Rows[nuevaFila].Cells["Insumo"].Value = txtInsumo.Text;
            dgvInsumos.Rows[nuevaFila].Cells["Cantidad"].Value = nudCantidad.Value;
            dgvInsumos.Rows[nuevaFila].Cells["Unidad"].Value = txtUnidad.Text;
            dgvInsumos.Rows[nuevaFila].Cells["Precio"].Value = nudPrecio.Value;
            dgvInsumos.Rows[nuevaFila].Cells["Total"].Value = nudPrecio.Value * nudCantidad.Value;

            ConectorSQL.SumarTotal(dgvInsumos, "Total", txtSubtotal);

            // Limpieza
            txtCodigoInsumo.Clear();
            txtCodigoInsumo.Focus();
            txtInsumo.Clear();
            nudCantidad.Value = 0;
            nudPrecio.Value = 0;
            txtUnidad.Clear();

            txtImpuesto.Text = (Convert.ToDouble(txtSubtotal.Text) * 0.15).ToString();
            txtTotal.Text = (Convert.ToDouble(txtSubtotal.Text) + Convert.ToDouble(txtImpuesto.Text)).ToString();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            // Validar si hay fila seleccionada
            if (dgvInsumos.CurrentRow == null || dgvInsumos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("No hay ninguna fila válida seleccionada para eliminar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar esta fila?",
                                                        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                dgvInsumos.Rows.Remove(dgvInsumos.CurrentRow);
                ConectorSQL.SumarTotal(dgvInsumos, "Total", txtSubtotal);
                txtImpuesto.Text = (Convert.ToDouble(txtSubtotal.Text) * 0.15).ToString();
                txtTotal.Text = (Convert.ToDouble(txtSubtotal.Text) + Convert.ToDouble(txtImpuesto.Text)).ToString();
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            var fila = dgvInsumos.CurrentRow;

            if (fila == null || fila.IsNewRow)
            {
                MessageBox.Show("No hay ninguna fila válida seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Copia datos a los Text
            txtCodigoInsumo.Text = fila.Cells["Codigo"].Value?.ToString();
            txtInsumo.Text = fila.Cells["Producto"].Value?.ToString();
            txtUnidad.Text = fila.Cells["Unidad"].Value?.ToString();
            nudCantidad.Value = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
            nudPrecio.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);

            // Confirmar antes de eliminar
            DialogResult confirmar = MessageBox.Show("¿Desea actualizar esta fila?",
                                                     "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                dgvInsumos.Rows.Remove(fila);
                ConectorSQL.SumarTotal(dgvInsumos, "Total", txtSubtotal);
                txtImpuesto.Text = (Convert.ToDouble(txtSubtotal.Text) * 0.15).ToString();
                txtTotal.Text = (Convert.ToDouble(txtSubtotal.Text) + Convert.ToDouble(txtImpuesto.Text)).ToString();
            }
        }

        private void CompraInsumos_Load(object sender, EventArgs e)
        {
            cbbEstado.Text = "Pendiente";
        }

        private void txtCodigoProveedor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoProveedor.Text))
            {
                MessageBox.Show("Ingrese el código de proveedor a buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string codigo = txtCodigoProveedor.Text.Trim();

                    var conector = new ConectorSQL();
                    var parametros = new SqlParameter[]
                    {
                    conector.CrearParametro("@Codigo", codigo)
                    };

                    DataTable resultado = conector.EjecutarConsulta("spBuscarProveedor", parametros);

                    if (resultado.Rows.Count > 0)
                    {
                        txtProveedor.Text = resultado.Rows[0]["Nombre"].ToString();
                    }
                    else
                    {
                        txtProveedor.Text = string.Empty;
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

        private void btGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
