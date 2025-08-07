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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = chkVer.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                cbbDepartamento.Text == "" || cbbAdministrador.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var conector = new ConectorSQL();

                    SqlParameter[] parametros = new SqlParameter[]
                    {
                    conector.CrearParametro("@Nombre", txtNombre.Text.Trim()),
                    conector.CrearParametro("@Usuario", txtUsuario.Text.Trim()),
                    conector.CrearParametro("@Contrasena", txtContrasena.Text.Trim()),
                    conector.CrearParametro("@Departamento", cbbDepartamento.Text.Trim()),
                    conector.CrearParametro("@Administrador", cbbAdministrador.Text.Trim()),
                    };

                    bool resultado = conector.EjecutarSP("spInsertarUsuario", parametros);

                    if (resultado)
                    {
                        MessageBox.Show("Usuario registrado exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Clear();
                        txtUsuario.Clear();
                        txtContrasena.Clear();
                        cbbDepartamento.Text="";
                        cbbAdministrador.Text="";
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al registrar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
