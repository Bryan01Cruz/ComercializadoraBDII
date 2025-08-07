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
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = chkVer.Checked ? '\0' : '*';
        }


        private bool ValidarLogin()
        {
            try
            {
                var conector = new ConectorSQL();

                var parametros = new SqlParameter[]
                {
                    conector.CrearParametro("@Usuario", txtUsuario.Text.Trim()),
                    conector.CrearParametro("@Contrasena", txtContrasena.Text.Trim())
                };

                DataTable dt = conector.EjecutarConsulta("config.spValidarUsuario", parametros);

                return dt.Rows.Count > 0 && dt.Rows[0][0].ToString() == "OK";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool accesoValido = ValidarLogin();

            if (accesoValido)
            {
                Form1 forma = new Form1();
                forma.ShowDialog();
                txtUsuario.Clear();
                txtContrasena.Clear();
                chkVer.Checked = false;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
