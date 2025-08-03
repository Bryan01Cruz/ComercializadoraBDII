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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 forma = new Form1();
            forma.ShowDialog();
            txtUsuario.Clear();
            txtContrasena.Clear();
            chkVer.Checked = false;
        }
    }
}
