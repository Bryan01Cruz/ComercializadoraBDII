namespace ComercializadoraBDII.Formularios
{
    partial class RegistrarPagoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPagoProveedor));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtCodigoProveedor = new TextBox();
            label3 = new Label();
            txtProveedor = new TextBox();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            label5 = new Label();
            cbbMetodo = new ComboBox();
            label6 = new Label();
            txtCompra = new TextBox();
            label7 = new Label();
            nudMonto = new NumericUpDown();
            btAgregar = new Button();
            label8 = new Label();
            cbbCompra = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(130, 12);
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
            label1.Location = new Point(122, 201);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar Pago a Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 244);
            label2.Name = "label2";
            label2.Size = new Size(141, 17);
            label2.TabIndex = 2;
            label2.Text = "Código de Proveedor:";
            // 
            // txtCodigoProveedor
            // 
            txtCodigoProveedor.Location = new Point(250, 243);
            txtCodigoProveedor.Name = "txtCodigoProveedor";
            txtCodigoProveedor.Size = new Size(146, 23);
            txtCodigoProveedor.TabIndex = 1;
            txtCodigoProveedor.TextAlign = HorizontalAlignment.Center;
            txtCodigoProveedor.Leave += txtCodigoProveedor_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(103, 281);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 3;
            label3.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            txtProveedor.Enabled = false;
            txtProveedor.Location = new Point(184, 280);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(212, 23);
            txtProveedor.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(103, 318);
            label4.Name = "label4";
            label4.Size = new Size(100, 17);
            label4.TabIndex = 5;
            label4.Text = "Fecha de pago:";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd-MM-yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(209, 314);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(187, 23);
            dtpFecha.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(103, 353);
            label5.Name = "label5";
            label5.Size = new Size(113, 17);
            label5.TabIndex = 6;
            label5.Text = "Método de pago:";
            // 
            // cbbMetodo
            // 
            cbbMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMetodo.FormattingEnabled = true;
            cbbMetodo.Items.AddRange(new object[] { "Cheque", "Deposito" });
            cbbMetodo.Location = new Point(222, 352);
            cbbMetodo.Name = "cbbMetodo";
            cbbMetodo.Size = new Size(174, 23);
            cbbMetodo.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(103, 388);
            label6.Name = "label6";
            label6.Size = new Size(174, 17);
            label6.TabIndex = 8;
            label6.Text = "Código de compra a pagar:";
            // 
            // txtCompra
            // 
            txtCompra.Location = new Point(184, 582);
            txtCompra.Name = "txtCompra";
            txtCompra.Size = new Size(117, 23);
            txtCompra.TabIndex = 9;
            txtCompra.TextAlign = HorizontalAlignment.Center;
            txtCompra.Visible = false;
            txtCompra.Leave += txtCompra_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(103, 425);
            label7.Name = "label7";
            label7.Size = new Size(121, 17);
            label7.TabIndex = 10;
            label7.Text = "Monto de compra:";
            // 
            // nudMonto
            // 
            nudMonto.Enabled = false;
            nudMonto.Location = new Point(230, 425);
            nudMonto.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(166, 23);
            nudMonto.TabIndex = 11;
            nudMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // btAgregar
            // 
            btAgregar.BackgroundImage = (Image)resources.GetObject("btAgregar.BackgroundImage");
            btAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btAgregar.Location = new Point(217, 463);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 69);
            btAgregar.TabIndex = 5;
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(212, 535);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 13;
            label8.Text = "Registrar Pago";
            // 
            // cbbCompra
            // 
            cbbCompra.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCompra.FormattingEnabled = true;
            cbbCompra.Location = new Point(283, 387);
            cbbCompra.Name = "cbbCompra";
            cbbCompra.Size = new Size(113, 23);
            cbbCompra.TabIndex = 4;
            cbbCompra.SelectedIndexChanged += cbbCompra_SelectedIndexChanged;
            // 
            // RegistrarPagoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 561);
            Controls.Add(cbbCompra);
            Controls.Add(label8);
            Controls.Add(btAgregar);
            Controls.Add(nudMonto);
            Controls.Add(label7);
            Controls.Add(txtCompra);
            Controls.Add(label6);
            Controls.Add(cbbMetodo);
            Controls.Add(label5);
            Controls.Add(dtpFecha);
            Controls.Add(label4);
            Controls.Add(txtProveedor);
            Controls.Add(label3);
            Controls.Add(txtCodigoProveedor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RegistrarPagoProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Pago a Proveedor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
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
        private DateTimePicker dtpFecha;
        private Label label5;
        private ComboBox cbbMetodo;
        private Label label6;
        private TextBox txtCompra;
        private Label label7;
        private NumericUpDown nudMonto;
        private Button btAgregar;
        private Label label8;
        private ComboBox cbbCompra;
    }
}