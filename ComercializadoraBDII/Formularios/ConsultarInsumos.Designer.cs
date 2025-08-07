namespace ComercializadoraBDII.Formularios
{
    partial class ConsultarInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarInsumos));
            splitContainer1 = new SplitContainer();
            btBuscar = new Button();
            txtBuscar = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvInsumos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Existencias = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            ValorInventario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).BeginInit();
            SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(txtBuscar);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvInsumos);
            splitContainer1.Size = new Size(800, 475);
            splitContainer1.SplitterDistance = 177;
            splitContainer1.TabIndex = 0;
            // 
            // btBuscar
            // 
            btBuscar.BackgroundImage = (Image)resources.GetObject("btBuscar.BackgroundImage");
            btBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btBuscar.Location = new Point(587, 64);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(76, 60);
            btBuscar.TabIndex = 2;
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += button1_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(350, 133);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(313, 23);
            txtBuscar.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(350, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 68);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 31);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 31);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 0;
            label2.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 16);
            label1.Name = "label1";
            label1.Size = new Size(313, 37);
            label1.TabIndex = 1;
            label1.Text = "INVENTARIO INSUMOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(132, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvInsumos
            // 
            dgvInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsumos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Producto, Tipo, Existencias, Precio, ValorInventario });
            dgvInsumos.Dock = DockStyle.Fill;
            dgvInsumos.Location = new Point(0, 0);
            dgvInsumos.Name = "dgvInsumos";
            dgvInsumos.ReadOnly = true;
            dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsumos.Size = new Size(800, 294);
            dgvInsumos.TabIndex = 0;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producto.DataPropertyName = "Producto";
            Producto.HeaderText = "Insumo";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "TipoInsumo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Existencias
            // 
            Existencias.DataPropertyName = "Existencias";
            Existencias.HeaderText = "Existencias";
            Existencias.Name = "Existencias";
            Existencias.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // ValorInventario
            // 
            ValorInventario.DataPropertyName = "ValorInventario";
            ValorInventario.HeaderText = "ValorInventario";
            ValorInventario.Name = "ValorInventario";
            ValorInventario.ReadOnly = true;
            // 
            // ConsultarInsumos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ConsultarInsumos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario de Insumos";
            Load += ConsultarInsumos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private DataGridView dgvInsumos;
        private Button btBuscar;
        private TextBox txtBuscar;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Existencias;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn ValorInventario;
    }
}