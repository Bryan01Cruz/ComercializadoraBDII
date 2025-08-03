namespace ComercializadoraBDII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.RegistrarProveedor forma = new Formularios.RegistrarProveedor();
            forma.ShowDialog();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrarProductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.RegistrarProductor forma = new Formularios.RegistrarProductor();
            forma.ShowDialog();
        }

        private void registrarFincaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.RegistrarFinca forma = new Formularios.RegistrarFinca();
            forma.ShowDialog();
        }

        private void registrarLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.RegistrarLote forma = new Formularios.RegistrarLote();
            forma.ShowDialog();
        }

        private void registrarCosechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.RegistrarCosecha forma = new Formularios.RegistrarCosecha();
            forma.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.IniciarSesion forma = new Formularios.IniciarSesion();
            this.Close();
        }

        private void asignarCultivoALoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.RegistrarLote forma = new Formularios.RegistrarLote();
            forma.ShowDialog();
        }

        private void registrarEntregaAProductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.EntregaInsumos forma = new Formularios.EntregaInsumos();
            forma.ShowDialog();
        }

        private void parametrosDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.UsuarioAdministrador forma = new Formularios.UsuarioAdministrador();
            forma.ShowDialog();
        }

        private void registrarCompraAProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.CompraInsumos forma = new Formularios.CompraInsumos();
            forma.ShowDialog();
        }

        private void agregarBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.AgregarBodega forma = new Formularios.AgregarBodega();
            forma.ShowDialog();
        }
    }
}
