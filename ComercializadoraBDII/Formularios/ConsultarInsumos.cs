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
    public partial class ConsultarInsumos : Form
    {
        public ConsultarInsumos()
        {
            InitializeComponent();
        }

        public DataTable CargarInventario(string filtro)
        {
            ConectorSQL conector = new ConectorSQL();
            DataTable dt = new DataTable();
            try
            {
                string sql = @"
                SELECT * 
                FROM vInventarioInsumos 
                WHERE Codigo LIKE @filtro OR Producto LIKE @filtro";

                var parametros = new[]
                {
            new SqlParameter("@filtro", "%" + filtro + "%")
        };

                dt = conector.EjecutarConsultaTexto(sql, parametros);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron insumos con ese filtro.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtBuscar.Text.Trim();
                dgvInsumos.DataSource = CargarInventario(filtro);
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

        private void ConsultarInsumos_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInsumos.DataSource = CargarInventario("");
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
