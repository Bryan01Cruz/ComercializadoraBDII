namespace ComercializadoraBDII.Formularios.Consultas
{
    partial class ProduccionPorProductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProduccionPorProductor));
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            btBuscar = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvSaldos = new DataGridView();
            ProveedorID = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            TotalCompras = new DataGridViewTextBoxColumn();
            TotalPagado = new DataGridViewTextBoxColumn();
            SaldoPendiente = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaldos).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(btBuscar);
            splitContainer1.Panel1.Controls.Add(txtBuscar);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvSaldos);
            splitContainer1.Size = new Size(800, 475);
            splitContainer1.SplitterDistance = 178;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(335, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 71);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 33);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 1;
            label3.Text = "ProveedorID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 33);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 0;
            label2.Text = "Proveedor";
            // 
            // btBuscar
            // 
            btBuscar.BackgroundImage = (Image)resources.GetObject("btBuscar.BackgroundImage");
            btBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btBuscar.Location = new Point(641, 74);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 65);
            btBuscar.TabIndex = 3;
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(335, 145);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(381, 23);
            txtBuscar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 29);
            label1.Name = "label1";
            label1.Size = new Size(431, 32);
            label1.TabIndex = 1;
            label1.Text = "SALDO PENDIENTE A PROVEEDORES";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dgvSaldos
            // 
            dgvSaldos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaldos.Columns.AddRange(new DataGridViewColumn[] { ProveedorID, Proveedor, TotalCompras, TotalPagado, SaldoPendiente });
            dgvSaldos.Dock = DockStyle.Fill;
            dgvSaldos.Location = new Point(0, 0);
            dgvSaldos.Name = "dgvSaldos";
            dgvSaldos.ReadOnly = true;
            dgvSaldos.Size = new Size(800, 293);
            dgvSaldos.TabIndex = 0;
            // 
            // ProveedorID
            // 
            ProveedorID.DataPropertyName = "ProveedorID";
            ProveedorID.HeaderText = "ProveedorID";
            ProveedorID.Name = "ProveedorID";
            ProveedorID.ReadOnly = true;
            // 
            // Proveedor
            // 
            Proveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Proveedor.DataPropertyName = "Proveedor";
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            Proveedor.ReadOnly = true;
            // 
            // TotalCompras
            // 
            TotalCompras.DataPropertyName = "TotalCompras";
            TotalCompras.HeaderText = "Total de Compras";
            TotalCompras.Name = "TotalCompras";
            TotalCompras.ReadOnly = true;
            TotalCompras.Width = 130;
            // 
            // TotalPagado
            // 
            TotalPagado.DataPropertyName = "TotalPagado";
            TotalPagado.HeaderText = "Total Pagado";
            TotalPagado.Name = "TotalPagado";
            TotalPagado.ReadOnly = true;
            TotalPagado.Width = 130;
            // 
            // SaldoPendiente
            // 
            SaldoPendiente.DataPropertyName = "SaldoPendiente";
            SaldoPendiente.HeaderText = "Saldo Pendiente";
            SaldoPendiente.Name = "SaldoPendiente";
            SaldoPendiente.ReadOnly = true;
            SaldoPendiente.Width = 130;
            // 
            // ProduccionPorProductor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ProduccionPorProductor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saldo Pendiente a Proveedores";
            Load += ProduccionPorProductor_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaldos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private DataGridView dgvSaldos;
        private Label label1;
        private GroupBox groupBox1;
        private Button btBuscar;
        private TextBox txtBuscar;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn ProveedorID;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn TotalCompras;
        private DataGridViewTextBoxColumn TotalPagado;
        private DataGridViewTextBoxColumn SaldoPendiente;
    }
}