namespace ComercializadoraBDII.Formularios
{
    partial class ConsultaProductosAgricultor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProductosAgricultor));
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btBuscar = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvProductos = new DataGridView();
            AgricultorID = new DataGridViewTextBoxColumn();
            Agricultor = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            Quintales = new DataGridViewTextBoxColumn();
            ValorTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
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
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvProductos);
            splitContainer1.Size = new Size(800, 475);
            splitContainer1.SplitterDistance = 183;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(330, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 71);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 31);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 2;
            label4.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 31);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 1;
            label3.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 31);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 0;
            label2.Text = "Agricultor";
            // 
            // btBuscar
            // 
            btBuscar.BackgroundImage = (Image)resources.GetObject("btBuscar.BackgroundImage");
            btBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btBuscar.Location = new Point(617, 78);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 61);
            btBuscar.TabIndex = 3;
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(330, 145);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(362, 23);
            txtBuscar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 31);
            label1.Name = "label1";
            label1.Size = new Size(367, 32);
            label1.TabIndex = 1;
            label1.Text = "PRODUCTOS POR AGRICULTOR";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { AgricultorID, Agricultor, Producto, CodigoProducto, Quintales, ValorTotal });
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(800, 288);
            dgvProductos.TabIndex = 0;
            // 
            // AgricultorID
            // 
            AgricultorID.DataPropertyName = "AgricultorID";
            AgricultorID.HeaderText = "AgricultorID";
            AgricultorID.Name = "AgricultorID";
            AgricultorID.ReadOnly = true;
            // 
            // Agricultor
            // 
            Agricultor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Agricultor.DataPropertyName = "Agricultor";
            Agricultor.HeaderText = "Agricultor";
            Agricultor.Name = "Agricultor";
            Agricultor.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.DataPropertyName = "Producto";
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 150;
            // 
            // CodigoProducto
            // 
            CodigoProducto.DataPropertyName = "CodigoProducto";
            CodigoProducto.HeaderText = "Codigo Producto";
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            CodigoProducto.Width = 130;
            // 
            // Quintales
            // 
            Quintales.DataPropertyName = "Quintales";
            Quintales.HeaderText = "Unidad";
            Quintales.Name = "Quintales";
            Quintales.ReadOnly = true;
            // 
            // ValorTotal
            // 
            ValorTotal.DataPropertyName = "ValorTotal";
            ValorTotal.HeaderText = "Valor Total";
            ValorTotal.Name = "ValorTotal";
            ValorTotal.ReadOnly = true;
            ValorTotal.Width = 130;
            // 
            // ConsultaProductosAgricultor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ConsultaProductosAgricultor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos por Agricultor";
            Load += ConsultaProductosAgricultor_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvProductos;
        private TextBox txtBuscar;
        private Button btBuscar;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private DataGridViewTextBoxColumn AgricultorID;
        private DataGridViewTextBoxColumn Agricultor;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn Quintales;
        private DataGridViewTextBoxColumn ValorTotal;
    }
}