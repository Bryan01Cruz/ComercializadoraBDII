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
    public partial class UtilidadCosecha : Form
    {
        public UtilidadCosecha()
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
                FROM vw_UtilidadPorCosecha 
                WHERE CosechaID LIKE @filtro OR Nombre LIKE @filtro";

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
        private void UtilidadCosecha_Load(object sender, EventArgs e)
        {
            try
            {
                dgvUtilidad.DataSource = CargarInventario("");
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

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtBuscar.Text.Trim();
                dgvUtilidad.DataSource = CargarInventario(filtro);
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
