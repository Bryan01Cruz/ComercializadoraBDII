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
    public partial class AgregarBodega : Form
    {
        public AgregarBodega()
        {
            InitializeComponent();
        }

        private void AgregarBodega_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text) || nudCapacidad.Value == 0)
            {
                MessageBox.Show("Rellene todos los campos antes de guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var conector = new ConectorSQL();

                    SqlParameter[] parametros = new SqlParameter[]
                {
                    conector.CrearParametro("@nombre", txtNombre.Text.Trim()),
                    conector.CrearParametro("@desc", txtDescripcion.Text.Trim()),
                    conector.CrearParametro("@espacio", nudCapacidad.Value)
                };

                    bool resultado = conector.EjecutarSP("spAgregarBodega", parametros);

                    if (resultado)
                    {
                        MessageBox.Show("Bodega registrada exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Clear();
                        txtDescripcion.Clear();
                        nudCapacidad.Value=0;

                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al registrar la bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

