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

        private void registrarLiquidaciónDeCosechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.LiquidacionCosecha forma = new Formularios.LiquidacionCosecha();
            forma.ShowDialog();
        }

        private void registrarAbonoAProductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.AbonosProductor forma = new Formularios.AbonosProductor();
            forma.ShowDialog();
        }

        private void inventarioActualDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.InventarioProductos forma = new Formularios.InventarioProductos();
            forma.ShowDialog();
        }

        private void inventarioDeInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.ConsultarInsumos forma = new Formularios.ConsultarInsumos();
            forma.ShowDialog();
        }

        private void reporteDeComprasYEntregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.OrdenesCompra forma = new Formularios.OrdenesCompra();
            forma.ShowDialog();
        }

        private void consultarDatosDeProductoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.RegistrarCliente forma = new Formularios.RegistrarCliente();
            forma.ShowDialog();
        }

        private void facturarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FacturarProductos forma = new Formularios.FacturarProductos();
            forma.ShowDialog();
        }

        private void productoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.ConsultaProductosAgricultor forma = new Formularios.ConsultaProductosAgricultor();
            forma.ShowDialog();
        }

        private void fincasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.ConsultaInsumosEntregados forma = new Formularios.ConsultaInsumosEntregados();
            forma.ShowDialog();
        }

        private void lotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Consultas.ProduccionPorProductor forma = new Formularios.Consultas.ProduccionPorProductor();
            forma.ShowDialog();
        }

        private void saldoPendientePorProductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Consultas.SaldoProductores forma = new Formularios.Consultas.SaldoProductores();
            forma.ShowDialog();
        }

        private void utilidadPorCosechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Consultas.UtilidadCosecha forma = new Formularios.Consultas.UtilidadCosecha();
            forma.ShowDialog();
        }

        private void registrarPagoAProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.RegistrarPagoProveedor forma = new Formularios.RegistrarPagoProveedor();
            forma.ShowDialog();
        }

        private void saldoPendientePorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Consultas.ProduccionPorProductor forma = new Formularios.Consultas.ProduccionPorProductor();
            forma.ShowDialog();
        }
    }
}
