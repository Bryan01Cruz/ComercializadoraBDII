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
    public partial class AgregarInsumo : Form
    {
        public AgregarInsumo()
        {
            InitializeComponent();
        }

        private void AgregarInsumo_Load(object sender, EventArgs e)
        {
            try
            {
                ConectorSQL conector = new ConectorSQL();
                conector.CargarComboSoloNombre(cbbUnidad, "spObtenerMedida", "Nombre");
                conector.CargarComboSoloNombre(cbbTipoInsumo, "spObtenerTipoInsumo", "Nombre");
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

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                cbbTipoInsumo.Text == "" || cbbUnidad.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos y verifique si el correo es válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var conector = new ConectorSQL();

                    SqlParameter[] parametros = new SqlParameter[]
                {
                    conector.CrearParametro("@nombre", txtNombre.Text.Trim()),
                    conector.CrearParametro("@tipoInsumo", cbbTipoInsumo.Text),
                    conector.CrearParametro("@descripcion", txtDescripcion.Text.Trim()),
                    conector.CrearParametro("@unidadMedida", cbbUnidad.Text)
                };

                    bool resultado = conector.EjecutarSP("spAgregarInsumo", parametros);

                    if (resultado)
                    {
                        MessageBox.Show("Insumo registrado exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Clear();
                        txtNombre.Focus();
                        txtDescripcion.Clear();
                        cbbTipoInsumo.SelectedItem = 0;
                        cbbUnidad.SelectedItem = 0;
                        
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al registrar el insumo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
