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
    public partial class UsuarioAdministrador : Form
    {
        public UsuarioAdministrador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conector = new ConectorSQL();

            var parametros = new SqlParameter[]
            {
                conector.CrearParametro("@Usuario", txtUsuario.Text.Trim()),
                conector.CrearParametro("@Contrasena", txtContrasena.Text.Trim())
            };

            try
            {
                DataTable dt = conector.EjecutarConsulta("spValidarUsuarioAdmin", parametros);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Error al verificar.", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int resultado = Convert.ToInt32(dt.Rows[0]["Resultado"]);

                switch (resultado)
                {
                    case 1:
                        Formularios.NuevoUsuario forma = new Formularios.NuevoUsuario();
                        forma.ShowDialog();
                        this.Close();
                        break;

                    case 0:
                        MessageBox.Show("Acceso denegado. Usuario no autorizado como administrador.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtContrasena.Clear();
                        txtUsuario.Clear();
                        break;

                    case -1:
                        MessageBox.Show("Error al consultar acceso. Verifica tus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                        txtContrasena.Clear();
                        txtUsuario.Clear();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
