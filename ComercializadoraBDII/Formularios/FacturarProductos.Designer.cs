namespace ComercializadoraBDII.Formularios
{
    partial class FacturarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturarProductos));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtCodigoCliente = new TextBox();
            label3 = new Label();
            txtCliente = new TextBox();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            label5 = new Label();
            cbbTipoPago = new ComboBox();
            label6 = new Label();
            dvgProductos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            txtCodigo = new TextBox();
            label7 = new Label();
            txtProducto = new TextBox();
            label8 = new Label();
            nudPrecio = new NumericUpDown();
            label9 = new Label();
            nudCantidad = new NumericUpDown();
            txtUnidad = new TextBox();
            label10 = new Label();
            cbbDescuento = new ComboBox();
            btGuardar = new Button();
            btAgregar = new Button();
            btEliminar = new Button();
            btActualizar = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtSubtotal = new TextBox();
            label16 = new Label();
            txtDescuento = new TextBox();
            label17 = new Label();
            txtTotal = new TextBox();
            label18 = new Label();
            txtImpuesto = new TextBox();
            label19 = new Label();
            cbbUnidad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(175, 12);
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
            label1.Location = new Point(206, 197);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 1;
            label1.Text = "Facturar Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 232);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 2;
            label2.Text = "Código cliente:";
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(261, 231);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(172, 23);
            txtCodigoCliente.TabIndex = 1;
            txtCodigoCliente.TextAlign = HorizontalAlignment.Center;
            txtCodigoCliente.Leave += txtCodigoCliente_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(158, 265);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(225, 264);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(208, 23);
            txtCliente.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(97, 298);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 6;
            label4.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd-MM-yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(149, 297);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(107, 23);
            dtpFecha.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(260, 298);
            label5.Name = "label5";
            label5.Size = new Size(91, 17);
            label5.TabIndex = 8;
            label5.Text = "Tipo de pago:";
            // 
            // cbbTipoPago
            // 
            cbbTipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoPago.FormattingEnabled = true;
            cbbTipoPago.Items.AddRange(new object[] { "Credito", "Contado" });
            cbbTipoPago.Location = new Point(357, 297);
            cbbTipoPago.Name = "cbbTipoPago";
            cbbTipoPago.Size = new Size(140, 23);
            cbbTipoPago.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(201, 334);
            label6.Name = "label6";
            label6.Size = new Size(54, 17);
            label6.TabIndex = 10;
            label6.Text = "Codigo:";
            // 
            // dvgProductos
            // 
            dvgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Producto, Precio, Cantidad, Unidad, Descuento, Total });
            dvgProductos.Location = new Point(12, 397);
            dvgProductos.Name = "dvgProductos";
            dvgProductos.ReadOnly = true;
            dvgProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgProductos.Size = new Size(581, 171);
            dvgProductos.TabIndex = 11;
            // 
            // Codigo
            // 
            Codigo.FillWeight = 40F;
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 60;
            // 
            // Producto
            // 
            Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.FillWeight = 40F;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 45;
            // 
            // Cantidad
            // 
            Cantidad.FillWeight = 40F;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 60;
            // 
            // Unidad
            // 
            Unidad.FillWeight = 40F;
            Unidad.HeaderText = "Unidad";
            Unidad.Name = "Unidad";
            Unidad.ReadOnly = true;
            Unidad.Width = 60;
            // 
            // Descuento
            // 
            Descuento.FillWeight = 60F;
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            Descuento.Width = 70;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 110;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(265, 333);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(86, 23);
            txtCodigo.TabIndex = 5;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            txtCodigo.Leave += txtCodigo_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(357, 334);
            label7.Name = "label7";
            label7.Size = new Size(67, 17);
            label7.TabIndex = 13;
            label7.Text = "Producto:";
            // 
            // txtProducto
            // 
            txtProducto.Enabled = false;
            txtProducto.Location = new Point(430, 332);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(139, 23);
            txtProducto.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(29, 366);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 15;
            label8.Text = "Precio:";
            // 
            // nudPrecio
            // 
            nudPrecio.Enabled = false;
            nudPrecio.Location = new Point(83, 366);
            nudPrecio.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(111, 23);
            nudPrecio.TabIndex = 16;
            nudPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(206, 366);
            label9.Name = "label9";
            label9.Size = new Size(65, 17);
            label9.TabIndex = 17;
            label9.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(277, 365);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(83, 23);
            nudCantidad.TabIndex = 6;
            nudCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(445, 366);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(123, 23);
            txtUnidad.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(366, 366);
            label10.Name = "label10";
            label10.Size = new Size(75, 17);
            label10.TabIndex = 20;
            label10.Text = "Descuento:";
            // 
            // cbbDescuento
            // 
            cbbDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbDescuento.FormattingEnabled = true;
            cbbDescuento.Items.AddRange(new object[] { "0%", "5%" });
            cbbDescuento.Location = new Point(446, 366);
            cbbDescuento.Name = "cbbDescuento";
            cbbDescuento.Size = new Size(121, 23);
            cbbDescuento.TabIndex = 7;
            // 
            // btGuardar
            // 
            btGuardar.BackgroundImage = (Image)resources.GetObject("btGuardar.BackgroundImage");
            btGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btGuardar.Location = new Point(12, 583);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(91, 77);
            btGuardar.TabIndex = 11;
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btAgregar
            // 
            btAgregar.BackgroundImage = (Image)resources.GetObject("btAgregar.BackgroundImage");
            btAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btAgregar.Location = new Point(132, 583);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(81, 77);
            btAgregar.TabIndex = 8;
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // btEliminar
            // 
            btEliminar.BackgroundImage = (Image)resources.GetObject("btEliminar.BackgroundImage");
            btEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btEliminar.Location = new Point(219, 583);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(82, 77);
            btEliminar.TabIndex = 9;
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // btActualizar
            // 
            btActualizar.BackgroundImage = (Image)resources.GetObject("btActualizar.BackgroundImage");
            btActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btActualizar.Location = new Point(307, 583);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(90, 77);
            btActualizar.TabIndex = 10;
            btActualizar.UseVisualStyleBackColor = true;
            btActualizar.Click += btActualizar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(33, 663);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 26;
            label11.Text = "Guardar";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(149, 663);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 27;
            label12.Text = "Agregar";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(235, 663);
            label13.Name = "label13";
            label13.Size = new Size(50, 15);
            label13.TabIndex = 28;
            label13.Text = "Eliminar";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(324, 663);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 29;
            label14.Text = "Actualizar";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(423, 573);
            label15.Name = "label15";
            label15.Size = new Size(62, 17);
            label15.TabIndex = 30;
            label15.Text = "Subtotal:";
            label15.Click += label15_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(491, 572);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(102, 23);
            txtSubtotal.TabIndex = 31;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(410, 603);
            label16.Name = "label16";
            label16.Size = new Size(75, 17);
            label16.TabIndex = 32;
            label16.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            txtDescuento.Enabled = false;
            txtDescuento.Location = new Point(491, 601);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(102, 23);
            txtDescuento.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(445, 661);
            label17.Name = "label17";
            label17.Size = new Size(40, 17);
            label17.TabIndex = 34;
            label17.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(491, 660);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(102, 23);
            txtTotal.TabIndex = 35;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(416, 633);
            label18.Name = "label18";
            label18.Size = new Size(69, 17);
            label18.TabIndex = 36;
            label18.Text = "Impuesto:";
            // 
            // txtImpuesto
            // 
            txtImpuesto.Enabled = false;
            txtImpuesto.Location = new Point(491, 630);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(102, 23);
            txtImpuesto.TabIndex = 37;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(29, 332);
            label19.Name = "label19";
            label19.Size = new Size(54, 17);
            label19.TabIndex = 38;
            label19.Text = "Unidad:";
            // 
            // cbbUnidad
            // 
            cbbUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbUnidad.FormattingEnabled = true;
            cbbUnidad.Items.AddRange(new object[] { "Fardos", "Arrobas", "Quintales" });
            cbbUnidad.Location = new Point(83, 332);
            cbbUnidad.Name = "cbbUnidad";
            cbbUnidad.Size = new Size(111, 23);
            cbbUnidad.TabIndex = 4;
            // 
            // FacturarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 689);
            Controls.Add(cbbUnidad);
            Controls.Add(label19);
            Controls.Add(txtImpuesto);
            Controls.Add(label18);
            Controls.Add(txtTotal);
            Controls.Add(label17);
            Controls.Add(txtDescuento);
            Controls.Add(label16);
            Controls.Add(txtSubtotal);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btActualizar);
            Controls.Add(btEliminar);
            Controls.Add(btAgregar);
            Controls.Add(btGuardar);
            Controls.Add(cbbDescuento);
            Controls.Add(label10);
            Controls.Add(txtUnidad);
            Controls.Add(nudCantidad);
            Controls.Add(label9);
            Controls.Add(nudPrecio);
            Controls.Add(label8);
            Controls.Add(txtProducto);
            Controls.Add(label7);
            Controls.Add(txtCodigo);
            Controls.Add(dvgProductos);
            Controls.Add(label6);
            Controls.Add(cbbTipoPago);
            Controls.Add(label5);
            Controls.Add(dtpFecha);
            Controls.Add(label4);
            Controls.Add(txtCliente);
            Controls.Add(label3);
            Controls.Add(txtCodigoCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FacturarProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturar Productos";
            Load += FacturarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtCodigoCliente;
        private Label label3;
        private TextBox txtCliente;
        private Label label4;
        private DateTimePicker dtpFecha;
        private Label label5;
        private ComboBox cbbTipoPago;
        private Label label6;
        private DataGridView dvgProductos;
        private TextBox txtCodigo;
        private Label label7;
        private TextBox txtProducto;
        private Label label8;
        private NumericUpDown nudPrecio;
        private Label label9;
        private NumericUpDown nudCantidad;
        private TextBox txtUnidad;
        private Label label10;
        private ComboBox cbbDescuento;
        private Button btGuardar;
        private Button btAgregar;
        private Button btEliminar;
        private Button btActualizar;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtSubtotal;
        private Label label16;
        private TextBox txtDescuento;
        private Label label17;
        private TextBox txtTotal;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Total;
        private Label label18;
        private TextBox txtImpuesto;
        private Label label19;
        private ComboBox cbbUnidad;
    }
}