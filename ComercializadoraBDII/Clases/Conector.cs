using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace ComercializadoraBDII.Clases
{
public class ConectorSQL
    {
        private readonly string _cadenaConexion;

        public ConectorSQL()
        {
            _cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }

        public bool EjecutarSP(string nombreSP, SqlParameter[] parametros)
        {
            using (SqlConnection con = ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(nombreSP, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parametros);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar SP: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable EjecutarConsulta(string nombreSP, SqlParameter[] parametros)
        {
            using (SqlConnection con = ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(nombreSP, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parametros);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public SqlParameter CrearParametro(string nombre, object valor)
        {
            return new SqlParameter(nombre, valor ?? DBNull.Value);
        }


        public static void SumarTotal(DataGridView dgv, string nombreColumna, TextBox txtDestino)
        {
            if (dgv == null || txtDestino == null || string.IsNullOrWhiteSpace(nombreColumna)) return;

            decimal total = 0;

            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.IsNewRow) continue;

                if (decimal.TryParse(fila.Cells[nombreColumna].Value?.ToString(), out decimal valor))
                    total += valor;
            }

            txtDestino.Text = total.ToString();
        }

        public static void GuardarDataGrid(DataGridView dgv, string spNombre, string[] nombresParametros, string[] columnasGrid, ConectorSQL conector)
        {
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.IsNewRow) continue;

                var parametros = new List<SqlParameter>();

                for (int i = 0; i < nombresParametros.Length; i++)
                {
                    object valor = fila.Cells[columnasGrid[i]].Value ?? DBNull.Value;
                    parametros.Add(new SqlParameter(nombresParametros[i], valor));
                }

                bool resultado = conector.EjecutarSP(spNombre, parametros.ToArray());
                if (!resultado)
                {
                    MessageBox.Show($"Error al guardar fila: {fila.Index}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CargarComboSoloNombre(
        ComboBox combo,
        string nombreSP,
        string campoNombre,
        string textoInicial = "",
        SqlParameter[] parametros = null)
        {
            try
            {
                parametros ??= new SqlParameter[0];

                DataTable tabla = EjecutarConsulta(nombreSP, parametros);

                if (tabla == null)
                {
                    MessageBox.Show("No se pudo obtener datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insertar ítem inicial
                DataRow filaInicial = tabla.NewRow();
                filaInicial[campoNombre] = textoInicial;
                tabla.Rows.InsertAt(filaInicial, 0);

                // Asignar solo DisplayMember
                combo.DataSource = tabla;
                combo.DisplayMember = campoNombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ComboBox: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


