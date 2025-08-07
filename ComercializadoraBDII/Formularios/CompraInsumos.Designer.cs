namespace ComercializadoraBDII.Formularios
{
    partial class CompraInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraInsumos));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtCodigoProveedor = new TextBox();
            label3 = new Label();
            txtProveedor = new TextBox();
            label4 = new Label();
            txtCodigoInsumo = new TextBox();
            label5 = new Label();
            dtpVencimiento = new DateTimePicker();
            dtpCompra = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            txtInsumo = new TextBox();
            label8 = new Label();
            nudPrecio = new NumericUpDown();
            label9 = new Label();
            nudCantidad = new NumericUpDown();
            dgvInsumos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Insumo = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btGuardar = new Button();
            btAgregar = new Button();
            btEliminar = new Button();
            btInsertar = new Button();
            label10 = new Label();
            btActualizar = new Button();
            txtSubtotal = new TextBox();
            txtImpuesto = new TextBox();
            txtTotal = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            txtUnidad = new TextBox();
            cbbEstado = new ComboBox();
            label18 = new Label();
            label19 = new Label();
            cbbDescuento = new ComboBox();
            label20 = new Label();
            txtDescuento = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(182, 13);
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
            label1.Location = new Point(164, 198);
            label1.Name = "label1";
            label1.Size = new Size(275, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar Compra de Insumos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 235);
            label2.Name = "label2";
            label2.Size = new Size(141, 17);
            label2.TabIndex = 2;
            label2.Text = "Código de proveedor:";
            // 
            // txtCodigoProveedor
            // 
            txtCodigoProveedor.Location = new Point(256, 235);
            txtCodigoProveedor.Name = "txtCodigoProveedor";
            txtCodigoProveedor.Size = new Size(195, 23);
            txtCodigoProveedor.TabIndex = 1;
            txtCodigoProveedor.TextAlign = HorizontalAlignment.Center;
            txtCodigoProveedor.Leave += txtCodigoProveedor_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 268);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 4;
            label3.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            txtProveedor.Enabled = false;
            txtProveedor.Location = new Point(135, 267);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(217, 23);
            txtProveedor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(76, 303);
            label4.Name = "label4";
            label4.Size = new Size(115, 17);
            label4.TabIndex = 7;
            label4.Text = "Fecha de compra:";
            // 
            // txtCodigoInsumo
            // 
            txtCodigoInsumo.Location = new Point(124, 335);
            txtCodigoInsumo.Name = "txtCodigoInsumo";
            txtCodigoInsumo.Size = new Size(105, 23);
            txtCodigoInsumo.TabIndex = 4;
            txtCodigoInsumo.TextAlign = HorizontalAlignment.Center;
            txtCodigoInsumo.TextChanged += textBox3_TextChanged;
            txtCodigoInsumo.Leave += txtCodigoInsumo_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(304, 303);
            label5.Name = "label5";
            label5.Size = new Size(124, 17);
            label5.TabIndex = 10;
            label5.Text = "Fecha vencimiento:";
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.CustomFormat = "dd-MM-yyyy";
            dtpVencimiento.Format = DateTimePickerFormat.Custom;
            dtpVencimiento.Location = new Point(434, 299);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(96, 23);
            dtpVencimiento.TabIndex = 3;
            // 
            // dtpCompra
            // 
            dtpCompra.CustomFormat = "dd-MM-yyyy";
            dtpCompra.Format = DateTimePickerFormat.Custom;
            dtpCompra.Location = new Point(197, 299);
            dtpCompra.Name = "dtpCompra";
            dtpCompra.Size = new Size(101, 23);
            dtpCompra.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 336);
            label6.Name = "label6";
            label6.Size = new Size(104, 17);
            label6.TabIndex = 14;
            label6.Text = "Código Insumo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(231, 336);
            label7.Name = "label7";
            label7.Size = new Size(57, 17);
            label7.TabIndex = 15;
            label7.Text = "Insumo:";
            // 
            // txtInsumo
            // 
            txtInsumo.Enabled = false;
            txtInsumo.Location = new Point(294, 335);
            txtInsumo.Name = "txtInsumo";
            txtInsumo.Size = new Size(234, 23);
            txtInsumo.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 371);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 17;
            label8.Text = "Precio:";
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(68, 371);
            nudPrecio.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(178, 23);
            nudPrecio.TabIndex = 5;
            nudPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(252, 373);
            label9.Name = "label9";
            label9.Size = new Size(65, 17);
            label9.TabIndex = 19;
            label9.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(323, 373);
            nudCantidad.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(79, 23);
            nudCantidad.TabIndex = 6;
            nudCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // dgvInsumos
            // 
            dgvInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsumos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Insumo, Precio, Cantidad, Unidad, Descuento, Total });
            dgvInsumos.Location = new Point(14, 404);
            dgvInsumos.Name = "dgvInsumos";
            dgvInsumos.ReadOnly = true;
            dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsumos.Size = new Size(578, 151);
            dgvInsumos.TabIndex = 21;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 80;
            // 
            // Insumo
            // 
            Insumo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Insumo.HeaderText = "Insumo";
            Insumo.Name = "Insumo";
            Insumo.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 55;
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
            Unidad.Width = 55;
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 115;
            // 
            // btGuardar
            // 
            btGuardar.BackgroundImage = (Image)resources.GetObject("btGuardar.BackgroundImage");
            btGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btGuardar.Location = new Point(14, 584);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(83, 74);
            btGuardar.TabIndex = 11;
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btAgregar
            // 
            btAgregar.BackgroundImage = (Image)resources.GetObject("btAgregar.BackgroundImage");
            btAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btAgregar.Location = new Point(153, 584);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 74);
            btAgregar.TabIndex = 8;
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // btEliminar
            // 
            btEliminar.BackgroundImage = (Image)resources.GetObject("btEliminar.BackgroundImage");
            btEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btEliminar.Location = new Point(234, 584);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(75, 74);
            btEliminar.TabIndex = 9;
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // btInsertar
            // 
            btInsertar.BackgroundImage = (Image)resources.GetObject("btInsertar.BackgroundImage");
            btInsertar.BackgroundImageLayout = ImageLayout.Stretch;
            btInsertar.Location = new Point(534, 299);
            btInsertar.Name = "btInsertar";
            btInsertar.Size = new Size(58, 54);
            btInsertar.TabIndex = 26;
            btInsertar.UseVisualStyleBackColor = true;
            btInsertar.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(539, 354);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 27;
            label10.Text = "Agregar";
            // 
            // btActualizar
            // 
            btActualizar.BackgroundImage = (Image)resources.GetObject("btActualizar.BackgroundImage");
            btActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btActualizar.Location = new Point(315, 584);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(75, 74);
            btActualizar.TabIndex = 10;
            btActualizar.UseVisualStyleBackColor = true;
            btActualizar.Click += btActualizar_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(478, 564);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(115, 23);
            txtSubtotal.TabIndex = 29;
            // 
            // txtImpuesto
            // 
            txtImpuesto.Enabled = false;
            txtImpuesto.Location = new Point(478, 593);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(115, 23);
            txtImpuesto.TabIndex = 30;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(478, 650);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(115, 23);
            txtTotal.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label11.Location = new Point(416, 567);
            label11.Name = "label11";
            label11.Size = new Size(62, 17);
            label11.TabIndex = 32;
            label11.Text = "Subtotal:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label12.Location = new Point(411, 596);
            label12.Name = "label12";
            label12.Size = new Size(65, 17);
            label12.TabIndex = 33;
            label12.Text = "ISV (15%):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label13.Location = new Point(434, 653);
            label13.Name = "label13";
            label13.Size = new Size(40, 17);
            label13.TabIndex = 34;
            label13.Text = "Total:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(32, 657);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 35;
            label14.Text = "Guardar";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(166, 657);
            label15.Name = "label15";
            label15.Size = new Size(49, 15);
            label15.TabIndex = 36;
            label15.Text = "Agregar";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(324, 657);
            label16.Name = "label16";
            label16.Size = new Size(60, 15);
            label16.TabIndex = 37;
            label16.Text = "Actualizar";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(248, 657);
            label17.Name = "label17";
            label17.Size = new Size(50, 15);
            label17.TabIndex = 38;
            label17.Text = "Eliminar";
            // 
            // txtUnidad
            // 
            txtUnidad.Enabled = false;
            txtUnidad.Location = new Point(411, 268);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(180, 23);
            txtUnidad.TabIndex = 39;
            // 
            // cbbEstado
            // 
            cbbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbEstado.Enabled = false;
            cbbEstado.FormattingEnabled = true;
            cbbEstado.Items.AddRange(new object[] { "Pendiente", "Entregado" });
            cbbEstado.Location = new Point(412, 268);
            cbbEstado.Name = "cbbEstado";
            cbbEstado.Size = new Size(179, 23);
            cbbEstado.TabIndex = 40;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(358, 268);
            label18.Name = "label18";
            label18.Size = new Size(52, 17);
            label18.TabIndex = 41;
            label18.Text = "Estado:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(408, 373);
            label19.Name = "label19";
            label19.Size = new Size(75, 17);
            label19.TabIndex = 42;
            label19.Text = "Descuento:";
            // 
            // cbbDescuento
            // 
            cbbDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbDescuento.FormattingEnabled = true;
            cbbDescuento.Items.AddRange(new object[] { "0%", "5%" });
            cbbDescuento.Location = new Point(489, 372);
            cbbDescuento.Name = "cbbDescuento";
            cbbDescuento.Size = new Size(103, 23);
            cbbDescuento.TabIndex = 7;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(399, 622);
            label20.Name = "label20";
            label20.Size = new Size(75, 17);
            label20.TabIndex = 44;
            label20.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            txtDescuento.Enabled = false;
            txtDescuento.Location = new Point(478, 621);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(113, 23);
            txtDescuento.TabIndex = 45;
            // 
            // CompraInsumos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 682);
            Controls.Add(txtDescuento);
            Controls.Add(label20);
            Controls.Add(cbbDescuento);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(cbbEstado);
            Controls.Add(txtUnidad);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtTotal);
            Controls.Add(txtImpuesto);
            Controls.Add(txtSubtotal);
            Controls.Add(btActualizar);
            Controls.Add(label10);
            Controls.Add(btInsertar);
            Controls.Add(btEliminar);
            Controls.Add(btAgregar);
            Controls.Add(btGuardar);
            Controls.Add(dgvInsumos);
            Controls.Add(nudCantidad);
            Controls.Add(label9);
            Controls.Add(nudPrecio);
            Controls.Add(label8);
            Controls.Add(txtInsumo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtpCompra);
            Controls.Add(dtpVencimiento);
            Controls.Add(label5);
            Controls.Add(txtCodigoInsumo);
            Controls.Add(label4);
            Controls.Add(txtProveedor);
            Controls.Add(label3);
            Controls.Add(txtCodigoProveedor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CompraInsumos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Compra  de Insumos";
            Load += CompraInsumos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtCodigoProveedor;
        private Label label3;
        private TextBox txtProveedor;
        private Label label4;
        private TextBox txtCodigoInsumo;
        private Label label5;
        private DateTimePicker dtpVencimiento;
        private DateTimePicker dtpCompra;
        private Label label6;
        private Label label7;
        private TextBox txtInsumo;
        private Label label8;
        private NumericUpDown nudPrecio;
        private Label label9;
        private NumericUpDown nudCantidad;
        private DataGridView dgvInsumos;
        private Button btGuardar;
        private Button btAgregar;
        private Button btEliminar;
        private Button btInsertar;
        private Label label10;
        private Button btActualizar;
        private TextBox txtSubtotal;
        private TextBox txtImpuesto;
        private TextBox txtTotal;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtUnidad;
        private ComboBox cbbEstado;
        private Label label18;
        private Label label19;
        private ComboBox cbbDescuento;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Insumo;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Total;
        private Label label20;
        private TextBox txtDescuento;
    }
}