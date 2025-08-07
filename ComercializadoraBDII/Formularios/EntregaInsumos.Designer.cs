namespace ComercializadoraBDII.Formularios
{
    partial class EntregaInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntregaInsumos));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtCodigoProductor = new TextBox();
            label3 = new Label();
            txtProductor = new TextBox();
            label4 = new Label();
            txtCodigoInsumo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtInsumo = new TextBox();
            label7 = new Label();
            nudPrecio = new NumericUpDown();
            label8 = new Label();
            nudCantidad = new NumericUpDown();
            dgvEntregas = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Insumo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btGuardar = new Button();
            label9 = new Label();
            btAgregar = new Button();
            btEliminar = new Button();
            btActualizar = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtSubtotal = new TextBox();
            txtIGO = new TextBox();
            txtTotal = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            dtpFechaEntrega = new DateTimePicker();
            txtUnidad = new TextBox();
            label16 = new Label();
            cbbDescuento = new ComboBox();
            label17 = new Label();
            txtDescuento = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).BeginInit();
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
            label1.Location = new Point(167, 199);
            label1.Name = "label1";
            label1.Size = new Size(273, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar Entrega de Insumos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 235);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 2;
            label2.Text = "Código de productor:";
            // 
            // txtCodigoProductor
            // 
            txtCodigoProductor.Location = new Point(259, 234);
            txtCodigoProductor.Name = "txtCodigoProductor";
            txtCodigoProductor.Size = new Size(214, 23);
            txtCodigoProductor.TabIndex = 1;
            txtCodigoProductor.TextAlign = HorizontalAlignment.Center;
            txtCodigoProductor.Leave += txtCodigoProductor_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(148, 269);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 5;
            label3.Text = "Productor:";
            // 
            // txtProductor
            // 
            txtProductor.Enabled = false;
            txtProductor.Location = new Point(227, 268);
            txtProductor.Name = "txtProductor";
            txtProductor.Size = new Size(213, 23);
            txtProductor.TabIndex = 6;
            txtProductor.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(148, 302);
            label4.Name = "label4";
            label4.Size = new Size(190, 17);
            label4.TabIndex = 7;
            label4.Text = "Fecha de entrega de insumos:";
            // 
            // txtCodigoInsumo
            // 
            txtCodigoInsumo.Location = new Point(148, 338);
            txtCodigoInsumo.Name = "txtCodigoInsumo";
            txtCodigoInsumo.Size = new Size(64, 23);
            txtCodigoInsumo.TabIndex = 3;
            txtCodigoInsumo.TextAlign = HorizontalAlignment.Center;
            txtCodigoInsumo.Leave += txtCodigoInsumo_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 338);
            label5.Name = "label5";
            label5.Size = new Size(104, 17);
            label5.TabIndex = 10;
            label5.Text = "Código Insumo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(218, 339);
            label6.Name = "label6";
            label6.Size = new Size(57, 17);
            label6.TabIndex = 11;
            label6.Text = "Insumo:";
            label6.Click += label6_Click;
            // 
            // txtInsumo
            // 
            txtInsumo.Enabled = false;
            txtInsumo.Location = new Point(276, 337);
            txtInsumo.Name = "txtInsumo";
            txtInsumo.Size = new Size(197, 23);
            txtInsumo.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 371);
            label7.Name = "label7";
            label7.Size = new Size(48, 17);
            label7.TabIndex = 13;
            label7.Text = "Precio:";
            // 
            // nudPrecio
            // 
            nudPrecio.Enabled = false;
            nudPrecio.Location = new Point(92, 371);
            nudPrecio.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(120, 23);
            nudPrecio.TabIndex = 15;
            nudPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(216, 372);
            label8.Name = "label8";
            label8.Size = new Size(65, 17);
            label8.TabIndex = 16;
            label8.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(282, 371);
            nudCantidad.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(79, 23);
            nudCantidad.TabIndex = 4;
            nudCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // dgvEntregas
            // 
            dgvEntregas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntregas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Insumo, Cantidad, Unidad, Precio, Descuento, Total });
            dgvEntregas.Location = new Point(12, 406);
            dgvEntregas.Name = "dgvEntregas";
            dgvEntregas.ReadOnly = true;
            dgvEntregas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntregas.Size = new Size(578, 151);
            dgvEntregas.TabIndex = 19;
            dgvEntregas.CellContentClick += dgvEntregas_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 60;
            // 
            // Insumo
            // 
            Insumo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Insumo.HeaderText = "Insumo";
            Insumo.Name = "Insumo";
            Insumo.ReadOnly = true;
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
            Precio.Width = 50;
            // 
            // Descuento
            // 
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
            Total.Width = 115;
            // 
            // btGuardar
            // 
            btGuardar.BackgroundImage = (Image)resources.GetObject("btGuardar.BackgroundImage");
            btGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btGuardar.Location = new Point(12, 585);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(84, 74);
            btGuardar.TabIndex = 9;
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 659);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 21;
            label9.Text = "Guardar";
            // 
            // btAgregar
            // 
            btAgregar.BackgroundImage = (Image)resources.GetObject("btAgregar.BackgroundImage");
            btAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btAgregar.Location = new Point(148, 585);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 74);
            btAgregar.TabIndex = 6;
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += button3_Click;
            // 
            // btEliminar
            // 
            btEliminar.BackgroundImage = (Image)resources.GetObject("btEliminar.BackgroundImage");
            btEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btEliminar.Location = new Point(229, 585);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(75, 74);
            btEliminar.TabIndex = 7;
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // btActualizar
            // 
            btActualizar.BackgroundImage = (Image)resources.GetObject("btActualizar.BackgroundImage");
            btActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btActualizar.Location = new Point(310, 585);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(75, 74);
            btActualizar.TabIndex = 8;
            btActualizar.UseVisualStyleBackColor = true;
            btActualizar.Click += btActualizar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(163, 658);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 25;
            label10.Text = "Agregar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(242, 659);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 26;
            label11.Text = "Eliminar";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(318, 658);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 27;
            label12.Text = "Actualizar";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(475, 565);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(115, 23);
            txtSubtotal.TabIndex = 28;
            // 
            // txtIGO
            // 
            txtIGO.Enabled = false;
            txtIGO.Location = new Point(475, 594);
            txtIGO.Name = "txtIGO";
            txtIGO.Size = new Size(115, 23);
            txtIGO.TabIndex = 29;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(475, 652);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(115, 23);
            txtTotal.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label13.Location = new Point(411, 566);
            label13.Name = "label13";
            label13.Size = new Size(62, 17);
            label13.TabIndex = 31;
            label13.Text = "Subtotal:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label14.Location = new Point(409, 595);
            label14.Name = "label14";
            label14.Size = new Size(64, 17);
            label14.TabIndex = 32;
            label14.Text = "IGO (5%):";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label15.Location = new Point(433, 653);
            label15.Name = "label15";
            label15.Size = new Size(40, 17);
            label15.TabIndex = 33;
            label15.Text = "Total:";
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.CustomFormat = "dd-MM-yyyy";
            dtpFechaEntrega.Format = DateTimePickerFormat.Custom;
            dtpFechaEntrega.Location = new Point(344, 298);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(96, 23);
            dtpFechaEntrega.TabIndex = 2;
            // 
            // txtUnidad
            // 
            txtUnidad.Enabled = false;
            txtUnidad.Location = new Point(479, 338);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(106, 23);
            txtUnidad.TabIndex = 35;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(367, 372);
            label16.Name = "label16";
            label16.Size = new Size(75, 17);
            label16.TabIndex = 36;
            label16.Text = "Descuento:";
            label16.Click += label16_Click;
            // 
            // cbbDescuento
            // 
            cbbDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbDescuento.FormattingEnabled = true;
            cbbDescuento.Items.AddRange(new object[] { "0%", "5%" });
            cbbDescuento.Location = new Point(448, 370);
            cbbDescuento.Name = "cbbDescuento";
            cbbDescuento.Size = new Size(137, 23);
            cbbDescuento.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(397, 626);
            label17.Name = "label17";
            label17.Size = new Size(75, 17);
            label17.TabIndex = 38;
            label17.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            txtDescuento.Enabled = false;
            txtDescuento.Location = new Point(476, 623);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(114, 23);
            txtDescuento.TabIndex = 39;
            // 
            // EntregaInsumos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 682);
            Controls.Add(txtDescuento);
            Controls.Add(label17);
            Controls.Add(cbbDescuento);
            Controls.Add(label16);
            Controls.Add(txtUnidad);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(txtTotal);
            Controls.Add(txtIGO);
            Controls.Add(txtSubtotal);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btActualizar);
            Controls.Add(btEliminar);
            Controls.Add(btAgregar);
            Controls.Add(label9);
            Controls.Add(btGuardar);
            Controls.Add(dgvEntregas);
            Controls.Add(nudCantidad);
            Controls.Add(label8);
            Controls.Add(nudPrecio);
            Controls.Add(label7);
            Controls.Add(txtInsumo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCodigoInsumo);
            Controls.Add(label4);
            Controls.Add(txtProductor);
            Controls.Add(label3);
            Controls.Add(txtCodigoProductor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "EntregaInsumos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrega de Insumos a Productor";
            Load += EntregaInsumos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).EndInit();
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
        private TextBox txtCodigoInsumo;
        private Label label5;
        private Label label6;
        private TextBox txtInsumo;
        private Label label7;
        private NumericUpDown nudPrecio;
        private Label label8;
        private NumericUpDown nudCantidad;
        private DataGridView dgvEntregas;
        private Button btGuardar;
        private Label label9;
        private Button btAgregar;
        private Button btEliminar;
        private Button btActualizar;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtSubtotal;
        private TextBox txtIGO;
        private TextBox txtTotal;
        private Label label13;
        private Label label14;
        private Label label15;
        private DateTimePicker dtpFechaEntrega;
        private TextBox txtUnidad;
        private Label label16;
        private ComboBox cbbDescuento;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Insumo;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Total;
        private Label label17;
        private TextBox txtDescuento;
    }
}