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
    public partial class OrdenesCompra : Form
    {
        public OrdenesCompra()
        {
            InitializeComponent();
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            var conector = new ConectorSQL();

            SqlParameter[] parametros = new SqlParameter[]
            {
                conector.CrearParametro("@Codigo", txtCodigo.Text)
            };

            DataTable dt = conector.EjecutarConsulta("spBuscarOrden", parametros);

            if (dt.Rows.Count > 0)
            {
                txtProveedor.Text = dt.Rows[0]["Nombre"].ToString();

                dvgOrdenes.DataSource = dt;

                if (dt.Rows[0]["EstadoEntrega"].ToString() == "P")
                {
                    btRecibir.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No se encontraron datos para esa Orden de Compra.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void OrdenesCompra_Load(object sender, EventArgs e)
        {

        }

        private void btRecibir_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text.Trim();

                var conector = new ConectorSQL();
                var parametros = new SqlParameter[]
                {
                    conector.CrearParametro("@compraID", codigo)
                };

                bool resultado = conector.EjecutarSP("spRegistrarIngresoInsumos", parametros);

                if (resultado)
                {
                    MessageBox.Show("Orden de compra recibida.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btRecibir.Enabled=false;
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
