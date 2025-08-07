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

namespace ComercializadoraBDII.Formularios.Consultas
{
    public partial class ProduccionPorProductor : Form
    {
        public ProduccionPorProductor()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public DataTable CargarInventario(string filtro)
        {
            ConectorSQL conector = new ConectorSQL();
            DataTable dt = new DataTable();
            try
            {
                string sql = @"
                SELECT * 
                FROM vw_SaldoPendienteProveedores 
                WHERE Proveedor LIKE @filtro OR ProveedorID LIKE @filtro";

                var parametros = new[]
                {
            new SqlParameter("@filtro", "%" + filtro + "%")
        };

                dt = conector.EjecutarConsultaTexto(sql, parametros);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos con ese filtro.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return dt;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtBuscar.Text.Trim();
                dgvSaldos.DataSource = CargarInventario(filtro);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProduccionPorProductor_Load(object sender, EventArgs e)
        {
            try
            {
                dgvSaldos.DataSource = CargarInventario("");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
