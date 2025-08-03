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
            Formularios.NuevoUsuario forma = new Formularios.NuevoUsuario();
            forma.ShowDialog();
            this.Close();
            
        }
    }
}
