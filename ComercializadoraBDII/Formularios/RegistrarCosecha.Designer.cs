namespace ComercializadoraBDII.Formularios
{
    partial class RegistrarCosecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarCosecha));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtCodigoProductor = new TextBox();
            label3 = new Label();
            txtProductor = new TextBox();
            label4 = new Label();
            txtCodigoBodega = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtCodigo = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dgvCosecha = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            nudCantidad = new NumericUpDown();
            nudPrecio = new NumericUpDown();
            label11 = new Label();
            label9 = new Label();
            txtTotal = new TextBox();
            btAgregar = new Button();
            btEliminar = new Button();
            btActualizar = new Button();
            btGuardar = new Button();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            txtBodega = new TextBox();
            label17 = new Label();
            nudDisponible = new NumericUpDown();
            dtpFechaEntrega = new DateTimePicker();
            txtUnidad = new TextBox();
            label10 = new Label();
            cbbFincas = new ComboBox();
            cbbProducto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCosecha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDisponible).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(182, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 196);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar Cosecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 238);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 2;
            label2.Text = "Código de productor:";
            // 
            // txtCodigoProductor
            // 
            txtCodigoProductor.Location = new Point(222, 233);
            txtCodigoProductor.Name = "txtCodigoProductor";
            txtCodigoProductor.Size = new Size(100, 23);
            txtCodigoProductor.TabIndex = 1;
            txtCodigoProductor.TextAlign = HorizontalAlignment.Center;
            txtCodigoProductor.Leave += txtCodigoProductor_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(162, 265);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 5;
            label3.Text = "Nombre:";
            // 
            // txtProductor
            // 
            txtProductor.Enabled = false;
            txtProductor.Location = new Point(229, 264);
            txtProductor.Name = "txtProductor";
            txtProductor.Size = new Size(216, 23);
            txtProductor.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 321);
            label4.Name = "label4";
            label4.Size = new Size(57, 17);
            label4.TabIndex = 7;
            label4.Text = "Bodega:";
            // 
            // txtCodigoBodega
            // 
            txtCodigoBodega.Location = new Point(88, 320);
            txtCodigoBodega.Name = "txtCodigoBodega";
            txtCodigoBodega.Size = new Size(54, 23);
            txtCodigoBodega.TabIndex = 5;
            txtCodigoBodega.Leave += txtCodigoBodega_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(162, 294);
            label5.Name = "label5";
            label5.Size = new Size(116, 17);
            label5.TabIndex = 9;
            label5.Text = "Fecha de entrega:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(234, 351);
            label6.Name = "label6";
            label6.Size = new Size(67, 17);
            label6.TabIndex = 11;
            label6.Text = "Producto:";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(148, 350);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(77, 23);
            txtCodigo.TabIndex = 9;
            txtCodigo.Leave += txtCodigo_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(234, 384);
            label7.Name = "label7";
            label7.Size = new Size(65, 17);
            label7.TabIndex = 14;
            label7.Text = "Cantidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 384);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 17;
            label8.Text = "Precio:";
            // 
            // dgvCosecha
            // 
            dgvCosecha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCosecha.Columns.AddRange(new DataGridViewColumn[] { Codigo, Producto, Cantidad, Unidad, Precio, Total });
            dgvCosecha.Location = new Point(15, 412);
            dgvCosecha.Name = "dgvCosecha";
            dgvCosecha.ReadOnly = true;
            dgvCosecha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCosecha.Size = new Size(578, 167);
            dgvCosecha.TabIndex = 22;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 60;
            // 
            // Unidad
            // 
            Unidad.HeaderText = "Unidad";
            Unidad.Name = "Unidad";
            Unidad.ReadOnly = true;
            Unidad.Width = 60;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 60;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 115;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(304, 381);
            nudCantidad.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(94, 23);
            nudCantidad.TabIndex = 10;
            nudCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(82, 383);
            nudPrecio.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(143, 23);
            nudPrecio.TabIndex = 9;
            nudPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(28, 351);
            label11.Name = "label11";
            label11.Size = new Size(114, 17);
            label11.TabIndex = 26;
            label11.Text = "Código Producto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label9.Location = new Point(380, 593);
            label9.Name = "label9";
            label9.Size = new Size(109, 17);
            label9.TabIndex = 27;
            label9.Text = "Total de compra:";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(488, 592);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(105, 23);
            txtTotal.TabIndex = 29;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btAgregar
            // 
            btAgregar.BackgroundImage = (Image)resources.GetObject("btAgregar.BackgroundImage");
            btAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btAgregar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAgregar.ImageAlign = ContentAlignment.TopCenter;
            btAgregar.Location = new Point(137, 585);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 74);
            btAgregar.TabIndex = 7;
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += button2_Click;
            // 
            // btEliminar
            // 
            btEliminar.BackgroundImage = (Image)resources.GetObject("btEliminar.BackgroundImage");
            btEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEliminar.Location = new Point(218, 585);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(75, 74);
            btEliminar.TabIndex = 8;
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += button3_Click;
            // 
            // btActualizar
            // 
            btActualizar.BackgroundImage = (Image)resources.GetObject("btActualizar.BackgroundImage");
            btActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btActualizar.Location = new Point(299, 585);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(75, 74);
            btActualizar.TabIndex = 9;
            btActualizar.UseVisualStyleBackColor = true;
            btActualizar.Click += btActualizar_Click;
            // 
            // btGuardar
            // 
            btGuardar.BackColor = SystemColors.Control;
            btGuardar.BackgroundImage = (Image)resources.GetObject("btGuardar.BackgroundImage");
            btGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btGuardar.Location = new Point(15, 585);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(84, 74);
            btGuardar.TabIndex = 10;
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(33, 658);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 38;
            label12.Text = "Guardar";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(151, 658);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 39;
            label14.Text = "Agregar";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(232, 658);
            label15.Name = "label15";
            label15.Size = new Size(50, 15);
            label15.TabIndex = 40;
            label15.Text = "Eliminar";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(308, 658);
            label16.Name = "label16";
            label16.Size = new Size(60, 15);
            label16.TabIndex = 41;
            label16.Text = "Actualizar";
            // 
            // txtBodega
            // 
            txtBodega.Enabled = false;
            txtBodega.Location = new Point(148, 320);
            txtBodega.Name = "txtBodega";
            txtBodega.Size = new Size(161, 23);
            txtBodega.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(315, 322);
            label17.Name = "label17";
            label17.Size = new Size(140, 17);
            label17.TabIndex = 43;
            label17.Text = "Capacidad Disponible:";
            // 
            // nudDisponible
            // 
            nudDisponible.Enabled = false;
            nudDisponible.Location = new Point(461, 321);
            nudDisponible.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudDisponible.Name = "nudDisponible";
            nudDisponible.Size = new Size(113, 23);
            nudDisponible.TabIndex = 7;
            nudDisponible.TextAlign = HorizontalAlignment.Right;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.CustomFormat = "dd-MM-yyyy";
            dtpFechaEntrega.Format = DateTimePickerFormat.Custom;
            dtpFechaEntrega.Location = new Point(284, 292);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(125, 23);
            dtpFechaEntrega.TabIndex = 4;
            // 
            // txtUnidad
            // 
            txtUnidad.Enabled = false;
            txtUnidad.Location = new Point(404, 381);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(170, 23);
            txtUnidad.TabIndex = 11;
            txtUnidad.Text = "Quintales";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(328, 236);
            label10.Name = "label10";
            label10.Size = new Size(42, 17);
            label10.TabIndex = 47;
            label10.Text = "Finca:";
            // 
            // cbbFincas
            // 
            cbbFincas.FormattingEnabled = true;
            cbbFincas.Location = new Point(376, 233);
            cbbFincas.Name = "cbbFincas";
            cbbFincas.Size = new Size(144, 23);
            cbbFincas.TabIndex = 2;
            cbbFincas.SelectedIndexChanged += cbbFincas_SelectedIndexChanged;
            // 
            // cbbProducto
            // 
            cbbProducto.FormattingEnabled = true;
            cbbProducto.Location = new Point(304, 350);
            cbbProducto.Name = "cbbProducto";
            cbbProducto.Size = new Size(270, 23);
            cbbProducto.TabIndex = 8;
            cbbProducto.SelectedIndexChanged += cbbProducto_SelectedIndexChanged;
            // 
            // RegistrarCosecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 682);
            Controls.Add(cbbProducto);
            Controls.Add(cbbFincas);
            Controls.Add(label10);
            Controls.Add(txtUnidad);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(nudDisponible);
            Controls.Add(label17);
            Controls.Add(txtBodega);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(btGuardar);
            Controls.Add(btActualizar);
            Controls.Add(btEliminar);
            Controls.Add(btAgregar);
            Controls.Add(txtTotal);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(nudPrecio);
            Controls.Add(nudCantidad);
            Controls.Add(dgvCosecha);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtCodigo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCodigoBodega);
            Controls.Add(label4);
            Controls.Add(txtProductor);
            Controls.Add(label3);
            Controls.Add(txtCodigoProductor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RegistrarCosecha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Cosecha";
            Load += RegistrarCosecha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCosecha).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDisponible).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtCodigoProductor;
        private Label label3;
        private TextBox txtProductor;
        private Label label4;
        private TextBox txtCodigoBodega;
        private Label label5;
        private Label label6;
        private TextBox txtCodigo;
        private Label label7;
        private Label label8;
        private DataGridView dgvCosecha;
        private NumericUpDown nudCantidad;
        private NumericUpDown nudPrecio;
        private Label label11;
        private Label label9;
        private TextBox txtTotal;
        private Button btAgregar;
        private Button btEliminar;
        private Button btActualizar;
        private Button btGuardar;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txtBodega;
        private Label label17;
        private NumericUpDown nudDisponible;
        private DateTimePicker dtpFechaEntrega;
        private TextBox txtUnidad;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
        private Label label10;
        private ComboBox cbbFincas;
        private ComboBox cbbProducto;
    }
}