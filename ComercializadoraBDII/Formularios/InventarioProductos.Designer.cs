namespace ComercializadoraBDII.Formularios
{
    partial class InventarioProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioProductos));
            dgvInventario = new DataGridView();
            splitContainer1 = new SplitContainer();
            btBuscar = new Button();
            gbSeleccion = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            TipoInsumo = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Existencia = new DataGridViewTextBoxColumn();
            ValorInventario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            gbSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { Codigo, Producto, TipoInsumo, Precio, Existencia, ValorInventario });
            dgvInventario.Dock = DockStyle.Fill;
            dgvInventario.Location = new Point(0, 0);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(800, 288);
            dgvInventario.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btBuscar);
            splitContainer1.Panel1.Controls.Add(gbSeleccion);
            splitContainer1.Panel1.Controls.Add(txtBuscar);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvInventario);
            splitContainer1.Size = new Size(800, 475);
            splitContainer1.SplitterDistance = 183;
            splitContainer1.TabIndex = 1;
            // 
            // btBuscar
            // 
            btBuscar.BackgroundImage = (Image)resources.GetObject("btBuscar.BackgroundImage");
            btBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btBuscar.Location = new Point(596, 68);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 55);
            btBuscar.TabIndex = 2;
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // gbSeleccion
            // 
            gbSeleccion.Controls.Add(label3);
            gbSeleccion.Controls.Add(label2);
            gbSeleccion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbSeleccion.Location = new Point(340, 61);
            gbSeleccion.Name = "gbSeleccion";
            gbSeleccion.Size = new Size(250, 62);
            gbSeleccion.TabIndex = 3;
            gbSeleccion.TabStop = false;
            gbSeleccion.Text = "Buscar por";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 28);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 28);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 0;
            label2.Text = "Código";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(340, 129);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(331, 23);
            txtBuscar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 23);
            label1.Name = "label1";
            label1.Size = new Size(348, 32);
            label1.TabIndex = 0;
            label1.Text = "INVENTARIO DE PRODUCTOS";
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 70;
            // 
            // Producto
            // 
            Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producto.DataPropertyName = "Producto";
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // TipoInsumo
            // 
            TipoInsumo.DataPropertyName = "TipoInsumo";
            TipoInsumo.HeaderText = "Tipo Insumo";
            TipoInsumo.Name = "TipoInsumo";
            TipoInsumo.ReadOnly = true;
            TipoInsumo.Width = 130;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 70;
            // 
            // Existencia
            // 
            Existencia.DataPropertyName = "Existencias";
            Existencia.HeaderText = "Existencia";
            Existencia.Name = "Existencia";
            Existencia.ReadOnly = true;
            Existencia.Width = 70;
            // 
            // ValorInventario
            // 
            ValorInventario.DataPropertyName = "ValorInventario";
            ValorInventario.HeaderText = "Valor Inventario";
            ValorInventario.Name = "ValorInventario";
            ValorInventario.ReadOnly = true;
            ValorInventario.Width = 120;
            // 
            // InventarioProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "InventarioProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario de Productos";
            Load += InventarioProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            gbSeleccion.ResumeLayout(false);
            gbSeleccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInventario;
        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox txtBuscar;
        private PictureBox pictureBox1;
        private GroupBox gbSeleccion;
        private Button btBuscar;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn TipoInsumo;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Existencia;
        private DataGridViewTextBoxColumn ValorInventario;
    }
}